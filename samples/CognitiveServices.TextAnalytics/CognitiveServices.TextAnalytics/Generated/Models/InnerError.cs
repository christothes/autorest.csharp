// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The InnerError. </summary>
    public partial class InnerError
    {
        /// <summary> Error code. </summary>
        public InnerErrorCodeValue Code { get; set; }
        /// <summary> Error message. </summary>
        public string Message { get; set; }
        /// <summary> Error details. </summary>
        public IDictionary<string, string> Details { get; set; }
        /// <summary> Error target. </summary>
        public string Target { get; set; }
        public InnerError InnerError { get; set; }
    }
}