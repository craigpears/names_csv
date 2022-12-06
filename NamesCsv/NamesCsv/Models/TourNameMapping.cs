using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesCsv.Models
{
    public class TourNameMapping
    {
        public string OriginalName { get; set; }
        public string ReplacementName { get; set; }
        public string TourName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
