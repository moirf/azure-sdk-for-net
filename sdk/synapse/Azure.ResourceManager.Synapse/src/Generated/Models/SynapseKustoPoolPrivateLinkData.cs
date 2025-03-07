// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Class representing a Private Link Resources. </summary>
    public partial class SynapseKustoPoolPrivateLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of SynapseKustoPoolPrivateLinkData. </summary>
        public SynapseKustoPoolPrivateLinkData()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SynapseKustoPoolPrivateLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The Private link resources GroupId. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource required zone names. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        internal SynapseKustoPoolPrivateLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames, ResourceProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            ProvisioningState = provisioningState;
        }

        /// <summary> The Private link resources GroupId. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource required zone names. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
    }
}
