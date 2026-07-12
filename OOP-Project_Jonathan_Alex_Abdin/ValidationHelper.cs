using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Static Helper Class 
    public static class ValidationHelper
    {
        // Method to check for empty strings (like Driver names or IDs, for example).
        public static bool IsValidString(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}