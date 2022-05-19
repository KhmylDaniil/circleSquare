using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateSquare
{
    [TestClass]
    public class Test
    {
        public Test()
        {
        }


        [TestMethod]
        public static void TestSquare()
        {
            var circle = new Circle(2);
            var s1 = circle.Square();
            Assert.AreEqual(4*Math.PI, s1);

            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRight());
            var s2 = triangle.Square();
            Assert.AreEqual(6, s2);

            var figure = new FigureBuilder().Build(3, 4, 5);
            Assert.IsNotNull(figure);
        }
    }
}
