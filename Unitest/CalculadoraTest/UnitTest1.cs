using Geo;

namespace TestProject
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void areacuadradoTest()
        {
            Geometria g = new Geometria();
            int resultat = g.areacuadrado(3);
            Assert.AreEqual(9, resultat);
        }
        [TestMethod()]

        public void areaCirculoTest()
        {
            Geometria c = new Geometria();
            double resultat = c.areaCirculo(2);
            Assert.AreEqual(12.5664, resultat);

        }

        [TestMethod()]
        public void areatrianguloTest()
        {
            Geometria c = new Geometria();
            double resultat = c.areatriangulo(2, 3);
            Assert.AreEqual(3, resultat);
        }

        [TestMethod()]
        public void arearectanguloTest()
        {
            Geometria c = new Geometria();
            double resultat = c.arearectangulo(2, 4);
            Assert.AreEqual(8, resultat);
        }

        [TestMethod()]
        public void areapentagonoTest()
        {
            Geometria c = new Geometria();
            double resultat = c.areapentagono(2, 3);
            Assert.AreEqual(3, resultat);
        }
        
        [TestMethod()]
        public void arearomboTest()
        {
            Geometria c = new Geometria();
            double resultat = c.arearombo(2, 4);
            Assert.AreEqual(4, resultat);
        }

        [TestMethod()]
        public void arearomboideTest()
        {
            Geometria c = new Geometria();
            double resultat = c.arearomboide(2, 3);
            Assert.AreEqual(6, resultat);
        }

        [TestMethod()]
        public void areatrapecioTest()
        {
            Geometria c = new Geometria();
            double resultat = c.areatrapecio(2, 4, 3);
            Assert.AreEqual(9, resultat);
        }
    }
}