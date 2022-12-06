using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    //NameofMethod_TryingToDo_Expection;
    [TestMethod]
    public void isEqualTriangle_SidesEqual_True() //test for equal triangle
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.isEqualTriangle(1,1,1));
      //testing code will go here
    }

    [TestMethod]
    public void isIsoTriangle_IsoTriangle_True()  //test for iso triangle
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.isIsoTriangle(1,2,2));
    }

    [TestMethod]
    public void isScalTriangle_ScalTriangle_True()  //test for scalene triangle
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.isScalTriangle(1,2,3));  //numbers are the same as isNotTriangle
    }

    [TestMethod]
    public void isNotTriangle_Triangle_False()  //test for scalene triangle
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.isNotTriangle(1,2,3));
    }

  

  }
}