// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The Resource model definition. </summary>
    public partial class Resource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The resource id. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        internal Resource(string id, string name, string type, string location, IDictionary<string, string> tags)
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
        }

        /// <summary> The resource id. </summary>
        public string Id { get; }
        /// <summary> The resource name. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public string Type { get; }
        /// <summary> The resource location. </summary>
        public string Location { get; set; }
        /// <summary> The resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
