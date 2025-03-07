// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Create network mappings input properties/behavior specific to Azure to Azure Network mapping. </summary>
    public partial class AzureToAzureCreateNetworkMappingInput : FabricSpecificCreateNetworkMappingInput
    {
        /// <summary> Initializes a new instance of AzureToAzureCreateNetworkMappingInput. </summary>
        /// <param name="primaryNetworkId"> The primary azure vnet Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryNetworkId"/> is null. </exception>
        public AzureToAzureCreateNetworkMappingInput(string primaryNetworkId)
        {
            Argument.AssertNotNull(primaryNetworkId, nameof(primaryNetworkId));

            PrimaryNetworkId = primaryNetworkId;
            InstanceType = "AzureToAzure";
        }

        /// <summary> The primary azure vnet Id. </summary>
        public string PrimaryNetworkId { get; }
    }
}
