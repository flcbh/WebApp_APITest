using Newtonsoft.Json;

namespace WebApp_257483.Models
{
    public class DownstageScale
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public int datum { get; set; }
        public HighestRecent highestRecent { get; set; }
        public MaxOnRecord maxOnRecord { get; set; }
        public MinOnRecord minOnRecord { get; set; }
        public int scaleMax { get; set; }
        public double typicalRangeHigh { get; set; }
        public double typicalRangeLow { get; set; }
    }

    public class HighestRecent
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public DateTime dateTime { get; set; }
        public double value { get; set; }
    }

    public class Items
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public string RLOIid { get; set; }
        public string catchmentName { get; set; }
        public string dateOpened { get; set; }
        public string downstageScale { get; set; }
        public string eaAreaName { get; set; }
        public string eaRegionName { get; set; }
        public int easting { get; set; }
        public string label { get; set; }
        public double lat { get; set; }
        public double @long { get; set; }
        public List<Measure> measures { get; set; }
        public int northing { get; set; }
        public string notation { get; set; }
        public string riverName { get; set; }
        // public StageScale stageScale { get; set; }
        public string stageScale { get; set; }
        public string stationReference { get; set; }
        public string status { get; set; }
        public string town { get; set; }
        public List<string> type { get; set; }
        public string wiskiID { get; set; }
    }

    public class LatestReading
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public string date { get; set; }
        public DateTime dateTime { get; set; }
        public string measure { get; set; }
        public double value { get; set; }
    }

    public class MaxOnRecord
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public DateTime dateTime { get; set; }
        public double value { get; set; }
    }

    public class Measure
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public string datumType { get; set; }
        public string label { get; set; }
        public LatestReading latestReading { get; set; }
        public string notation { get; set; }
        public string parameter { get; set; }
        public string parameterName { get; set; }
        public int period { get; set; }
        public string qualifier { get; set; }
        public string station { get; set; }
        public string stationReference { get; set; }
        public List<string> type { get; set; }
        public string unit { get; set; }
        public string unitName { get; set; }
        public string valueType { get; set; }
    }

    public class Meta
    {
        public string publisher { get; set; }
        public string licence { get; set; }
        public string documentation { get; set; }
        public string version { get; set; }
        public string comment { get; set; }
        public List<string> hasFormat { get; set; }
    }

    public class MinOnRecord
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public DateTime dateTime { get; set; }
        public double value { get; set; }
    }

    public class RootAssets
    {
        [JsonProperty("@context")]
        public string context { get; set; }
        public Meta meta { get; set; }
        public List<Items> items { get; set; }
    }

    public class StageScale
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public int datum { get; set; }
        public HighestRecent highestRecent { get; set; }
        public MaxOnRecord maxOnRecord { get; set; }
        public MinOnRecord minOnRecord { get; set; }
        public int scaleMax { get; set; }
        public double typicalRangeHigh { get; set; }
        public double typicalRangeLow { get; set; }
    }
}
