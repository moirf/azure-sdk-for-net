// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesAccountDeploymentScaleSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScaleType))
            {
                writer.WritePropertyName("scaleType"u8);
                writer.WriteStringValue(ScaleType.Value.ToString());
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
            }
            writer.WriteEndObject();
        }

        internal static CognitiveServicesAccountDeploymentScaleSettings DeserializeCognitiveServicesAccountDeploymentScaleSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CognitiveServicesAccountDeploymentScaleType> scaleType = default;
            Optional<int> capacity = default;
            Optional<int> activeCapacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = new CognitiveServicesAccountDeploymentScaleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("activeCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeCapacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new CognitiveServicesAccountDeploymentScaleSettings(Optional.ToNullable(scaleType), Optional.ToNullable(capacity), Optional.ToNullable(activeCapacity));
        }
    }
}
