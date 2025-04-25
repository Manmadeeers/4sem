namespace Exceptions
{
    public class DeleteByIdException : Exception
    {
        public DeleteByIdException() { }
        public DeleteByIdException(string message) : base(message) { }
    }

    public class  GetByIdException:Exception
    {
        public GetByIdException() { }
        public GetByIdException(string message) : base(message) { }
    }


    public class AddException : Exception
    {
        public AddException() { }
        public AddException(string message) : base(message) { }
    }

    public class UpdateException : Exception
    {
        public UpdateException() { }
        public UpdateException(string message) : base(message) { }
    }
}
