// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    internal partial class GlobalRulestackResourceListResult
    {
        internal static GlobalRulestackResourceListResult DeserializeGlobalRulestackResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<GlobalRulestackResourceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<GlobalRulestackResourceData> array = new List<GlobalRulestackResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GlobalRulestackResourceData.DeserializeGlobalRulestackResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GlobalRulestackResourceListResult(value, nextLink.Value);
        }
    }
}
