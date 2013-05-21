using Newtonsoft.Json.Serialization;

namespace KnockoutTodoExample.App_Start
{
    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToCamelCase();
        }
    }
}