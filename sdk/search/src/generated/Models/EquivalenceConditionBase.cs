// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
    /// Defines the abstract base type for conditions that does an exact match
    /// for a field.
    /// </summary>
    public partial class EquivalenceConditionBase : FieldConditionBase
    {
        /// <summary>
        /// Initializes a new instance of the EquivalenceConditionBase class.
        /// </summary>
        public EquivalenceConditionBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EquivalenceConditionBase class.
        /// </summary>
        /// <param name="field">The name of the field.</param>
        /// <param name="operatorProperty">Possible values include: 'Eq',
        /// 'Ne'</param>
        public EquivalenceConditionBase(string field = default(string), EquivalenceOperator? operatorProperty = default(EquivalenceOperator?))
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
        /// Gets or sets possible values include: 'Eq', 'Ne'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public EquivalenceOperator? OperatorProperty { get; set; }

    }
}