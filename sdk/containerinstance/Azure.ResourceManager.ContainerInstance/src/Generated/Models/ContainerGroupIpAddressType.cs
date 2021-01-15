// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> Specifies if the IP is exposed to the public internet or private VNET. </summary>
    public readonly partial struct ContainerGroupIpAddressType : IEquatable<ContainerGroupIpAddressType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ContainerGroupIpAddressType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerGroupIpAddressType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "Public";
        private const string PrivateValue = "Private";

        /// <summary> Public. </summary>
        public static ContainerGroupIpAddressType Public { get; } = new ContainerGroupIpAddressType(PublicValue);
        /// <summary> Private. </summary>
        public static ContainerGroupIpAddressType Private { get; } = new ContainerGroupIpAddressType(PrivateValue);
        /// <summary> Determines if two <see cref="ContainerGroupIpAddressType"/> values are the same. </summary>
        public static bool operator ==(ContainerGroupIpAddressType left, ContainerGroupIpAddressType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerGroupIpAddressType"/> values are not the same. </summary>
        public static bool operator !=(ContainerGroupIpAddressType left, ContainerGroupIpAddressType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerGroupIpAddressType"/>. </summary>
        public static implicit operator ContainerGroupIpAddressType(string value) => new ContainerGroupIpAddressType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerGroupIpAddressType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerGroupIpAddressType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
