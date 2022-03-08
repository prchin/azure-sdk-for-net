// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(ArmSkuConverter))]
    public partial class ArmSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier.Value.ToSerialString());
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size");
                writer.WriteStringValue(Size);
            }
            if (Optional.IsDefined(Family))
            {
                writer.WritePropertyName("family");
                writer.WriteStringValue(Family);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity");
                writer.WriteNumberValue(Capacity.Value);
            }
            writer.WriteEndObject();
        }

        internal static ArmSku DeserializeArmSku(JsonElement element)
        {
            string name = default;
            Optional<SkuTier> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<int> capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tier = property.Value.GetString().ToSkuTier();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new ArmSku(name, Optional.ToNullable(tier), size.Value, family.Value, Optional.ToNullable(capacity));
        }

        internal partial class ArmSkuConverter : JsonConverter<ArmSku>
        {
            public override void Write(Utf8JsonWriter writer, ArmSku model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ArmSku Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeArmSku(document.RootElement);
            }
        }
    }
}
