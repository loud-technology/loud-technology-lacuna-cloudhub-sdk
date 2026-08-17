
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrustServiceInfoModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badgeUrl")]
        public string? BadgeUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustServiceInfoModel" /> class.
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="provider"></param>
        /// <param name="endpoint"></param>
        /// <param name="badgeUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrustServiceInfoModel(
            string? serviceName,
            string? provider,
            string? endpoint,
            string? badgeUrl)
        {
            this.ServiceName = serviceName;
            this.Provider = provider;
            this.Endpoint = endpoint;
            this.BadgeUrl = badgeUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustServiceInfoModel" /> class.
        /// </summary>
        public TrustServiceInfoModel()
        {
        }

    }
}