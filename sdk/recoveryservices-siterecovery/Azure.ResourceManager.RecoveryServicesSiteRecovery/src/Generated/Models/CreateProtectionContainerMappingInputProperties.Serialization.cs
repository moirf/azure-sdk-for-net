// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class CreateProtectionContainerMappingInputProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetProtectionContainerId))
            {
                writer.WritePropertyName("targetProtectionContainerId"u8);
                writer.WriteStringValue(TargetProtectionContainerId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(ProviderSpecificInput))
            {
                writer.WritePropertyName("providerSpecificInput"u8);
                writer.WriteObjectValue(ProviderSpecificInput);
            }
            writer.WriteEndObject();
        }
    }
}
