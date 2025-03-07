// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Connector write settings.
    /// Please note <see cref="StoreWriteSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureBlobFSWriteSettings"/>, <see cref="AzureBlobStorageWriteSettings"/>, <see cref="AzureDataLakeStoreWriteSettings"/>, <see cref="AzureFileStorageWriteSettings"/>, <see cref="FileServerWriteSettings"/> and <see cref="SftpWriteSettings"/>.
    /// </summary>
    public partial class StoreWriteSettings
    {
        /// <summary> Initializes a new instance of StoreWriteSettings. </summary>
        public StoreWriteSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of StoreWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal StoreWriteSettings(string type, object maxConcurrentConnections, object copyBehavior, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            MaxConcurrentConnections = maxConcurrentConnections;
            CopyBehavior = copyBehavior;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The write setting type. </summary>
        internal string Type { get; set; }
        /// <summary> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </summary>
        public object MaxConcurrentConnections { get; set; }
        /// <summary> The type of copy behavior for copy sink. </summary>
        public object CopyBehavior { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
