using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesCsv.Models
{
    internal class CSVData
    {
        public string OriginalName { get; set; }
        public string ReplacementName { get; set; }
        public string TourAName { get; set; }
        public string TourBName { get; set; }
        public string TourCName { get; set; }
        public DateTime? FromDateA { get; set; }
        public DateTime? ToDateA { get; set; }
        public DateTime? FromDateB { get; set; }
        public DateTime? ToDateB { get; set; }
        public DateTime? FromDateC { get; set; }
        public DateTime? ToDateC { get; set; }

    }
}
