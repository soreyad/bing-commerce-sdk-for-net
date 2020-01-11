// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the abstract base type for conditions that matches with a set
    /// of values.
    /// </summary>
    public partial class SetConditionBase : FieldConditionBase
    {
        /// <summary>
        /// Initializes a new instance of the SetConditionBase class.
        /// </summary>
        public SetConditionBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetConditionBase class.
        /// </summary>
        /// <param name="field">The name of the field.</param>
        /// <param name="operatorProperty">Possible values include: 'In',
        /// 'NotIn'</param>
        public SetConditionBase(string field = default(string), SetOperator? operatorProperty = default(SetOperator?))
            : base(field)
        {
            OperatorProperty = operatorProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'In', 'NotIn'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public SetOperator? OperatorProperty { get; set; }

    }
}
