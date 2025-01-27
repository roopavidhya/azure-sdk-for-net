// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class VmResources
    {
        internal static VmResources DeserializeVmResources(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmResourceId"u8))
                {
                    vmResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new VmResources(vmResourceId.Value);
        }
    }
}
