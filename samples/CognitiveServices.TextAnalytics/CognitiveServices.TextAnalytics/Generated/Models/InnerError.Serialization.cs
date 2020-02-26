// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class InnerError : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("code");
            writer.WriteStringValue(Code.ToSerialString());
            writer.WritePropertyName("message");
            writer.WriteStringValue(Message);
            if (Details != null)
            {
                writer.WritePropertyName("details");
                writer.WriteStartObject();
                foreach (var item in Details)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Target != null)
            {
                writer.WritePropertyName("target");
                writer.WriteStringValue(Target);
            }
            if (InnerError != null)
            {
                writer.WritePropertyName("innerError");
                writer.WriteObjectValue(InnerError);
            }
            writer.WriteEndObject();
        }
        internal static InnerError DeserializeInnerError(JsonElement element)
        {
            InnerError result = new InnerError();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    result.Code = property.Value.GetString().ToInnerErrorCodeValue();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    result.Message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Details = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        result.Details.Add(property0.Name, property0.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.InnerError = DeserializeInnerError(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}