using NUnit.Framework;

namespace TDD_String.Tests.StrIgualdade
{
    [TestFixture]
    public class NomeTests
    {
        [Test]
        //Testa junção de nomes
        public void DevoJuntarDuasStrings()
        {
            var sut = new Nome();
            var nomeCompleto = sut.JuntarNomes("Rafael", "Batista");

            Assert.That(nomeCompleto, Is.EqualTo("Rafael Batista"));
        }
        [Test]
        //Testa nomes com Case Sensitive
        public void DevoJuntarDuasStrings_CaseSensitive()
        {
            var sut = new Nome();
            var nomeCompleto = sut.JuntarNomes("rafael", "BATISTA");

            Assert.That(nomeCompleto, Is.EqualTo("Rafael Batista").IgnoreCase);
        }
        [Test]
        //Testa nomes diferentes
        public void DevoJuntarDuasStringsDiferentes()
        {
            var sut = new Nome();
            var nomeCompleto = sut.JuntarNomes("Rafael", "Batista");

            Assert.That(nomeCompleto, Is.Not.EqualTo("Tatiane Roque"));
        }
    }
}
