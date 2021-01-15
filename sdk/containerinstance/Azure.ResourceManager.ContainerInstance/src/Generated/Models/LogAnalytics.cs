// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> Container group log analytics information. </summary>
    public partial class LogAnalytics
    {
        /// <summary> Initializes a new instance of LogAnalytics. </summary>
        /// <param name="workspaceId"> The workspace id for log analytics. </param>
        /// <param name="workspaceKey"> The workspace key for log analytics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> or <paramref name="workspaceKey"/> is null. </exception>
        public LogAnalytics(string workspaceId, string workspaceKey)
        {
            if (workspaceId == null)
            {
                throw new ArgumentNullException(nameof(workspaceId));
            }
            if (workspaceKey == null)
            {
                throw new ArgumentNullException(nameof(workspaceKey));
            }

            WorkspaceId = workspaceId;
            WorkspaceKey = workspaceKey;
            Metadata = new ChangeTrackingDictionary<string, string>();
            WorkspaceResourceId = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of LogAnalytics. </summary>
        /// <param name="workspaceId"> The workspace id for log analytics. </param>
        /// <param name="workspaceKey"> The workspace key for log analytics. </param>
        /// <param name="logType"> The log type to be used. </param>
        /// <param name="metadata"> Metadata for log analytics. </param>
        /// <param name="workspaceResourceId"> The workspace resource id for log analytics. </param>
        internal LogAnalytics(string workspaceId, string workspaceKey, LogAnalyticsLogType? logType, IDictionary<string, string> metadata, IDictionary<string, string> workspaceResourceId)
        {
            WorkspaceId = workspaceId;
            WorkspaceKey = workspaceKey;
            LogType = logType;
            Metadata = metadata;
            WorkspaceResourceId = workspaceResourceId;
        }

        /// <summary> The workspace id for log analytics. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> The workspace key for log analytics. </summary>
        public string WorkspaceKey { get; set; }
        /// <summary> The log type to be used. </summary>
        public LogAnalyticsLogType? LogType { get; set; }
        /// <summary> Metadata for log analytics. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The workspace resource id for log analytics. </summary>
        public IDictionary<string, string> WorkspaceResourceId { get; }
    }
}
