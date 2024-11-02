namespace Tyuiu.GridinAE.Sprint3.TaskReview.V10.Test;
using Tyuiu.GridinAE.Sprint3.TaskReview.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetValues()
    {
        Assert.AreEqual(-15.4, new DataService().GetValues(-5, 5, 1)[0]);
    }
}