namespace Microsoft.Azure.PowerShell.Cmdlets.Datadog.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Extensions;

    /// <summary>Datadog organization properties</summary>
    public partial class DatadogOrganizationProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject into a new instance of <see cref="DatadogOrganizationProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DatadogOrganizationProperties(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_linkingAuthCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("linkingAuthCode"), out var __jsonLinkingAuthCode) ? (string)__jsonLinkingAuthCode : (string)LinkingAuthCode;}
            {_linkingClientId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("linkingClientId"), out var __jsonLinkingClientId) ? (string)__jsonLinkingClientId : (string)LinkingClientId;}
            {_redirectUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("redirectUri"), out var __jsonRedirectUri) ? (string)__jsonRedirectUri : (string)RedirectUri;}
            {_apiKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("apiKey"), out var __jsonApiKey) ? (string)__jsonApiKey : (string)ApiKey;}
            {_applicationKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("applicationKey"), out var __jsonApplicationKey) ? (string)__jsonApplicationKey : (string)ApplicationKey;}
            {_enterpriseAppId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString>("enterpriseAppId"), out var __jsonEnterpriseAppId) ? (string)__jsonEnterpriseAppId : (string)EnterpriseAppId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Datadog.Models.Api20210301.IDatadogOrganizationProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Datadog.Models.Api20210301.IDatadogOrganizationProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Datadog.Models.Api20210301.IDatadogOrganizationProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject json ? new DatadogOrganizationProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DatadogOrganizationProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DatadogOrganizationProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            }
            AddIf( null != (((object)this._linkingAuthCode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._linkingAuthCode.ToString()) : null, "linkingAuthCode" ,container.Add );
            AddIf( null != (((object)this._linkingClientId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._linkingClientId.ToString()) : null, "linkingClientId" ,container.Add );
            AddIf( null != (((object)this._redirectUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._redirectUri.ToString()) : null, "redirectUri" ,container.Add );
            AddIf( null != (((object)this._apiKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._apiKey.ToString()) : null, "apiKey" ,container.Add );
            AddIf( null != (((object)this._applicationKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._applicationKey.ToString()) : null, "applicationKey" ,container.Add );
            AddIf( null != (((object)this._enterpriseAppId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Datadog.Runtime.Json.JsonString(this._enterpriseAppId.ToString()) : null, "enterpriseAppId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}