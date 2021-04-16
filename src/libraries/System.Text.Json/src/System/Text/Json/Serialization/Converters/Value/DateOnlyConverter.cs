// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Text.Json.Serialization.Converters
{
#if NET6_0_OR_GREATER
    internal sealed class DateOnlyConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetDateOnly();
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }

        internal override DateOnly ReadWithQuotes(ref Utf8JsonReader reader)
        {
            return reader.GetDateOnlyNoValidation();
        }

        internal override void WriteWithQuotes(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options, ref WriteStack state)
        {
            writer.WritePropertyName(value);
        }
    }
#endif
}
