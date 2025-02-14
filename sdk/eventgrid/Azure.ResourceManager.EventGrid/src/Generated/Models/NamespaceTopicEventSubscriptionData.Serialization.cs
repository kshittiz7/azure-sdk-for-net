// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class NamespaceTopicEventSubscriptionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeliveryConfiguration))
            {
                writer.WritePropertyName("deliveryConfiguration"u8);
                writer.WriteObjectValue(DeliveryConfiguration);
            }
            if (Optional.IsDefined(EventDeliverySchema))
            {
                writer.WritePropertyName("eventDeliverySchema"u8);
                writer.WriteStringValue(EventDeliverySchema.Value.ToString());
            }
            if (Optional.IsDefined(FiltersConfiguration))
            {
                writer.WritePropertyName("filtersConfiguration"u8);
                writer.WriteObjectValue(FiltersConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NamespaceTopicEventSubscriptionData DeserializeNamespaceTopicEventSubscriptionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SubscriptionProvisioningState> provisioningState = default;
            Optional<DeliveryConfiguration> deliveryConfiguration = default;
            Optional<DeliverySchema> eventDeliverySchema = default;
            Optional<FiltersConfiguration> filtersConfiguration = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SubscriptionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deliveryConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryConfiguration = DeliveryConfiguration.DeserializeDeliveryConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventDeliverySchema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventDeliverySchema = new DeliverySchema(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("filtersConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filtersConfiguration = FiltersConfiguration.DeserializeFiltersConfiguration(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NamespaceTopicEventSubscriptionData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), deliveryConfiguration.Value, Optional.ToNullable(eventDeliverySchema), filtersConfiguration.Value);
        }
    }
}
