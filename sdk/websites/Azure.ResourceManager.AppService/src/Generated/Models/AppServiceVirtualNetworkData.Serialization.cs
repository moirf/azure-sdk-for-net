// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceVirtualNetworkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VnetResourceId))
            {
                writer.WritePropertyName("vnetResourceId"u8);
                writer.WriteStringValue(VnetResourceId);
            }
            if (Optional.IsDefined(CertBlob))
            {
                writer.WritePropertyName("certBlob"u8);
                writer.WriteStringValue(CertBlob);
            }
            if (Optional.IsDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStringValue(DnsServers);
            }
            if (Optional.IsDefined(IsSwift))
            {
                writer.WritePropertyName("isSwift"u8);
                writer.WriteBooleanValue(IsSwift.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceVirtualNetworkData DeserializeAppServiceVirtualNetworkData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> vnetResourceId = default;
            Optional<BinaryData> certThumbprint = default;
            Optional<string> certBlob = default;
            Optional<IReadOnlyList<AppServiceVirtualNetworkRoute>> routes = default;
            Optional<bool> resyncRequired = default;
            Optional<string> dnsServers = default;
            Optional<bool> isSwift = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vnetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vnetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("certThumbprint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            certThumbprint = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("certBlob"u8))
                        {
                            certBlob = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceVirtualNetworkRoute> array = new List<AppServiceVirtualNetworkRoute>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceVirtualNetworkRoute.DeserializeAppServiceVirtualNetworkRoute(item));
                            }
                            routes = array;
                            continue;
                        }
                        if (property0.NameEquals("resyncRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resyncRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dnsServers"u8))
                        {
                            dnsServers = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isSwift"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSwift = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceVirtualNetworkData(id, name, type, systemData.Value, vnetResourceId.Value, certThumbprint.Value, certBlob.Value, Optional.ToList(routes), Optional.ToNullable(resyncRequired), dnsServers.Value, Optional.ToNullable(isSwift), kind.Value);
        }
    }
}
