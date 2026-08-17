
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonConverters.IdentifierTypesJsonConverter),

            typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonConverters.IdentifierTypesNullableJsonConverter),

            typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonConverters.TrustServiceSessionTypesJsonConverter),

            typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonConverters.TrustServiceSessionTypesNullableJsonConverter),

            typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.CertificateModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.GetServiceAvailabilityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.IdentifierTypes), TypeInfoPropertyName = "IdentifierTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.ServiceSessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceSessionTypes), TypeInfoPropertyName = "TrustServiceSessionTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.ServiceSessionCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceInfoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.SessionCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.SessionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceAuthParametersModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceAuthParametersModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Lacuna.Cloudhub.Sdk.SignHashRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceInfoModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceAuthParametersModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Lacuna.Cloudhub.Sdk.TrustServiceInfoModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}