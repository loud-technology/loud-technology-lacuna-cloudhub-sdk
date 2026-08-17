
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignHashRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.Required]
        [global::System.ComponentModel.DataAnnotations.MinLength(1)]
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.ComponentModel.DataAnnotations.Required]
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestAlgorithm")]
        public string? DigestAlgorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digestAlgorithmOid")]
        public string? DigestAlgorithmOid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificateAlias")]
        public string? CertificateAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignHashRequest" /> class.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="hash"></param>
        /// <param name="digestAlgorithm"></param>
        /// <param name="digestAlgorithmOid"></param>
        /// <param name="certificateAlias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignHashRequest(
            string session,
            byte[] hash,
            string? digestAlgorithm,
            string? digestAlgorithmOid,
            string? certificateAlias)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.DigestAlgorithm = digestAlgorithm;
            this.DigestAlgorithmOid = digestAlgorithmOid;
            this.CertificateAlias = certificateAlias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignHashRequest" /> class.
        /// </summary>
        public SignHashRequest()
        {
        }

    }
}