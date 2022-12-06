using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void isEqualTriangle_SidesEqual_True() //NameofMethod_TryingToDo_Expection;
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.isEqualTriangle(1,1,1));
      //testing code will go here
    }

    // [TestMethod]
    // public void isEqualTriangle_SidesEqual_
  }
}