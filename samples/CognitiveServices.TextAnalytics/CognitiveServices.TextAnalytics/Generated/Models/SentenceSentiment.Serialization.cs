// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class SentenceSentiment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sentiment");
            writer.WriteStringValue(Sentiment.ToSerialString());
            writer.WritePropertyName("sentenceScores");
            writer.WriteObjectValue(SentenceScores);
            writer.WritePropertyName("offset");
            writer.WriteNumberValue(Offset);
            writer.WritePropertyName("length");
            writer.WriteNumberValue(Length);
            if (Warnings != null)
            {
                writer.WritePropertyName("warnings");
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static SentenceSentiment DeserializeSentenceSentiment(JsonElement element)
        {
            SentenceSentiment result = new SentenceSentiment();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sentiment"))
                {
                    result.Sentiment = property.Value.GetString().ToSentenceSentimentValue();
                    continue;
                }
                if (property.NameEquals("sentenceScores"))
                {
                    result.SentenceScores = SentimentConfidenceScorePerLabel.DeserializeSentimentConfidenceScorePerLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    result.Offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    result.Length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Warnings = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Warnings.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}