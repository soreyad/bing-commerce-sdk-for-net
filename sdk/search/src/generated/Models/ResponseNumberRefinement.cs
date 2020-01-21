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
    /// Defines a discrete number refinement on a numeric field.
    /// </summary>
    [Newtonsoft.Json.JsonObject("NumberRefinement")]
    public partial class ResponseNumberRefinement : ResponseRefinementBase
    {
        /// <summary>
        /// Initializes a new instance of the ResponseNumberRefinement class.
        /// </summary>
        public ResponseNumberRefinement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseNumberRefinement class.
        /// </summary>
        /// <param name="estimatedCount">An estimate of the number of items in
        /// this refinement.</param>
        /// <param name="value">The actual filter value used to filter the list
        /// of items.</param>
        public ResponseNumberRefinement(long? estimatedCount = default(long?), double? value = default(double?))
            : base(estimatedCount)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the actual filter value used to filter the list of
        /// items.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}