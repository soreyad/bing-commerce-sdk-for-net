// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResponseBingMatchingStream
    {
        /// <summary>
        /// Initializes a new instance of the ResponseBingMatchingStream class.
        /// </summary>
        public ResponseBingMatchingStream()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseBingMatchingStream class.
        /// </summary>
        public ResponseBingMatchingStream(string name = default(string), int? score = default(int?))
        {
            Name = name;
            Score = score;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public int? Score { get; set; }

    }
}