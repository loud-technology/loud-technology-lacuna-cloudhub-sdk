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
        global::System.Threading.Tasks.Task<global::Loud.Technology.Lacuna.Cloudhub.Sdk.SessionModel> CreateSessionAsync(

            global::Loud.Technology.Lacuna.Cloudhub.Sdk.SessionCreateRequest request,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Lacuna.Cloudhub.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Lacuna.Cloudhub.Sdk.SessionModel>> CreateSessionAsResponseAsync(

            global::Loud.Technology.Lacuna.Cloudhub.Sdk.SessionCreateRequest request,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="identifierType"></param>
        /// <param name="identifier"></param>
        /// <param name="type"></param>
        /// <param name="redirectUri"></param>
        /// <param name="lifetimeInSeconds"></param>
        /// <param name="customState"></param>
        /// <param name="discover"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Lacuna.Cloudhub.Sdk.SessionModel> CreateSessionAsync(
            string redirectUri,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.IdentifierTypes? identifierType = default,
            string? identifier = default,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceSessionTypes? type = default,
            int? lifetimeInSeconds = default,
            string? customState = default,
            bool? discover = default,
            global::Loud.Technology.Lacuna.Cloudhub.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}