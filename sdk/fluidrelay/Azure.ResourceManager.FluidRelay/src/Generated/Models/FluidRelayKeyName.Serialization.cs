// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.FluidRelay.Models
{
    internal static partial class FluidRelayKeyNameExtensions
    {
        public static string ToSerialString(this FluidRelayKeyName value) => value switch
        {
            FluidRelayKeyName.Key1 => "key1",
            FluidRelayKeyName.Key2 => "key2",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FluidRelayKeyName value.")
        };

        public static FluidRelayKeyName ToFluidRelayKeyName(this string value)
        {
            if (string.Equals(value, "key1", StringComparison.InvariantCultureIgnoreCase)) return FluidRelayKeyName.Key1;
            if (string.Equals(value, "key2", StringComparison.InvariantCultureIgnoreCase)) return FluidRelayKeyName.Key2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FluidRelayKeyName value.");
        }
    }
}
