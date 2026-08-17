
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetServiceAvailabilityResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discoveryAvailable")]
        public bool? DiscoveryAvailable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificateFound")]
        public bool? CertificateFound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceAvailabilityResponse" /> class.
        /// </summary>
        /// <param name="discoveryAvailable"></param>
        /// <param name="certificateFound"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetServiceAvailabilityResponse(
            bool? discoveryAvailable,
            bool? certificateFound)
        {
            this.DiscoveryAvailable = discoveryAvailable;
            this.CertificateFound = certificateFound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceAvailabilityResponse" /> class.
        /// </summary>
        public GetServiceAvailabilityResponse()
        {
        }

    }
}