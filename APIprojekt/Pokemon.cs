using System.Text.Json.Serialization;

public class pokemon
{
    [JsonPropertyName("name")]
    public string name { get; set; }
    public int weight { get; set; }
    public bool is_default { get; set; }
}