// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class JsonInput : IUtf8JsonSerializable, IXmlSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteNumberValue(Id.Value);
            }
            writer.WriteEndObject();
        }
        internal static JsonInput DeserializeJsonInput(JsonElement element)
        {
            JsonInput result = new JsonInput();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Id = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "JsonInput");
            if (Id != null)
            {
                writer.WriteStartElement("id");
                writer.WriteValue(Id.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
        internal static JsonInput DeserializeJsonInput(XElement element)
        {
            JsonInput result = default;
            result = new JsonInput(); int? value = default;
            var id = element.Element("id");
            if (id != null)
            {
                value = (int?)id;
            }
            result.Id = value;
            return result;
        }
    }
}