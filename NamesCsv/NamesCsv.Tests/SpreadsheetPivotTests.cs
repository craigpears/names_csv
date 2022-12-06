using NUnit.Framework;

namespace NamesCsv.Tests
{
    [TestFixture]
    public class SpreadsheetPivotTests
    {
        [Test]
        public void ShouldDoSimpleGlobalReplacments_IfNoTourSpecificNames()
        {
            var service = new NameMappingService();
            var mappedName = service.MapName("Bob", new List<string> { "TourA" }, DateTime.UtcNow);
            Assert.Equals(mappedName, "Robert");
        }

        [Test]
        public void ShouldPreferTourSpecificNames()
        {
            var service = new NameMappingService();
            var mappedName = service.MapName("Adam Jr.", new List<string> { "TourA" }, DateTime.UtcNow);
            Assert.Equals(mappedName, "Adam A");
        }

        [Test]
        public void ShouldUseGlobalReplacement_IfDateIsBeforeTourFromDate()
        {
            var service = new NameMappingService();
            var mappedName = service.MapName("Samantha", new List<string> { "TourA" }, new DateTime(2022, 11, 01));
            Assert.Equals(mappedName, "Sam");
        }

        [Test]
        public void ShouldUseTourSpecificReplacement_IfDateIsAfterTourFromDate_AndThereIsNoToDate()
        {
            var service = new NameMappingService();
            var mappedName = service.MapName("Samantha", new List<string> { "TourA" }, new DateTime(2022, 12, 05));
            Assert.Equals(mappedName, "Sammy");
        }

        [Test]
        public void ShouldUseTourSpecificReplacement_IfDateIsAfterTourFromDate_AndBeforeToDate()
        {
            var service = new NameMappingService();
            var mappedName = service.MapName("Liz", new List<string> { "TourA" }, new DateTime(2022, 12, 05));
            Assert.Equals(mappedName, "Lizzy");
        }

        [Test]
        public void ShouldUseGlobalReplacement_IfDateIsAfterToDate()
        {
            var service = new NameMappingService();
            var mappedName = service.MapName("Liz", new List<string> { "TourA" }, new DateTime(2022, 12, 10));
            Assert.Equals(mappedName, "Elizabeth");
        }

        [Test]
        [TestCase("Tim", "TourA", "TimA")]
        [TestCase("Tim", "TourB", "TimB")]
        [TestCase("Tim", "TourC", "TimC")]
        public void ShouldSupportMultipleTourNames(string originalName, string tourName, string expectedName)
        {
            var service = new NameMappingService();
            var mappedName = service.MapName(originalName, new List<string> { "TourX", tourName }, new DateTime(2022, 12, 10));
            Assert.Equals(mappedName, expectedName);
        }
    }
}