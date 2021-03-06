// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> The BlobServiceItems. </summary>
    internal partial class BlobServiceItems
    {
        /// <summary> Initializes a new instance of BlobServiceItems. </summary>
        internal BlobServiceItems()
        {
            Value = new ChangeTrackingList<BlobServiceProperties>();
        }

        /// <summary> Initializes a new instance of BlobServiceItems. </summary>
        /// <param name="value"> List of blob services returned. </param>
        internal BlobServiceItems(IReadOnlyList<BlobServiceProperties> value)
        {
            Value = value;
        }

        /// <summary> List of blob services returned. </summary>
        public IReadOnlyList<BlobServiceProperties> Value { get; }
    }
}
