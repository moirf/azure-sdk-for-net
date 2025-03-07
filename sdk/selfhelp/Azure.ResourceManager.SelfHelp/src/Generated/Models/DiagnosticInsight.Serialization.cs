// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class DiagnosticInsight
    {
        internal static DiagnosticInsight DeserializeDiagnosticInsight(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> title = default;
            Optional<string> results = default;
            Optional<ImportanceLevel> importanceLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    results = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("importanceLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importanceLevel = new ImportanceLevel(property.Value.GetString());
                    continue;
                }
            }
            return new DiagnosticInsight(id.Value, title.Value, results.Value, Optional.ToNullable(importanceLevel));
        }
    }
}
