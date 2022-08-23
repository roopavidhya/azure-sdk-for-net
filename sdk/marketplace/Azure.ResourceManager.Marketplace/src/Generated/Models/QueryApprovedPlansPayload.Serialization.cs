// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class QueryApprovedPlansPayload : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId");
                writer.WriteStringValue(OfferId);
            }
            if (Optional.IsCollectionDefined(PlanIds))
            {
                writer.WritePropertyName("planIds");
                writer.WriteStartArray();
                foreach (var item in PlanIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SubscriptionIds))
            {
                writer.WritePropertyName("subscriptionIds");
                writer.WriteStartArray();
                foreach (var item in SubscriptionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
