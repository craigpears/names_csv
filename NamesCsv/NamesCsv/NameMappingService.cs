using NamesCsv.Models;

namespace NamesCsv
{
    public class NameMappingService
    {

        public List<NameMapping> NameMappings = new List<NameMapping>();

        public NameMappingService()
        {
            // TODO: Load name mappings from csv using CsvHelper NuGet package
            // TODO: Transform file structure into name mappings list.
            // List of tours should not be hard coded.  I should be able to add TourD,TourD_FromDate and TourD_ToDate without problems
        }

        public string MapName(string originalName, List<string> tours, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}