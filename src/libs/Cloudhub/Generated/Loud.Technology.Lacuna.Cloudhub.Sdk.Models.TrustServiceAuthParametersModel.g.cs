
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrustServiceAuthParametersModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceInfo")]
        public global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceInfoModel? ServiceInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authUrl")]
        public string? AuthUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustServiceAuthParametersModel" /> class.
        /// </summary>
        /// <param name="serviceInfo"></param>
        /// <param name="authUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrustServiceAuthParametersModel(
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceInfoModel? serviceInfo,
            string? authUrl)
        {
            this.ServiceInfo = serviceInfo;
            this.AuthUrl = authUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustServiceAuthParametersModel" /> class.
        /// </summary>
        public TrustServiceAuthParametersModel()
        {
        }

    }
}