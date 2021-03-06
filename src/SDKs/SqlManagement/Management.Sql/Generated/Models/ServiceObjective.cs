// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a database service objective.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceObjective : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceObjective class.
        /// </summary>
        public ServiceObjective()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceObjective class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="serviceObjectiveName">The name for the service
        /// objective.</param>
        /// <param name="isDefault">Gets whether the service level objective is
        /// the default service objective.</param>
        /// <param name="isSystem">Gets whether the service level objective is
        /// a system service objective.</param>
        /// <param name="description">The description for the service level
        /// objective.</param>
        /// <param name="enabled">Gets whether the service level objective is
        /// enabled.</param>
        public ServiceObjective(string id = default(string), string name = default(string), string type = default(string), string serviceObjectiveName = default(string), bool isDefault = default(bool), bool isSystem = default(bool), string description = default(string), bool enabled = default(bool))
            : base(id, name, type)
        {
            ServiceObjectiveName = serviceObjectiveName;
            IsDefault = isDefault;
            IsSystem = isSystem;
            Description = description;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name for the service objective.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceObjectiveName")]
        public string ServiceObjectiveName { get; private set; }

        /// <summary>
        /// Gets whether the service level objective is the default service
        /// objective.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isDefault")]
        public bool IsDefault { get; private set; }

        /// <summary>
        /// Gets whether the service level objective is a system service
        /// objective.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isSystem")]
        public bool IsSystem { get; private set; }

        /// <summary>
        /// Gets the description for the service level objective.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets whether the service level objective is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool Enabled { get; private set; }

    }
}
