// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsEncryptionKeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUrl"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static AvsEncryptionKeyVaultProperties DeserializeAvsEncryptionKeyVaultProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyName = default;
            Optional<string> keyVersion = default;
            Optional<string> autoDetectedKeyVersion = default;
            Optional<Uri> keyVaultUrl = default;
            Optional<AvsEncryptionKeyStatus> keyState = default;
            Optional<AvsEncryptionVersionType> versionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDetectedKeyVersion"u8))
                {
                    autoDetectedKeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyState = new AvsEncryptionKeyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionType = new AvsEncryptionVersionType(property.Value.GetString());
                    continue;
                }
            }
            return new AvsEncryptionKeyVaultProperties(keyName.Value, keyVersion.Value, autoDetectedKeyVersion.Value, keyVaultUrl.Value, Optional.ToNullable(keyState), Optional.ToNullable(versionType));
        }
    }
}
