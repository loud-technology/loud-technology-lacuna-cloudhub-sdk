
#nullable enable

namespace Loud.Technology.Lacuna.Cloudhub.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum IdentifierTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Cnpj,
        /// <summary>
        /// 
        /// </summary>
        Cpf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentifierTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentifierTypes value)
        {
            return value switch
            {
                IdentifierTypes.Cnpj => "CNPJ",
                IdentifierTypes.Cpf => "CPF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentifierTypes? ToEnum(string value)
        {
            return value switch
            {
                "CNPJ" => IdentifierTypes.Cnpj,
                "CPF" => IdentifierTypes.Cpf,
                _ => null,
            };
        }
    }
}