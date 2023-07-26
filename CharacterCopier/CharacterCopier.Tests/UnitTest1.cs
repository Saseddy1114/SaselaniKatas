using NSubstitute;

namespace CharacterCopier.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Copy_ReadsFromSource_WritesToDestination_UntilANewLine()
        {
            ISource source = Substitute.For<ISource>();
            IDestination destination = Substitute.For<IDestination>();
            Copier copier = new Copier(source, destination);

            source.ReadChar().Returns('O', 'l', 'd', 'M', 'u', 't', 'u', 'a', 'l', '\n', 'C', 'a', 's', 'e', 'S', 't', 'u', 'd', 'y');

            copier.Copy();

            destination.Received(9).WriteChar(Arg.Any<char>());
        }

    }
}