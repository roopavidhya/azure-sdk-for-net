// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> Integrations for Azure Monitor Workspace. </summary>
    public partial class MonitorWorkspaceIntegration
    {
        /// <summary> Initializes a new instance of MonitorWorkspaceIntegration. </summary>
        public MonitorWorkspaceIntegration()
        {
        }

        /// <summary> Initializes a new instance of MonitorWorkspaceIntegration. </summary>
        /// <param name="monitorWorkspaceResourceId"> The resource Id of the connected Azure Monitor Workspace. </param>
        internal MonitorWorkspaceIntegration(ResourceIdentifier monitorWorkspaceResourceId)
        {
            MonitorWorkspaceResourceId = monitorWorkspaceResourceId;
        }

        /// <summary> The resource Id of the connected Azure Monitor Workspace. </summary>
        public ResourceIdentifier MonitorWorkspaceResourceId { get; set; }
    }
}
