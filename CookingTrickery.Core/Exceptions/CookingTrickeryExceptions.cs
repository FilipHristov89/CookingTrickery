namespace CookingTrickery.Core.Exceptions
{
    public class CookingTrickeryExceptions : ApplicationException
    {
        public CookingTrickeryExceptions()
        {

        }

        public CookingTrickeryExceptions(string errorMessage)
            :   base(errorMessage)
        {

        }
    }
}
