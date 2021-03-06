// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SwaggerTest.RestApiRef.Models
{
    using System.Linq;

    public partial class ValueViewModel
    {
        /// <summary>
        /// Initializes a new instance of the ValueViewModel class.
        /// </summary>
        public ValueViewModel() { }

        /// <summary>
        /// Initializes a new instance of the ValueViewModel class.
        /// </summary>
        public ValueViewModel(string name, int value, int? id = default(int?))
        {
            Id = id;
            Name = name;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
