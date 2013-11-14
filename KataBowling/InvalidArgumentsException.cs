using System;

namespace KataBowling
{
    public class InvalidArgumentsException : Exception
    {
        public InvalidArgumentsException(string message)
            : base(message + "is not a valid arugment to this program.")
        {
        }
    }
}
