using CookingTrickery.Core.ModelBinders;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.ModelBinders
{
    public class DoubleModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if(context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(Double) || context.Metadata.ModelType == typeof(Double?))
            {
                return new DoubleModelBinder();
            }

            return null;
        }
    }
}
