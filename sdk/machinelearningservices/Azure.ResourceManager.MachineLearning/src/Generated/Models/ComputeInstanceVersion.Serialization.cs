// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ComputeInstanceVersion
    {
        internal static ComputeInstanceVersion DeserializeComputeInstanceVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runtime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        runtime = null;
                        continue;
                    }
                    runtime = property.Value.GetString();
                    continue;
                }
            }
            return new ComputeInstanceVersion(runtime.Value);
        }
    }
}
