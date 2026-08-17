
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CertificateModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public byte[]? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateModel" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="alias"></param>
        /// <param name="serviceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateModel(
            byte[]? content,
            string? alias,
            string? serviceName)
        {
            this.Content = content;
            this.Alias = alias;
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateModel" /> class.
        /// </summary>
        public CertificateModel()
        {
        }

    }
}