// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Security assessment on a resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SecurityAssessment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SecurityAssessment class.
        /// </summary>
        public SecurityAssessment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityAssessment class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="displayName">User friendly display name of the
        /// assessment</param>
        /// <param name="additionalData">Additional data regarding the
        /// assessment</param>
        public SecurityAssessment(ResourceDetails resourceDetails, AssessmentStatus status, string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), IDictionary<string, string> additionalData = default(IDictionary<string, string>), AssessmentLinks links = default(AssessmentLinks))
            : base(id, name, type)
        {
            ResourceDetails = resourceDetails;
            DisplayName = displayName;
            Status = status;
            AdditionalData = additionalData;
            Links = links;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceDetails")]
        public ResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Gets user friendly display name of the assessment
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public AssessmentStatus Status { get; set; }

        /// <summary>
        /// Gets or sets additional data regarding the assessment
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalData")]
        public IDictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.links")]
        public AssessmentLinks Links { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceDetails");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Status != null)
            {
                Status.Validate();
            }
        }
    }
}
