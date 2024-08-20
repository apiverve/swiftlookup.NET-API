using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class banks
{
    [JsonProperty("bank")]
    public string bank { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("branch")]
    public object branch { get; set; }

    [JsonProperty("swift_code")]
    public string swiftcode { get; set; }

    [JsonProperty("country")]
    public string country { get; set; }

    [JsonProperty("country_code")]
    public string countrycode { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("banks")]
    public banks[] banks { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
