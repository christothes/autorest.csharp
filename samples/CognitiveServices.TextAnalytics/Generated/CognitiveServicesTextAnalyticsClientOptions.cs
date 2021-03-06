// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CognitiveServices.TextAnalytics
{
    /// <summary> Client options for CognitiveServicesTextAnalyticsClient. </summary>
    public partial class CognitiveServicesTextAnalyticsClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.Vv3_0_preview_1;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "v3.0-preview.1". </summary>
            Vv3_0_preview_1 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of CognitiveServicesTextAnalyticsClientOptions. </summary>
        public CognitiveServicesTextAnalyticsClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.Vv3_0_preview_1 => "v3.0-preview.1",
                _ => throw new NotSupportedException()
            };
        }
    }
}
