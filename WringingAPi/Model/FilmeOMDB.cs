﻿using System.Text.Json.Serialization;

namespace WringingAPi.Model;

public class FilmeOMDB
{
    [JsonPropertyName("Title")]
    public string Title { get; set; }

    [JsonPropertyName("Year")]
    public string Year { get; set; }

    [JsonPropertyName("Director")]
    public string Director { get; set; }

    [JsonPropertyName("Plot")]
    public string Plot { get; set; }

    [JsonPropertyName("Poster")]
    public string Poster { get; set; }

    [JsonPropertyName("Metascore")]
    public string Metascore { get; set; }

    [JsonPropertyName("Genre")]
    public string Genre { get; set; }
}