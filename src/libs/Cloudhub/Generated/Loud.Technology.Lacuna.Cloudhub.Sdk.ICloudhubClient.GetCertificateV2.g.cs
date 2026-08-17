#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    public partial interface ICloudhubClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Lacuna.Cloudhub.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Lacuna.Cloudhub.Sdk.CertificateModel> GetCertificateV2Async(
            string? session = default,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Lacuna.Cloudhub.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Lacuna.Cloudhub.Sdk.CertificateModel>> GetCertificateV2AsResponseAsync(
            string? session = default,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}