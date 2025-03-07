// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Collection of Service resources. </summary>
    internal partial class ServicesListResult
    {
        /// <summary> Initializes a new instance of ServicesListResult. </summary>
        internal ServicesListResult()
        {
            Value = new ChangeTrackingList<SupportAzureServiceData>();
        }

        /// <summary> Initializes a new instance of ServicesListResult. </summary>
        /// <param name="value"> List of Service resources. </param>
        internal ServicesListResult(IReadOnlyList<SupportAzureServiceData> value)
        {
            Value = value;
        }

        /// <summary> List of Service resources. </summary>
        public IReadOnlyList<SupportAzureServiceData> Value { get; }
    }
}
