﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class Choice
    {
        internal static Choice DeserializeChoice(JsonElement element)
        {
            Optional<string> text = default;
            Optional<int?> index = default;
            Optional<CompletionsLogProbability> logprobs = default;
            Optional<string> finishReason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        index = null;
                        continue;
                    }
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logprobs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        logprobs = null;
                        continue;
                    }
                    else
                    {
                        logprobs = CompletionsLogProbability.DeserializeCompletionsLogProbability(property.Value);
                        continue;
                    }
                }
                if (property.NameEquals("finish_reason"))
                {
                    finishReason = property.Value.GetString();
                    continue;
                }
            }
            return new Choice(text, Optional.ToNullable(index), logprobs, finishReason);
        }
    }
}
