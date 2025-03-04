// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class PointOfInterest
    {
        internal static PointOfInterest DeserializePointOfInterest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> phone = default;
            Optional<string> url = default;
            Optional<IReadOnlyList<PointOfInterestCategorySet>> categorySet = default;
            Optional<IReadOnlyList<string>> categories = default;
            Optional<IReadOnlyList<PointOfInterestClassification>> classifications = default;
            Optional<IReadOnlyList<BrandName>> brands = default;
            Optional<OperatingHours> openingHours = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"u8))
                {
                    phone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("categorySet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PointOfInterestCategorySet> array = new List<PointOfInterestCategorySet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointOfInterestCategorySet.DeserializePointOfInterestCategorySet(item));
                    }
                    categorySet = array;
                    continue;
                }
                if (property.NameEquals("categories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("classifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PointOfInterestClassification> array = new List<PointOfInterestClassification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointOfInterestClassification.DeserializePointOfInterestClassification(item));
                    }
                    classifications = array;
                    continue;
                }
                if (property.NameEquals("brands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BrandName> array = new List<BrandName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BrandName.DeserializeBrandName(item));
                    }
                    brands = array;
                    continue;
                }
                if (property.NameEquals("openingHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    openingHours = OperatingHours.DeserializeOperatingHours(property.Value);
                    continue;
                }
            }
            return new PointOfInterest(name.Value, phone.Value, url.Value, Optional.ToList(categorySet), Optional.ToList(categories), Optional.ToList(classifications), Optional.ToList(brands), openingHours.Value);
        }
    }
}
