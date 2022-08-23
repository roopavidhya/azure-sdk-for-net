// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update source control operation. </summary>
    public partial class SourceControlPatch
    {
        /// <summary> Initializes a new instance of SourceControlPatch. </summary>
        public SourceControlPatch()
        {
        }

        /// <summary> The repo branch of the source control. </summary>
        public string Branch { get; set; }
        /// <summary> The folder path of the source control. Path must be relative. </summary>
        public string FolderPath { get; set; }
        /// <summary> The auto sync of the source control. Default is false. </summary>
        public bool? AutoSync { get; set; }
        /// <summary> The auto publish of the source control. Default is true. </summary>
        public bool? PublishRunbook { get; set; }
        /// <summary> The authorization token for the repo of the source control. </summary>
        public SourceControlSecurityTokenProperties SecurityToken { get; set; }
        /// <summary> The user description of the source control. </summary>
        public string Description { get; set; }
    }
}
