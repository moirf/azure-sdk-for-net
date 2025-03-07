// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> LoadBalancerSku - The load balancer sku for the provisioned cluster. Possible values: &apos;unstacked-haproxy&apos;, &apos;stacked-kube-vip&apos;, &apos;stacked-metallb&apos;, &apos;unmanaged&apos;. The default is &apos;unmanaged&apos;. </summary>
    public readonly partial struct LoadBalancerSku : IEquatable<LoadBalancerSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LoadBalancerSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LoadBalancerSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnstackedHaproxyValue = "unstacked-haproxy";
        private const string StackedKubeVipValue = "stacked-kube-vip";
        private const string StackedMetallbValue = "stacked-metallb";
        private const string UnmanagedValue = "unmanaged";

        /// <summary> unstacked-haproxy. </summary>
        public static LoadBalancerSku UnstackedHaproxy { get; } = new LoadBalancerSku(UnstackedHaproxyValue);
        /// <summary> stacked-kube-vip. </summary>
        public static LoadBalancerSku StackedKubeVip { get; } = new LoadBalancerSku(StackedKubeVipValue);
        /// <summary> stacked-metallb. </summary>
        public static LoadBalancerSku StackedMetallb { get; } = new LoadBalancerSku(StackedMetallbValue);
        /// <summary> unmanaged. </summary>
        public static LoadBalancerSku Unmanaged { get; } = new LoadBalancerSku(UnmanagedValue);
        /// <summary> Determines if two <see cref="LoadBalancerSku"/> values are the same. </summary>
        public static bool operator ==(LoadBalancerSku left, LoadBalancerSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LoadBalancerSku"/> values are not the same. </summary>
        public static bool operator !=(LoadBalancerSku left, LoadBalancerSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LoadBalancerSku"/>. </summary>
        public static implicit operator LoadBalancerSku(string value) => new LoadBalancerSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LoadBalancerSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LoadBalancerSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
