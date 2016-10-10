// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The certificate operation update parameters.
    /// </summary>
    public partial class CertificateOperationUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CertificateOperationUpdateParameter class.
        /// </summary>
        public CertificateOperationUpdateParameter() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CertificateOperationUpdateParameter class.
        /// </summary>
        /// <param name="cancellationRequested">Indicates if cancellation was
        /// requested on the certificate operation.</param>
        public CertificateOperationUpdateParameter(bool cancellationRequested)
        {
            CancellationRequested = cancellationRequested;
        }

        /// <summary>
        /// Gets or sets indicates if cancellation was requested on the
        /// certificate operation.
        /// </summary>
        [JsonProperty(PropertyName = "cancellation_requested")]
        public bool CancellationRequested { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}