// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace body_complex.Models
{
    /// <summary> The salmon. </summary>
    public partial class Salmon : Fish
    {
        /// <summary> Initializes a new instance of Salmon. </summary>
        public Salmon()
        {
            Fishtype = "salmon";
        }
        public string Location { get; set; }
        public bool? Iswild { get; set; }
    }
}
