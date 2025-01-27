// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.EdgeUpdates.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EdgeUpdates
{
    /// <summary>
    /// A class representing the Update data model.
    /// An Edge Aggregation resource for update
    /// </summary>
    public partial class UpdateData : ResourceData
    {
        /// <summary> Initializes a new instance of UpdateData. </summary>
        public UpdateData()
        {
        }

        /// <summary> Initializes a new instance of UpdateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The Status. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        internal UpdateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, UpdateStatus? status, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Status = status;
            ProvisioningState = provisioningState;
        }

        /// <summary> The Status. </summary>
        public UpdateStatus? Status { get; set; }
        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
