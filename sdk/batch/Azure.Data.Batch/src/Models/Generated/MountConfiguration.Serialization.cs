// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class MountConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureBlobFileSystemConfiguration))
            {
                writer.WritePropertyName("azureBlobFileSystemConfiguration");
                writer.WriteObjectValue(AzureBlobFileSystemConfiguration);
            }
            if (Optional.IsDefined(NfsMountConfiguration))
            {
                writer.WritePropertyName("nfsMountConfiguration");
                writer.WriteObjectValue(NfsMountConfiguration);
            }
            if (Optional.IsDefined(CifsMountConfiguration))
            {
                writer.WritePropertyName("cifsMountConfiguration");
                writer.WriteObjectValue(CifsMountConfiguration);
            }
            if (Optional.IsDefined(AzureFileShareConfiguration))
            {
                writer.WritePropertyName("azureFileShareConfiguration");
                writer.WriteObjectValue(AzureFileShareConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static MountConfiguration DeserializeMountConfiguration(JsonElement element)
        {
            Optional<AzureBlobFileSystemConfiguration> azureBlobFileSystemConfiguration = default;
            Optional<NFSMountConfiguration> nfsMountConfiguration = default;
            Optional<CifsMountConfiguration> cifsMountConfiguration = default;
            Optional<AzureFileShareConfiguration> azureFileShareConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureBlobFileSystemConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureBlobFileSystemConfiguration = AzureBlobFileSystemConfiguration.DeserializeAzureBlobFileSystemConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("nfsMountConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nfsMountConfiguration = NFSMountConfiguration.DeserializeNFSMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("cifsMountConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cifsMountConfiguration = CifsMountConfiguration.DeserializeCifsMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("azureFileShareConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureFileShareConfiguration = AzureFileShareConfiguration.DeserializeAzureFileShareConfiguration(property.Value);
                    continue;
                }
            }
            return new MountConfiguration(azureBlobFileSystemConfiguration.Value, nfsMountConfiguration.Value, cifsMountConfiguration.Value, azureFileShareConfiguration.Value);
        }
    }
}
