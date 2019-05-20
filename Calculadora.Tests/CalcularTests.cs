using NUnit.Framework;
namespace Calculadora.Tests
{
    [TestFixture]
    public class CalcularTests
    {
        [Test]
        public void DeveSomarDoisNumeros()
        {
            var sut = new Calcular();
            var resultado = sut.Somar(5, 5);

            Assert.That(resultado, Is.EqualTo(10));
            
        }
    }
}
