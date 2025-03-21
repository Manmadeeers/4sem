namespace CustomExceptions
{
    public class FoundByIdException:Exception
    {
        public FoundByIdException(string message) : base(message) { }
    }
    public class AddCelebrityException : Exception
    {
       public AddCelebrityException(string message) : base(message) { }
    }

    public class SaveException : Exception
    {
        public SaveException(string message) : base(message) { }
    }
}
