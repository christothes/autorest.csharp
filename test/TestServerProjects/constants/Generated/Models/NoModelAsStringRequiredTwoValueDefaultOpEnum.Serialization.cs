// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace constants.Models
{
    internal static partial class NoModelAsStringRequiredTwoValueDefaultOpEnumExtensions
    {
        public static string ToSerialString(this NoModelAsStringRequiredTwoValueDefaultOpEnum value) => value switch
        {
            NoModelAsStringRequiredTwoValueDefaultOpEnum.Value1 => "value1",
            NoModelAsStringRequiredTwoValueDefaultOpEnum.Value2 => "value2",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NoModelAsStringRequiredTwoValueDefaultOpEnum value.")
        };

        public static NoModelAsStringRequiredTwoValueDefaultOpEnum ToNoModelAsStringRequiredTwoValueDefaultOpEnum(this string value)
        {
            if (string.Equals(value, "value1", StringComparison.InvariantCultureIgnoreCase)) return NoModelAsStringRequiredTwoValueDefaultOpEnum.Value1;
            if (string.Equals(value, "value2", StringComparison.InvariantCultureIgnoreCase)) return NoModelAsStringRequiredTwoValueDefaultOpEnum.Value2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NoModelAsStringRequiredTwoValueDefaultOpEnum value.");
        }
    }
}
