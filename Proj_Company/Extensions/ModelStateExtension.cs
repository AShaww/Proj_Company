using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Proj_Company.Extensions
{
    public static class ModelStateExtension
    {
      public static void AddToModelState(this ValidationResult result, ModelStateDictionary modelState)
        {
            if(!result.IsValid)
            {
                foreach(var err in result.Errors)
                {
                    modelState.AddModelError(err.PropertyName, err.ErrorMessage);
                }
            }
        }
    }
}
