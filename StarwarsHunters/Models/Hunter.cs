//using Phase;
//using CoreML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StarwarsHunters.Models
{
    public class Hunter
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<string> Skills { get; set; }
    }

    [JsonSerializable(typeof(List<Hunter>))]
    internal sealed partial class HunterContext : JsonSerializerContext
    {

    }
}
