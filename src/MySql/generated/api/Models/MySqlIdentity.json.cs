// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    public partial class MySqlIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json ? new MySqlIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject into a new instance of <see cref="MySqlIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MySqlIdentity(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_serverName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("serverName"), out var __jsonServerName) ? (string)__jsonServerName : (string)ServerName;}
            {_firewallRuleName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("firewallRuleName"), out var __jsonFirewallRuleName) ? (string)__jsonFirewallRuleName : (string)FirewallRuleName;}
            {_virtualNetworkRuleName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("virtualNetworkRuleName"), out var __jsonVirtualNetworkRuleName) ? (string)__jsonVirtualNetworkRuleName : (string)VirtualNetworkRuleName;}
            {_databaseName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("databaseName"), out var __jsonDatabaseName) ? (string)__jsonDatabaseName : (string)DatabaseName;}
            {_configurationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("configurationName"), out var __jsonConfigurationName) ? (string)__jsonConfigurationName : (string)ConfigurationName;}
            {_locationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("locationName"), out var __jsonLocationName) ? (string)__jsonLocationName : (string)LocationName;}
            {_securityAlertPolicyName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("securityAlertPolicyName"), out var __jsonSecurityAlertPolicyName) ? (string)__jsonSecurityAlertPolicyName : (string)SecurityAlertPolicyName;}
            {_backupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("backupName"), out var __jsonBackupName) ? (string)__jsonBackupName : (string)BackupName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MySqlIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MySqlIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._serverName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._serverName.ToString()) : null, "serverName" ,container.Add );
            AddIf( null != (((object)this._firewallRuleName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._firewallRuleName.ToString()) : null, "firewallRuleName" ,container.Add );
            AddIf( null != (((object)this._virtualNetworkRuleName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._virtualNetworkRuleName.ToString()) : null, "virtualNetworkRuleName" ,container.Add );
            AddIf( null != (((object)this._databaseName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._databaseName.ToString()) : null, "databaseName" ,container.Add );
            AddIf( null != (((object)this._configurationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._configurationName.ToString()) : null, "configurationName" ,container.Add );
            AddIf( null != (((object)this._locationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._locationName.ToString()) : null, "locationName" ,container.Add );
            AddIf( null != (((object)this._securityAlertPolicyName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._securityAlertPolicyName.ToString()) : null, "securityAlertPolicyName" ,container.Add );
            AddIf( null != (((object)this._backupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._backupName.ToString()) : null, "backupName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}