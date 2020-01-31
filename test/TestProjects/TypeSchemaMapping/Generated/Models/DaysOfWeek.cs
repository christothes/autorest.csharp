// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace TypeSchemaMapping.Models
{
    /// <summary> Day of week. </summary>
    public readonly partial struct DaysOfWeek : IEquatable<DaysOfWeek>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DaysOfWeek"/> values are the same. </summary>
        public DaysOfWeek(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";
        private const string SundayValue = "Sunday";

        /// <summary> Monday. </summary>
        public static DaysOfWeek Monday { get; } = new DaysOfWeek(MondayValue);
        /// <summary> Tuesday. </summary>
        public static DaysOfWeek Tuesday { get; } = new DaysOfWeek(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static DaysOfWeek Wednesday { get; } = new DaysOfWeek(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static DaysOfWeek Thursday { get; } = new DaysOfWeek(ThursdayValue);
        /// <summary> Friday. </summary>
        public static DaysOfWeek Friday { get; } = new DaysOfWeek(FridayValue);
        /// <summary> Saturday. </summary>
        public static DaysOfWeek Saturday { get; } = new DaysOfWeek(SaturdayValue);
        /// <summary> Sunday. </summary>
        public static DaysOfWeek Sunday { get; } = new DaysOfWeek(SundayValue);
        /// <summary> Determines if two <see cref="DaysOfWeek"/> values are the same. </summary>
        public static bool operator ==(DaysOfWeek left, DaysOfWeek right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DaysOfWeek"/> values are not the same. </summary>
        public static bool operator !=(DaysOfWeek left, DaysOfWeek right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DaysOfWeek"/>. </summary>
        public static implicit operator DaysOfWeek(string value) => new DaysOfWeek(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DaysOfWeek other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DaysOfWeek other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
