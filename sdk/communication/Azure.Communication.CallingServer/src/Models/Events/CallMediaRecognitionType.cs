﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Communication.CallingServer.Converters;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    [CodeGenModel("RecognitionType", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    [JsonConverter(typeof(EquatableEnumJsonConverter<CallMediaRecognitionType>))]
    public partial struct CallMediaRecognitionType
    {
    }
}
