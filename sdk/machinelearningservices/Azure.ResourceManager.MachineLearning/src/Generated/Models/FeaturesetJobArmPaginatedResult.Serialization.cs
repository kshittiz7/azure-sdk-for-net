// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class FeaturesetJobArmPaginatedResult
    {
        internal static FeaturesetJobArmPaginatedResult DeserializeFeaturesetJobArmPaginatedResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningFeatureSetJob>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningFeatureSetJob> array = new List<MachineLearningFeatureSetJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningFeatureSetJob.DeserializeMachineLearningFeatureSetJob(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new FeaturesetJobArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
