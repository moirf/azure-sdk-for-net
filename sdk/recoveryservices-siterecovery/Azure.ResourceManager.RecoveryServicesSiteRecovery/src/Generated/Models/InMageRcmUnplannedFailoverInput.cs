// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm provider specific input for unplanned failover. </summary>
    public partial class InMageRcmUnplannedFailoverInput : UnplannedFailoverProviderSpecificInput
    {
        /// <summary> Initializes a new instance of InMageRcmUnplannedFailoverInput. </summary>
        /// <param name="performShutdown"> A value indicating whether VM is to be shutdown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="performShutdown"/> is null. </exception>
        public InMageRcmUnplannedFailoverInput(string performShutdown)
        {
            Argument.AssertNotNull(performShutdown, nameof(performShutdown));

            PerformShutdown = performShutdown;
            InstanceType = "InMageRcm";
        }

        /// <summary> A value indicating whether VM is to be shutdown. </summary>
        public string PerformShutdown { get; }
        /// <summary> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public string RecoveryPointId { get; set; }
    }
}
