// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Data.Batch.Models
{
    /// <summary> The instance view status. </summary>
    public partial class InstanceViewStatus
    {
        /// <summary> Initializes a new instance of InstanceViewStatus. </summary>
        internal InstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of InstanceViewStatus. </summary>
        /// <param name="code"> The status code. </param>
        /// <param name="displayStatus"> The localized label for the status. </param>
        /// <param name="level"> Level code. </param>
        /// <param name="message"> The detailed status message. </param>
        /// <param name="time"> The time of the status. </param>
        internal InstanceViewStatus(string code, string displayStatus, StatusLevelTypes? level, string message, string time)
        {
            Code = code;
            DisplayStatus = displayStatus;
            Level = level;
            Message = message;
            Time = time;
        }

        /// <summary> The status code. </summary>
        public string Code { get; }
        /// <summary> The localized label for the status. </summary>
        public string DisplayStatus { get; }
        /// <summary> Level code. </summary>
        public StatusLevelTypes? Level { get; }
        /// <summary> The detailed status message. </summary>
        public string Message { get; }
        /// <summary> The time of the status. </summary>
        public string Time { get; }
    }
}
