// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.Commerce.Ingestion.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains the definition for the index field. A field represents a
    /// single unit of data.
    /// </summary>
    public partial class IndexField
    {
        /// <summary>
        /// Initializes a new instance of the IndexField class.
        /// </summary>
        public IndexField()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IndexField class.
        /// </summary>
        /// <param name="name">Index field name.</param>
        /// <param name="type">Possible values include: 'Unknown', 'String',
        /// 'Boolean', 'Number', 'ProductId', 'DupId', 'StaticRank', 'Url',
        /// 'ImageUrl', 'Title', 'Description', 'Category', 'Price', 'Rating',
        /// 'Brand', 'Model', 'Color', 'Size', 'Material', 'Gender',
        /// 'AgeGroup', 'Array', 'Dictionary', 'ExcludeFlag', 'Identifier',
        /// 'Object', 'DocumentId', 'Author', 'CreatedAt', 'ModifiedAt',
        /// 'Paragraph', 'SubHeading', 'SectionHeader', 'Address',
        /// 'RatingCount', 'ReviewCount', 'RatingScale', 'Amenities',
        /// 'StreetAddress', 'Locality', 'SubRegion', 'AddressRegion',
        /// 'PostalCode', 'PostOfficeBoxNumber', 'Country', 'CountryIso',
        /// 'Neighborhood', 'OtherAreas', 'PhoneNumber', 'Barcode',
        /// 'SecondaryImageUrls'</param>
        /// <param name="facetable">Enables using the field for facets and
        /// other field-based aggregations.</param>
        /// <param name="filterable">Enables using the field in filter and
        /// boost conditions.</param>
        /// <param name="retrievable">Enables using the field values in search
        /// response.</param>
        /// <param name="searchable">Enables text matching on the
        /// field.</param>
        /// <param name="sortable">Enables sorting results by the
        /// field.</param>
        /// <param name="fieldLabel">A label to use with the field.</param>
        /// <param name="fields">A child list of fields.</param>
        public IndexField(string name = default(string), IndexFieldType? type = default(IndexFieldType?), bool? facetable = default(bool?), bool? filterable = default(bool?), bool? retrievable = default(bool?), bool? searchable = default(bool?), bool? sortable = default(bool?), string fieldLabel = default(string), IList<IndexField> fields = default(IList<IndexField>))
        {
            Name = name;
            Type = type;
            Facetable = facetable;
            Filterable = filterable;
            Retrievable = retrievable;
            Searchable = searchable;
            Sortable = sortable;
            FieldLabel = fieldLabel;
            Fields = fields;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets index field name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Unknown', 'String',
        /// 'Boolean', 'Number', 'ProductId', 'DupId', 'StaticRank', 'Url',
        /// 'ImageUrl', 'Title', 'Description', 'Category', 'Price', 'Rating',
        /// 'Brand', 'Model', 'Color', 'Size', 'Material', 'Gender',
        /// 'AgeGroup', 'Array', 'Dictionary', 'ExcludeFlag', 'Identifier',
        /// 'Object', 'DocumentId', 'Author', 'CreatedAt', 'ModifiedAt',
        /// 'Paragraph', 'SubHeading', 'SectionHeader', 'Address',
        /// 'RatingCount', 'ReviewCount', 'RatingScale', 'Amenities',
        /// 'StreetAddress', 'Locality', 'SubRegion', 'AddressRegion',
        /// 'PostalCode', 'PostOfficeBoxNumber', 'Country', 'CountryIso',
        /// 'Neighborhood', 'OtherAreas', 'PhoneNumber', 'Barcode',
        /// 'SecondaryImageUrls'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public IndexFieldType? Type { get; set; }

        /// <summary>
        /// Gets or sets enables using the field for facets and other
        /// field-based aggregations.
        /// </summary>
        [JsonProperty(PropertyName = "facetable")]
        public bool? Facetable { get; set; }

        /// <summary>
        /// Gets or sets enables using the field in filter and boost
        /// conditions.
        /// </summary>
        [JsonProperty(PropertyName = "filterable")]
        public bool? Filterable { get; set; }

        /// <summary>
        /// Gets or sets enables using the field values in search response.
        /// </summary>
        [JsonProperty(PropertyName = "retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// Gets or sets enables text matching on the field.
        /// </summary>
        [JsonProperty(PropertyName = "searchable")]
        public bool? Searchable { get; set; }

        /// <summary>
        /// Gets or sets enables sorting results by the field.
        /// </summary>
        [JsonProperty(PropertyName = "sortable")]
        public bool? Sortable { get; set; }

        /// <summary>
        /// Gets or sets a label to use with the field.
        /// </summary>
        [JsonProperty(PropertyName = "fieldLabel")]
        public string FieldLabel { get; set; }

        /// <summary>
        /// Gets or sets a child list of fields.
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public IList<IndexField> Fields { get; set; }

    }
}
