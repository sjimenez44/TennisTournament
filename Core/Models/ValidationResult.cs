using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Models
{
    public class ValidationResult
    {
        public List<string> ErrorMessage { get; set; } = new List<string>();
        public bool IsValid { get { return !this.ErrorMessage.Any(); } }
    }
}
