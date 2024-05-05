/*
 * Criativei API
 *
 * API responsible for managing the distribution of images in their folders 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: agoisrj@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = criativei_server.Client.OpenAPIDateConverter;

namespace criativei_server.Model
{
    /// <summary>
    /// PageMetadata
    /// </summary>
    [DataContract(Name = "PageMetadata")]
    public partial class PageMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageMetadata" /> class.
        /// </summary>
        /// <param name="size">size.</param>
        /// <param name="totalElements">totalElements.</param>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="number">number.</param>
        /// <param name="hasNext">hasNext.</param>
        /// <param name="hasPrev">hasPrev.</param>
        /// <param name="firstPage">firstPage.</param>
        /// <param name="lastPage">lastPage.</param>
        public PageMetadata(long size = default(long), long totalElements = default(long), long totalPages = default(long), long number = default(long), bool hasNext = default(bool), bool hasPrev = default(bool), long firstPage = default(long), long lastPage = default(long))
        {
            this.Size = size;
            this.TotalElements = totalElements;
            this.TotalPages = totalPages;
            this.Number = number;
            this.HasNext = hasNext;
            this.HasPrev = hasPrev;
            this.FirstPage = firstPage;
            this.LastPage = lastPage;
        }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long Size { get; set; }

        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name = "totalElements", EmitDefaultValue = false)]
        public long TotalElements { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name = "totalPages", EmitDefaultValue = false)]
        public long TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public long Number { get; set; }

        /// <summary>
        /// Gets or Sets HasNext
        /// </summary>
        [DataMember(Name = "hasNext", EmitDefaultValue = true)]
        public bool HasNext { get; set; }

        /// <summary>
        /// Gets or Sets HasPrev
        /// </summary>
        [DataMember(Name = "hasPrev", EmitDefaultValue = true)]
        public bool HasPrev { get; set; }

        /// <summary>
        /// Gets or Sets FirstPage
        /// </summary>
        [DataMember(Name = "firstPage", EmitDefaultValue = false)]
        public long FirstPage { get; set; }

        /// <summary>
        /// Gets or Sets LastPage
        /// </summary>
        [DataMember(Name = "lastPage", EmitDefaultValue = false)]
        public long LastPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageMetadata {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  HasNext: ").Append(HasNext).Append("\n");
            sb.Append("  HasPrev: ").Append(HasPrev).Append("\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
