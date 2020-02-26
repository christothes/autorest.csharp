// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The DocumentKeyPhrases. </summary>
    public partial class DocumentKeyPhrases
    {
        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; set; }
        /// <summary> A list of representative words or phrases. The number of key phrases returned is proportional to the number of words in the input document. </summary>
        public ICollection<string> KeyPhrases { get; set; } = new System.Collections.Generic.List<string>();
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; set; }
    }
}