using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace CookingTrickery.Core.ModelBinders
{
    public class DoubleModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            ValueProviderResult result = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName);

            if (result != ValueProviderResult.None && !string.IsNullOrEmpty(result.FirstValue))
            {
                double doubleValue = 0D;
                bool success = false;

                try
                {
                    string formatingValue = result.FirstValue;
                    formatingValue = formatingValue
                        .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    formatingValue = formatingValue
                        .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    doubleValue = Convert.ToDouble(formatingValue, CultureInfo.CurrentCulture);
                    success = true;
                }
                catch (FormatException fe)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, fe, bindingContext.ModelMetadata);
                }


                if (success)
                {
                    bindingContext.Result = ModelBindingResult.Success(doubleValue);
                }
            }

            return Task.CompletedTask;
        }
    }
}
