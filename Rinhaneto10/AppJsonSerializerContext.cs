using System.Text.Json.Serialization;

namespace Rinhaneto10;

[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(DateTime))]
[JsonSerializable(typeof(int))] 
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}