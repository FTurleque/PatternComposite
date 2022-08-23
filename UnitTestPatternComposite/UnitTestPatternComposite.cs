using Ex_Expression.Class;

namespace UnitTestPatternComposite
{
    [TestClass]
    public class UnitTestPatternComposite
    {
        [TestMethod]
        public void TestAddition()
        {
            Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
            int resultat1 = exp1.Evalue();
            Assert.AreEqual(66, resultat1);

            Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            int resultat2 = exp2.Evalue();
            Assert.AreEqual(77, resultat2);
        }
    }
}