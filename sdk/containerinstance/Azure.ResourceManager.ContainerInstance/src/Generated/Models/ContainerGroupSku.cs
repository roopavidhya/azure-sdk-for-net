// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container group SKU. </summary>
    public readonly partial struct ContainerGroupSku : IEquatable<ContainerGroupSku>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ContainerGroupSku"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerGroupSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string DedicatedValue = "Dedicated";

        /// <summary> Standard. </summary>
        public static ContainerGroupSku Standard { get; } = new ContainerGroupSku(StandardValue);
        /// <summary> Dedicated. </summary>
        public static ContainerGroupSku Dedicated { get; } = new ContainerGroupSku(DedicatedValue);
        /// <summary> Determines if two <see cref="ContainerGroupSku"/> values are the same. </summary>
        public static bool operator ==(ContainerGroupSku left, ContainerGroupSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerGroupSku"/> values are not the same. </summary>
        public static bool operator !=(ContainerGroupSku left, ContainerGroupSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerGroupSku"/>. </summary>
        public static implicit operator ContainerGroupSku(string value) => new ContainerGroupSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerGroupSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerGroupSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
