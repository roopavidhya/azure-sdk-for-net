// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The download phase. </summary>
    public readonly partial struct DownloadPhase : IEquatable<DownloadPhase>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DownloadPhase"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DownloadPhase(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string InitializingValue = "Initializing";
        private const string DownloadingValue = "Downloading";
        private const string VerifyingValue = "Verifying";

        /// <summary> Unknown. </summary>
        public static DownloadPhase Unknown { get; } = new DownloadPhase(UnknownValue);
        /// <summary> Initializing. </summary>
        public static DownloadPhase Initializing { get; } = new DownloadPhase(InitializingValue);
        /// <summary> Downloading. </summary>
        public static DownloadPhase Downloading { get; } = new DownloadPhase(DownloadingValue);
        /// <summary> Verifying. </summary>
        public static DownloadPhase Verifying { get; } = new DownloadPhase(VerifyingValue);
        /// <summary> Determines if two <see cref="DownloadPhase"/> values are the same. </summary>
        public static bool operator ==(DownloadPhase left, DownloadPhase right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DownloadPhase"/> values are not the same. </summary>
        public static bool operator !=(DownloadPhase left, DownloadPhase right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DownloadPhase"/>. </summary>
        public static implicit operator DownloadPhase(string value) => new DownloadPhase(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DownloadPhase other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DownloadPhase other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
