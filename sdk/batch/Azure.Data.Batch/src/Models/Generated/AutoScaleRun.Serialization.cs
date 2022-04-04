// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class AutoScaleRun
    {
        internal static AutoScaleRun DeserializeAutoScaleRun(JsonElement element)
        {
            DateTimeOffset timestamp = default;
            Optional<string> results = default;
            Optional<AutoScaleRunError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("results"))
                {
                    results = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = AutoScaleRunError.DeserializeAutoScaleRunError(property.Value);
                    continue;
                }
            }
            return new AutoScaleRun(timestamp, results.Value, error.Value);
        }
    }
}
