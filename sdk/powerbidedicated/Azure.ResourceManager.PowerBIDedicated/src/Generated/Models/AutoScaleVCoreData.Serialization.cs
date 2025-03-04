// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated.Models;

namespace Azure.ResourceManager.PowerBIDedicated
{
    public partial class AutoScaleVCoreData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                writer.WriteObjectValue(SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CapacityLimit))
            {
                writer.WritePropertyName("capacityLimit"u8);
                writer.WriteNumberValue(CapacityLimit.Value);
            }
            if (Optional.IsDefined(CapacityObjectId))
            {
                writer.WritePropertyName("capacityObjectId"u8);
                writer.WriteStringValue(CapacityObjectId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AutoScaleVCoreData DeserializeAutoScaleVCoreData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutoScaleVCoreSku sku = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            AzureLocation location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SystemData> systemData = default;
            Optional<int> capacityLimit = default;
            Optional<string> capacityObjectId = default;
            Optional<VCoreProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = AutoScaleVCoreSku.DeserializeAutoScaleVCoreSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
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
                        if (property0.NameEquals("capacityLimit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            capacityLimit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("capacityObjectId"u8))
                        {
                            capacityObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new VCoreProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutoScaleVCoreData(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), systemData.Value, sku, Optional.ToNullable(capacityLimit), capacityObjectId.Value, Optional.ToNullable(provisioningState));
        }
    }
}
