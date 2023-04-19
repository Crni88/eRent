using System;

namespace eRent.Models
{
    public class UserException : Exception
    {
        public UserException(string message):base(message) {
         
        }
    } 
}
