// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class SubRequest
    {
        internal static SubRequest DeserializeSubRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceName> name = default;
            Optional<string> resourceType = default;
            Optional<string> unit = default;
            Optional<QuotaRequestState> provisioningState = default;
            Optional<string> message = default;
            Optional<string> subRequestId = default;
            Optional<LimitJsonObject> limit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = ResourceName.DeserializeResourceName(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new QuotaRequestState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subRequestId"u8))
                {
                    subRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = LimitJsonObject.DeserializeLimitJsonObject(property.Value);
                    continue;
                }
            }
            return new SubRequest(name.Value, resourceType.Value, unit.Value, Optional.ToNullable(provisioningState), message.Value, subRequestId.Value, limit.Value);
        }
    }
}
