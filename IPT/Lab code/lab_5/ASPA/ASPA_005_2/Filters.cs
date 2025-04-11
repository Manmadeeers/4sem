using DAL004;
using CustomExceptions;

namespace Filters
{

    public class SurenameFilter : IEndpointFilter
    {
        public static Repository rep { get; set; }


        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var celebrity = context.GetArgument<Celebrity>(0);
            if(celebrity == null)
            {
                throw new CelebrityArgumentExeption("POST:Attmpted to add a null Celebrity", 500);
            }
            if (String.IsNullOrWhiteSpace(celebrity.Surname) || celebrity.Surname.Length < 2)
            {
                throw new CelebrityArgumentExeption("POST:Attempted to add a Celebrity with null or too small surename", 409);
            }

            if (rep._celebrities.Any(c => c.Surname == celebrity.Surname))
            {
                throw new CelebrityArgumentExeption("POST:Attempted to add a Celebrity with an already existing surename", 409);
            }

            return await next(context);
        }

    }


    public class PhotoExistsFilter : IEndpointFilter
    {
        public static Repository rep { get; set; }


        public async ValueTask<object?>InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var celebrity = context.GetArgument<Celebrity>(0);

            if (celebrity == null)
            {
                throw new CelebrityArgumentExeption("POST:Attempted to add a null Celebrity", 500);
         
            }
            if (!File.Exists(Path.Combine(rep.BasePath, Path.GetFileName(celebrity.PhotoPath))))
            {
                context.HttpContext.Response.Headers["X-Celebrity"] = $"Not found: {Path.Combine(rep.BasePath, celebrity.PhotoPath)}";
            }

            return await next(context);
        }


    }


    public class DeletionFilter : IEndpointFilter
    {
        public static Repository rep { get; set; }

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var id = context.GetArgument<int>(0);
            if(rep.GetCelebrityById(id) == null)
            {
                throw new DeletionException("DELETE:Could not delete a celebrity. Such instance does not exist");
            }

            return await next(context);
        }
    }


    public class PutFilter : IEndpointFilter
    {
        public static Repository rep { get; set; }

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var id = context.GetArgument<int>(0);
            var celebrity = context.GetArgument<Celebrity>(1);

            if (celebrity.Id!=0&&id != celebrity.Id)
            {
                throw new PutException($"PUT:Celebrity id was different from the entered id");
            }

            if(rep.GetCelebrityById(id) == null)
            {
                throw new PutException("PUT: Could not update celebrity. Such instance does not exist");
            }

            if (String.IsNullOrWhiteSpace(celebrity.Surname) || celebrity.Surname.Length < 2)
            {
                throw new CelebrityArgumentExeption("PUT: Attempted to update a celebrity with null or too small surename", 409);
            }
            return await next(context);
        }
    }
}
