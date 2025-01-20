using Tyuiu.KonstantinovaJN.Sprint7.Project.V9.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcEducationList()
        {
            var educationList = new List<string> { "Комедия", "Ужасы", "Комедия", "Триллер", "Комедия" };
            var res = DataService.CalculatePercentageWithHigherEducation(educationList);
            double expectedPercentage = 60.0;

            Assert.AreEqual(expectedPercentage, res);
        }
    }
}