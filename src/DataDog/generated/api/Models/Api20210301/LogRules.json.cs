namespace Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Extensions;

    /// <summary>Set of rules for sending logs for the Monitor resource.</summary>
    public partial class LogRules
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.ILogRules.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.ILogRules.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.ILogRules FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject json ? new LogRules(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject into a new instance of <see cref="LogRules" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LogRules(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sendAadLog = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonBoolean>("sendAadLogs"), out var __jsonSendAadLogs) ? (bool?)__jsonSendAadLogs : SendAadLog;}
            {_sendSubscriptionLog = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonBoolean>("sendSubscriptionLogs"), out var __jsonSendSubscriptionLogs) ? (bool?)__jsonSendSubscriptionLogs : SendSubscriptionLog;}
            {_sendResourceLog = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonBoolean>("sendResourceLogs"), out var __jsonSendResourceLogs) ? (bool?)__jsonSendResourceLogs : SendResourceLog;}
            {_filteringTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonArray>("filteringTags"), out var __jsonFilteringTags) ? If( __jsonFilteringTags as Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IFilteringTag[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IFilteringTag) (Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.FilteringTag.FromJson(__u) )) ))() : null : FilteringTag;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LogRules" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LogRules" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._sendAadLog ? (Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonBoolean((bool)this._sendAadLog) : null, "sendAadLogs" ,container.Add );
            AddIf( null != this._sendSubscriptionLog ? (Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonBoolean((bool)this._sendSubscriptionLog) : null, "sendSubscriptionLogs" ,container.Add );
            AddIf( null != this._sendResourceLog ? (Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonBoolean((bool)this._sendResourceLog) : null, "sendResourceLogs" ,container.Add );
            if (null != this._filteringTag)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.XNodeArray();
                foreach( var __x in this._filteringTag )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("filteringTags",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}