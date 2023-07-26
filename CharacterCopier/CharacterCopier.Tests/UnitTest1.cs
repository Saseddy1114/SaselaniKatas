using NSubstitute;
using NSubstitute.Exceptions;

namespace CharacterCopier.Tests
{
    [TestFixture]
    public class CopierTests
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

        [Test]
        public void Copy_ReadsFromSource_WritesToDestination_UntilANewLine_ShouldPass2()
        {
            ISource source = Substitute.For<ISource>();
            IDestination destination = Substitute.For<IDestination>();
            Copier copier = new Copier(source, destination);

            source.ReadChar().Returns('O', 'l', 'd', 'M', 'u', 't', 'u', 'a', 'l', 'C', 'a', 's', 'e', 'S', 't', 'u', 'd', 'y');

            copier.Copy();

            destination.Received().WriteChar(Arg.Any<char>());  
        }

        [Test]
        
        public void Copy_ReadsFromSource_WritesToDestination_UntilANewLine_ShouldPass()
        {
            ISource source = Substitute.For<ISource>();
            IDestination destination = Substitute.For<IDestination>();
            Copier copier = new Copier(source, destination);

            source.ReadChar().Returns('O', 'l', 'd', 'M', 'u', 't', 'u', 'a', 'l', '\n', 'C', 'a', 's', 'e', 'S', 't', 'u', 'd', 'y');

            copier.Copy();

            Assert.Throws<ReceivedCallsException>(() => destination.Received(7).WriteChar(Arg.Any<char>()));

        }

        [Test]
        public void Copy_ReadsFromSource_WritesToDestination_UntilANewLine_ShouldPass1()
        {
            ISource source = Substitute.For<ISource>();
            IDestination destination = Substitute.For<IDestination>();
            Copier copier = new Copier(source, destination);

            char[] characters = new char[] { 'O', 'l', 'd', 'M', 'u', 't', 'u', 'a', 'l', '\n', 'C', 'a', 's', 'e', 'S', 't', 'u', 'd', 'y' };

            source.ReadChars(5).Returns(characters);

            copier.Copy(1);

            destination.Received(1).WriteChars(Arg.Any<char[]>());

        }

    }
}
