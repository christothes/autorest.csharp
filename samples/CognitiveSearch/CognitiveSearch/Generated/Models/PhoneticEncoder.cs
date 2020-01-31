// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Identifies the type of phonetic encoder to use with a PhoneticTokenFilter. </summary>
    public enum PhoneticEncoder
    {
        /// <summary> metaphone. </summary>
        Metaphone,
        /// <summary> doubleMetaphone. </summary>
        DoubleMetaphone,
        /// <summary> soundex. </summary>
        Soundex,
        /// <summary> refinedSoundex. </summary>
        RefinedSoundex,
        /// <summary> caverphone1. </summary>
        Caverphone1,
        /// <summary> caverphone2. </summary>
        Caverphone2,
        /// <summary> cologne. </summary>
        Cologne,
        /// <summary> nysiis. </summary>
        Nysiis,
        /// <summary> koelnerPhonetik. </summary>
        KoelnerPhonetik,
        /// <summary> haasePhonetik. </summary>
        HaasePhonetik,
        /// <summary> beiderMorse. </summary>
        BeiderMorse
    }
}
