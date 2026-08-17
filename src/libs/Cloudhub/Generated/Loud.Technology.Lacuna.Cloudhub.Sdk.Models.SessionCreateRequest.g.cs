
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifierType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonConverters.IdentifierTypesJsonConverter))]
        public global::Loud.Technology.Lacuna.Cloudhub.Sdk.IdentifierTypes? IdentifierType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonConverters.TrustServiceSessionTypesJsonConverter))]
        public global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceSessionTypes? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.Required]
        [global::System.ComponentModel.DataAnnotations.MinLength(1)]
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetimeInSeconds")]
        public int? LifetimeInSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customState")]
        public string? CustomState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discover")]
        public bool? Discover { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCreateRequest" /> class.
        /// </summary>
        /// <param name="redirectUri"></param>
        /// <param name="identifierType"></param>
        /// <param name="identifier"></param>
        /// <param name="type"></param>
        /// <param name="lifetimeInSeconds"></param>
        /// <param name="customState"></param>
        /// <param name="discover"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionCreateRequest(
            string redirectUri,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.IdentifierTypes? identifierType,
            string? identifier,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceSessionTypes? type,
            int? lifetimeInSeconds,
            string? customState,
            bool? discover)
        {
            this.IdentifierType = identifierType;
            this.Identifier = identifier;
            this.Type = type;
            this.RedirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
            this.LifetimeInSeconds = lifetimeInSeconds;
            this.CustomState = customState;
            this.Discover = discover;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCreateRequest" /> class.
        /// </summary>
        public SessionCreateRequest()
        {
        }

    }
}