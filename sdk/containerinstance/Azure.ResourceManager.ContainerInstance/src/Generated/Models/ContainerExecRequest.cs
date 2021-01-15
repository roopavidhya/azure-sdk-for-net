// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container exec request. </summary>
    public partial class ContainerExecRequest
    {
        /// <summary> Initializes a new instance of ContainerExecRequest. </summary>
        public ContainerExecRequest()
        {
        }

        /// <summary> The command to be executed. </summary>
        public string Command { get; set; }
        /// <summary> The size of the terminal. </summary>
        public ContainerExecRequestTerminalSize TerminalSize { get; set; }
    }
}
