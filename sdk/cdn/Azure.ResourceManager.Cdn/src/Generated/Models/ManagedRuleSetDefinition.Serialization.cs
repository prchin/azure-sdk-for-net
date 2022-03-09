// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ManagedRuleSetDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedRuleSetDefinition DeserializeManagedRuleSetDefinition(JsonElement element)
        {
            Optional<CdnSku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> provisioningState = default;
            Optional<string> ruleSetType = default;
            Optional<string> ruleSetVersion = default;
            Optional<IReadOnlyList<ManagedRuleGroupDefinition>> ruleGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = CdnSku.DeserializeCdnSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSetType"))
                        {
                            ruleSetType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSetVersion"))
                        {
                            ruleSetVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ManagedRuleGroupDefinition> array = new List<ManagedRuleGroupDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedRuleGroupDefinition.DeserializeManagedRuleGroupDefinition(item));
                            }
                            ruleGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedRuleSetDefinition(id, name, type, systemData, sku.Value, provisioningState.Value, ruleSetType.Value, ruleSetVersion.Value, Optional.ToList(ruleGroups));
        }
    }
}
