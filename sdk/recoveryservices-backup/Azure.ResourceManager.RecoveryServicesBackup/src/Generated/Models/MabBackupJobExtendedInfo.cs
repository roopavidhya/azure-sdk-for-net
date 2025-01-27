// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information for the MAB workload-specific job. </summary>
    public partial class MabBackupJobExtendedInfo
    {
        /// <summary> Initializes a new instance of MabBackupJobExtendedInfo. </summary>
        public MabBackupJobExtendedInfo()
        {
            TasksList = new ChangeTrackingList<MabBackupJobTaskDetails>();
            PropertyBag = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MabBackupJobExtendedInfo. </summary>
        /// <param name="tasksList"> List of tasks for this job. </param>
        /// <param name="propertyBag"> The job properties. </param>
        /// <param name="dynamicErrorMessage"> Non localized error message specific to this job. </param>
        internal MabBackupJobExtendedInfo(IList<MabBackupJobTaskDetails> tasksList, IDictionary<string, string> propertyBag, string dynamicErrorMessage)
        {
            TasksList = tasksList;
            PropertyBag = propertyBag;
            DynamicErrorMessage = dynamicErrorMessage;
        }

        /// <summary> List of tasks for this job. </summary>
        public IList<MabBackupJobTaskDetails> TasksList { get; }
        /// <summary> The job properties. </summary>
        public IDictionary<string, string> PropertyBag { get; }
        /// <summary> Non localized error message specific to this job. </summary>
        public string DynamicErrorMessage { get; set; }
    }
}
