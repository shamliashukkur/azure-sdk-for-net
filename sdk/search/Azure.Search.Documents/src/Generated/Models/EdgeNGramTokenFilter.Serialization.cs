// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class EdgeNGramTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MinGram != null)
            {
                writer.WritePropertyName("minGram");
                writer.WriteNumberValue(MinGram.Value);
            }
            if (MaxGram != null)
            {
                writer.WritePropertyName("maxGram");
                writer.WriteNumberValue(MaxGram.Value);
            }
            if (Side != null)
            {
                writer.WritePropertyName("side");
                writer.WriteStringValue(Side.Value.ToSerialString());
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static EdgeNGramTokenFilter DeserializeEdgeNGramTokenFilter(JsonElement element)
        {
            int? minGram = default;
            int? maxGram = default;
            EdgeNGramTokenFilterSide? side = default;
            string odatatype = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minGram"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minGram = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxGram"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxGram = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("side"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    side = property.Value.GetString().ToEdgeNGramTokenFilterSide();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odatatype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new EdgeNGramTokenFilter(minGram, maxGram, side, odatatype, name);
        }
    }
}