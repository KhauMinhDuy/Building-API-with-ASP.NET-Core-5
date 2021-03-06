using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAPI.Data.Entities
{
    public class Camp
    {
        public int CampId { get; set; }
        public string Name { get; set; }
        public string Moniker { get; set; }
        public Location Location { get; set; }
        public DateTime EventDate { get; set; }
        public int Length { get; set; }
        public ICollection<Talk> Talks { get; set; }
    }
}
