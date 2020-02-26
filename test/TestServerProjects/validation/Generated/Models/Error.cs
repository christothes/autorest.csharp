// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace validation.Models
{
    /// <summary> The Error. </summary>
    public partial class Error
    {
        public int? Code { get; set; }
        public string Message { get; set; }
        public string Fields { get; set; }
    }
}