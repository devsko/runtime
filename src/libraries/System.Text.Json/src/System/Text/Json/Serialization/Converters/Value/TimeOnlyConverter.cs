// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Text.Json.Serialization.Converters
{
#if NET6_0_OR_GREATER
    internal sealed class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetTimeOnly();
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }

        internal override TimeOnly ReadWithQuotes(ref Utf8JsonReader reader)
        {
            return reader.GetTimeOnlyNoValidation();
        }

        internal override void WriteWithQuotes(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options, ref WriteStack state)
        {
            writer.WritePropertyName(value);
        }
    }
#endif
}
