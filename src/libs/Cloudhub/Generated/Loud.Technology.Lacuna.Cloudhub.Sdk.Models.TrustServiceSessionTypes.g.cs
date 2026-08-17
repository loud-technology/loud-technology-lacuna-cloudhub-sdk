
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrustServiceSessionTypes
    {
        /// <summary>
        /// 
        /// </summary>
        AuthenticationSession,
        /// <summary>
        /// 
        /// </summary>
        MultiSignature,
        /// <summary>
        /// 
        /// </summary>
        SignatureSession,
        /// <summary>
        /// 
        /// </summary>
        SingleSignature,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrustServiceSessionTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrustServiceSessionTypes value)
        {
            return value switch
            {
                TrustServiceSessionTypes.AuthenticationSession => "AuthenticationSession",
                TrustServiceSessionTypes.MultiSignature => "MultiSignature",
                TrustServiceSessionTypes.SignatureSession => "SignatureSession",
                TrustServiceSessionTypes.SingleSignature => "SingleSignature",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrustServiceSessionTypes? ToEnum(string value)
        {
            return value switch
            {
                "AuthenticationSession" => TrustServiceSessionTypes.AuthenticationSession,
                "MultiSignature" => TrustServiceSessionTypes.MultiSignature,
                "SignatureSession" => TrustServiceSessionTypes.SignatureSession,
                "SingleSignature" => TrustServiceSessionTypes.SingleSignature,
                _ => null,
            };
        }
    }
}