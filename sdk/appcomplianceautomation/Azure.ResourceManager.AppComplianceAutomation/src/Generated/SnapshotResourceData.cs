// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A class representing the SnapshotResource data model.
    /// A class represent a AppComplianceAutomation snapshot resource.
    /// </summary>
    public partial class SnapshotResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of SnapshotResourceData. </summary>
        public SnapshotResourceData()
        {
        }

        /// <summary> Initializes a new instance of SnapshotResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Snapshot&apos;s property&apos;. </param>
        internal SnapshotResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SnapshotProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Snapshot&apos;s property&apos;. </summary>
        public SnapshotProperties Properties { get; }
    }
}
