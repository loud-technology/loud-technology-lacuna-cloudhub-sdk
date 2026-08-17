
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceAuthParametersModel>? Services { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionModel" /> class.
        /// </summary>
        /// <param name="services"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionModel(
            global::System.Collections.Generic.IList<global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceAuthParametersModel>? services)
        {
            this.Services = services;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionModel" /> class.
        /// </summary>
        public SessionModel()
        {
        }

    }
}