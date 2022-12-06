using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesCsv.Models
{
    public class NameMapping
    {
        public string OriginalName { get; set; }
        public string ReplacementName { get; set; }
        public List<TourNameMapping> TourMappings { get; set; } = new List<TourNameMapping>();
    }
}
