// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list statistics operation. </summary>
    internal partial class StatisticsListResult
    {
        /// <summary> Initializes a new instance of StatisticsListResult. </summary>
        internal StatisticsListResult()
        {
            Value = new ChangeTrackingList<Statistics>();
        }

        /// <summary> Initializes a new instance of StatisticsListResult. </summary>
        /// <param name="value"> Gets or sets a list of statistics. </param>
        internal StatisticsListResult(IReadOnlyList<Statistics> value)
        {
            Value = value;
        }

        /// <summary> Gets or sets a list of statistics. </summary>
        public IReadOnlyList<Statistics> Value { get; }
    }
}
