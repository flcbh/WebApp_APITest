namespace WebApp_257483.Models
{
    public class Monitoring
    {
    }
    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
        public string id { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<object> coordinates { get; set; }
    }

    public class Properties
    {
        public string id { get; set; }
    }

    public class RootMonitoring
    {
        public string type { get; set; }
        public List<Feature> features { get; set; }
    }


}
