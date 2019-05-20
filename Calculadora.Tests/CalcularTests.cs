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
        [Test]
        public void DeveMultiplicarDoisNumeros()
        {
            var sut = new Calcular();
            var resultado = sut.Multiplicar(3, 2);

            Assert.That(resultado, Is.EqualTo(6));
        }
    }
}
