#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    public partial interface ICloudhubClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Lacuna.Cloudhub.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SignHashAsync(

            global::Loud.Technology.Lacuna.Cloudhub.Sdk.SignHashRequest request,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Lacuna.Cloudhub.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SignHashAsStreamAsync(

            global::Loud.Technology.Lacuna.Cloudhub.Sdk.SignHashRequest request,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Lacuna.Cloudhub.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKHttpResponse<byte[]>> SignHashAsResponseAsync(

            global::Loud.Technology.Lacuna.Cloudhub.Sdk.SignHashRequest request,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="hash"></param>
        /// <param name="digestAlgorithm"></param>
        /// <param name="digestAlgorithmOid"></param>
        /// <param name="certificateAlias"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SignHashAsync(
            string session,
            byte[] hash,
            string? digestAlgorithm = default,
            string? digestAlgorithmOid = default,
            string? certificateAlias = default,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}