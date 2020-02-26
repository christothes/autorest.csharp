// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace xml_service.Models
{
    /// <summary> An Azure Storage blob. </summary>
    public partial class Blob
    {
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public string Snapshot { get; set; }
        /// <summary> Properties of a blob. </summary>
        public BlobProperties Properties { get; set; } = new BlobProperties();
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}