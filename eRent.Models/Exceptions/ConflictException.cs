using System;

namespace eRent.Models.Exceptions
{
    public class ConflictException: Exception
    {
        public ConflictException(string message) : base(message)
        {
        }
    }
}
