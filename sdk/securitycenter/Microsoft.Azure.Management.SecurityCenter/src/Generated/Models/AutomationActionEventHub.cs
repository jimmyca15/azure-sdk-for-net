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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The target Event Hub to which event data will be exported.
    /// </summary>
    [Newtonsoft.Json.JsonObject("EventHub")]
    public partial class AutomationActionEventHub : AutomationAction
    {
        /// <summary>
        /// Initializes a new instance of the AutomationActionEventHub class.
        /// </summary>
        public AutomationActionEventHub()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationActionEventHub class.
        /// </summary>
        /// <param name="eventHubResourceId">The target Event Hub Azure
        /// Resource ID.</param>
        public AutomationActionEventHub(string eventHubResourceId = default(string))
        {
            EventHubResourceId = eventHubResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the target Event Hub Azure Resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubResourceId")]
        public string EventHubResourceId { get; set; }

    }
}
