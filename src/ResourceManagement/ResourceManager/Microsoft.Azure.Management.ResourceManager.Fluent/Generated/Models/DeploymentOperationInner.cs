// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resource.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment operation information.
    /// </summary>
    public partial class DeploymentOperationInner
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentOperationInner class.
        /// </summary>
        public DeploymentOperationInner() { }

        /// <summary>
        /// Initializes a new instance of the DeploymentOperationInner class.
        /// </summary>
        /// <param name="id">Full deployment operation id.</param>
        /// <param name="operationId">Deployment operation id.</param>
        /// <param name="properties">Deployment properties.</param>
        public DeploymentOperationInner(string id = default(string), string operationId = default(string), DeploymentOperationProperties properties = default(DeploymentOperationProperties))
        {
            Id = id;
            OperationId = operationId;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets full deployment operation id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets deployment operation id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets deployment properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public DeploymentOperationProperties Properties { get; set; }

    }
}