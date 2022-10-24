// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace
{
    public partial class CommunicationUserIdentifierAndToken : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("user");
            writer.WriteObjectValue(User);
            writer.WritePropertyName("token");
            writer.WriteObjectValue(Token);
            writer.WriteEndObject();
        }

        internal static global::.CommunicationUserIdentifierAndToken DeserializeCommunicationUserIdentifierAndToken(JsonElement element)
        {
            global::.CommunicationUserIdentifier user = default;
            global::.AccessToken token = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("user"))
                {
                    user = global::.CommunicationUserIdentifier.DeserializeCommunicationUserIdentifier(property.Value);
                    continue;
                }
                if (property.NameEquals("token"))
                {
                    token = global::.AccessToken.DeserializeAccessToken(property.Value);
                    continue;
                }
            }
            return new global::.CommunicationUserIdentifierAndToken(user, token);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static global::.CommunicationUserIdentifierAndToken FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCommunicationUserIdentifierAndToken(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}