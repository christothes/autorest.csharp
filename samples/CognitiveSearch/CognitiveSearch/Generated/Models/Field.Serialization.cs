// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Field : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (Key != null)
            {
                writer.WritePropertyName("key");
                writer.WriteBooleanValue(Key.Value);
            }
            if (Retrievable != null)
            {
                writer.WritePropertyName("retrievable");
                writer.WriteBooleanValue(Retrievable.Value);
            }
            if (Searchable != null)
            {
                writer.WritePropertyName("searchable");
                writer.WriteBooleanValue(Searchable.Value);
            }
            if (Filterable != null)
            {
                writer.WritePropertyName("filterable");
                writer.WriteBooleanValue(Filterable.Value);
            }
            if (Sortable != null)
            {
                writer.WritePropertyName("sortable");
                writer.WriteBooleanValue(Sortable.Value);
            }
            if (Facetable != null)
            {
                writer.WritePropertyName("facetable");
                writer.WriteBooleanValue(Facetable.Value);
            }
            if (Analyzer != null)
            {
                writer.WritePropertyName("analyzer");
                writer.WriteStringValue(Analyzer.Value.ToString());
            }
            if (SearchAnalyzer != null)
            {
                writer.WritePropertyName("searchAnalyzer");
                writer.WriteStringValue(SearchAnalyzer.Value.ToString());
            }
            if (IndexAnalyzer != null)
            {
                writer.WritePropertyName("indexAnalyzer");
                writer.WriteStringValue(IndexAnalyzer.Value.ToString());
            }
            if (SynonymMaps != null)
            {
                writer.WritePropertyName("synonymMaps");
                writer.WriteStartArray();
                foreach (var item in SynonymMaps)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Fields != null)
            {
                writer.WritePropertyName("fields");
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static Field DeserializeField(JsonElement element)
        {
            Field result = new Field();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    result.Type = new DataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Key = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retrievable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Retrievable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("searchable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Searchable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("filterable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Filterable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sortable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Sortable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("facetable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Facetable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("analyzer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Analyzer = new AnalyzerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("searchAnalyzer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchAnalyzer = new AnalyzerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("indexAnalyzer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IndexAnalyzer = new AnalyzerName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("synonymMaps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SynonymMaps = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.SynonymMaps.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Fields = new List<Field>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Fields.Add(DeserializeField(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}