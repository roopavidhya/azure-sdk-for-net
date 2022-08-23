// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class BackupStatus
    {
        internal static BackupStatus DeserializeBackupStatus(JsonElement element)
        {
            Optional<bool> healthy = default;
            Optional<RelationshipStatus> relationshipStatus = default;
            Optional<MirrorState> mirrorState = default;
            Optional<string> unhealthyReason = default;
            Optional<string> errorMessage = default;
            Optional<long> lastTransferSize = default;
            Optional<string> lastTransferType = default;
            Optional<long> totalTransferBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    healthy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("relationshipStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    relationshipStatus = new RelationshipStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mirrorState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mirrorState = new MirrorState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unhealthyReason"))
                {
                    unhealthyReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastTransferSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastTransferSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastTransferType"))
                {
                    lastTransferType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalTransferBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalTransferBytes = property.Value.GetInt64();
                    continue;
                }
            }
            return new BackupStatus(Optional.ToNullable(healthy), Optional.ToNullable(relationshipStatus), Optional.ToNullable(mirrorState), unhealthyReason.Value, errorMessage.Value, Optional.ToNullable(lastTransferSize), lastTransferType.Value, Optional.ToNullable(totalTransferBytes));
        }
    }
}
