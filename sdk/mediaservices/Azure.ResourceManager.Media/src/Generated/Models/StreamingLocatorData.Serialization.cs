// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class StreamingLocatorData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AssetName))
            {
                writer.WritePropertyName("assetName"u8);
                writer.WriteStringValue(AssetName);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(StreamingLocatorId))
            {
                writer.WritePropertyName("streamingLocatorId"u8);
                writer.WriteStringValue(StreamingLocatorId.Value);
            }
            if (Optional.IsDefined(StreamingPolicyName))
            {
                writer.WritePropertyName("streamingPolicyName"u8);
                writer.WriteStringValue(StreamingPolicyName);
            }
            if (Optional.IsDefined(DefaultContentKeyPolicyName))
            {
                writer.WritePropertyName("defaultContentKeyPolicyName"u8);
                writer.WriteStringValue(DefaultContentKeyPolicyName);
            }
            if (Optional.IsCollectionDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys"u8);
                writer.WriteStartArray();
                foreach (var item in ContentKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AlternativeMediaId))
            {
                writer.WritePropertyName("alternativeMediaId"u8);
                writer.WriteStringValue(AlternativeMediaId);
            }
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StreamingLocatorData DeserializeStreamingLocatorData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> assetName = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<Guid> streamingLocatorId = default;
            Optional<string> streamingPolicyName = default;
            Optional<string> defaultContentKeyPolicyName = default;
            Optional<IList<StreamingLocatorContentKey>> contentKeys = default;
            Optional<string> alternativeMediaId = default;
            Optional<IList<string>> filters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("assetName"u8))
                        {
                            assetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("streamingLocatorId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            streamingLocatorId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("streamingPolicyName"u8))
                        {
                            streamingPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultContentKeyPolicyName"u8))
                        {
                            defaultContentKeyPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StreamingLocatorContentKey> array = new List<StreamingLocatorContentKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamingLocatorContentKey.DeserializeStreamingLocatorContentKey(item));
                            }
                            contentKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("alternativeMediaId"u8))
                        {
                            alternativeMediaId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("filters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            filters = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StreamingLocatorData(id, name, type, systemData.Value, assetName.Value, Optional.ToNullable(created), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(streamingLocatorId), streamingPolicyName.Value, defaultContentKeyPolicyName.Value, Optional.ToList(contentKeys), alternativeMediaId.Value, Optional.ToList(filters));
        }
    }
}
