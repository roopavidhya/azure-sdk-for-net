// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the QueueService data model. </summary>
    public partial class QueueServiceData : Resource
    {
        /// <summary> Initializes a new instance of QueueServiceData. </summary>
        public QueueServiceData()
        {
        }

        /// <summary> Initializes a new instance of QueueServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="cors"> Specifies CORS rules for the Queue service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Queue service. </param>
        internal QueueServiceData(ResourceIdentifier id, string name, ResourceType type, CorsRules cors) : base(id, name, type)
        {
            Cors = cors;
        }

        /// <summary> Specifies CORS rules for the Queue service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Queue service. </summary>
        public CorsRules Cors { get; set; }
    }
}
