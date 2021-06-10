namespace Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.PowerShell;

    /// <summary>Response of a list operation.</summary>
    [System.ComponentModel.TypeConverter(typeof(MonitoringTagRulesListResponseTypeConverter))]
    public partial class MonitoringTagRulesListResponse
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.MonitoringTagRulesListResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MonitoringTagRulesListResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.MonitoringTagRulesListResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponse"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MonitoringTagRulesListResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MonitoringTagRulesListResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.MonitoringTagRulesListResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MonitoringTagRulesListResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).Value = (Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRules[]) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).Value, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.MonitoringTagRulesTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).NextLink = (string) content.GetValueForProperty("NextLink",((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).NextLink, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.MonitoringTagRulesListResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MonitoringTagRulesListResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).Value = (Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRules[]) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).Value, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRules>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.MonitoringTagRulesTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).NextLink = (string) content.GetValueForProperty("NextLink",((Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IMonitoringTagRulesListResponseInternal)this).NextLink, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Response of a list operation.
    [System.ComponentModel.TypeConverter(typeof(MonitoringTagRulesListResponseTypeConverter))]
    public partial interface IMonitoringTagRulesListResponse

    {

    }
}