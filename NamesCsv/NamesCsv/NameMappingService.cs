using NamesCsv.Models;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace NamesCsv
{
    public class NameMappingService
    {

        public List<NameMapping> NameMappings = new List<NameMapping>();

        public NameMappingService()
        {
            // Load name mappings from csv using CsvHelper NuGet package
            using (var reader = new StreamReader("./SampleSpreadsheet/names_test.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CSVData>();
                Console.WriteLine(records.ToString());
            }

            // Transform file structure into name mappings list.

            // List of tours should not be hard coded.  I should be able to add TourD,TourD_FromDate and TourD_ToDate without problems
        }

        public string MapName(string originalName, List<string> tours, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}