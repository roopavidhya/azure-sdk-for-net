// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary>
    /// Abstract placement policy properties
    /// Please note <see cref="PlacementPolicyProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="VmHostPlacementPolicyProperties"/> and <see cref="VmPlacementPolicyProperties"/>.
    /// </summary>
    public partial class PlacementPolicyProperties
    {
        /// <summary> Initializes a new instance of PlacementPolicyProperties. </summary>
        public PlacementPolicyProperties()
        {
        }

        /// <summary> Initializes a new instance of PlacementPolicyProperties. </summary>
        /// <param name="policyType"> placement policy type. </param>
        /// <param name="state"> Whether the placement policy is enabled or disabled. </param>
        /// <param name="displayName"> Display name of the placement policy. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        internal PlacementPolicyProperties(PlacementPolicyType policyType, PlacementPolicyState? state, string displayName, PlacementPolicyProvisioningState? provisioningState)
        {
            PolicyType = policyType;
            State = state;
            DisplayName = displayName;
            ProvisioningState = provisioningState;
        }

        /// <summary> placement policy type. </summary>
        internal PlacementPolicyType PolicyType { get; set; }
        /// <summary> Whether the placement policy is enabled or disabled. </summary>
        public PlacementPolicyState? State { get; set; }
        /// <summary> Display name of the placement policy. </summary>
        public string DisplayName { get; set; }
        /// <summary> The provisioning state. </summary>
        public PlacementPolicyProvisioningState? ProvisioningState { get; }
    }
}
