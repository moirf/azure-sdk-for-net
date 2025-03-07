// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> The quota or usages limit types. </summary>
    public readonly partial struct UsagesType : IEquatable<UsagesType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UsagesType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UsagesType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IndividualValue = "Individual";
        private const string CombinedValue = "Combined";

        /// <summary> Individual. </summary>
        public static UsagesType Individual { get; } = new UsagesType(IndividualValue);
        /// <summary> Combined. </summary>
        public static UsagesType Combined { get; } = new UsagesType(CombinedValue);
        /// <summary> Determines if two <see cref="UsagesType"/> values are the same. </summary>
        public static bool operator ==(UsagesType left, UsagesType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UsagesType"/> values are not the same. </summary>
        public static bool operator !=(UsagesType left, UsagesType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UsagesType"/>. </summary>
        public static implicit operator UsagesType(string value) => new UsagesType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UsagesType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UsagesType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
