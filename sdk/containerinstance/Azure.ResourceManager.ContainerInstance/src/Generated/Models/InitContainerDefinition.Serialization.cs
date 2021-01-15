// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class InitContainerDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image");
                writer.WriteStringValue(Image);
            }
            if (Optional.IsCollectionDefined(Command))
            {
                writer.WritePropertyName("command");
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VolumeMounts))
            {
                writer.WritePropertyName("volumeMounts");
                writer.WriteStartArray();
                foreach (var item in VolumeMounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static InitContainerDefinition DeserializeInitContainerDefinition(JsonElement element)
        {
            string name = default;
            Optional<string> image = default;
            Optional<IList<string>> command = default;
            Optional<IList<EnvironmentVariable>> environmentVariables = default;
            Optional<InitContainerPropertiesDefinitionInstanceView> instanceView = default;
            Optional<IList<VolumeMount>> volumeMounts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("image"))
                        {
                            image = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("command"))
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
                            command = array;
                            continue;
                        }
                        if (property0.NameEquals("environmentVariables"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EnvironmentVariable> array = new List<EnvironmentVariable>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EnvironmentVariable.DeserializeEnvironmentVariable(item));
                            }
                            environmentVariables = array;
                            continue;
                        }
                        if (property0.NameEquals("instanceView"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            instanceView = InitContainerPropertiesDefinitionInstanceView.DeserializeInitContainerPropertiesDefinitionInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("volumeMounts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VolumeMount> array = new List<VolumeMount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VolumeMount.DeserializeVolumeMount(item));
                            }
                            volumeMounts = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new InitContainerDefinition(name, image.Value, Optional.ToList(command), Optional.ToList(environmentVariables), instanceView.Value, Optional.ToList(volumeMounts));
        }
    }
}
