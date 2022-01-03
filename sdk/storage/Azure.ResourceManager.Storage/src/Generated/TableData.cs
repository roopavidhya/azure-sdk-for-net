// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the Table data model. </summary>
    public partial class TableData : Resource
    {
        /// <summary> Initializes a new instance of TableData. </summary>
        public TableData()
        {
        }

        /// <summary> Initializes a new instance of TableData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tableName"> Table name under the specified account. </param>
        internal TableData(ResourceIdentifier id, string name, ResourceType type, string tableName) : base(id, name, type)
        {
            TableName = tableName;
        }

        /// <summary> Table name under the specified account. </summary>
        public string TableName { get; }
    }
}
