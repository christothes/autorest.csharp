// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace ExtensionClientName.Models
{
    /// <summary> The OriginalSchema. </summary>
    public partial class OriginalSchema
    {
        /// <summary> A description about the set of tags. </summary>
        public IDictionary<string, string> RenamedProperty { get; set; }
        /// <summary> A description about the set of tags. </summary>
        public string RenamedPropertyString { get; set; }
    }
}
