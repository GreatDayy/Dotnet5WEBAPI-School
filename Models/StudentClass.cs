using System.Text.Json.Serialization;

namespace dotnet5.Models
{


    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StudentClass
    {
        TE19D,
        TE19C
    }
}