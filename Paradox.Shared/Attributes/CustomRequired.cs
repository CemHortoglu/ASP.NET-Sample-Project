using Microsoft.Extensions.Localization;
using Paradox.Shared.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Shared.Attributes
{
    public class CustomRequired : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                ErrorMessageResourceType = typeof(Localization);
                ErrorMessage = "FieldShouldNotBeEmpty";
                var errorMessage = FormatErrorMessage(ErrorMessage = "FieldShouldNotBeEmpty");
                return new ValidationResult(errorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
