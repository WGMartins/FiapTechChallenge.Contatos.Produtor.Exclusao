using Moq;
using TechChallenge.UnitTest.UseCase.Shared;
using TechChallenge.UseCase.ContatoUseCase.Remover;
using UseCase.Interfaces;

namespace TechChallenge.UnitTest.UseCase.ContatoUseCase.Remover
{
    public class RemoverRegionalUseCaseTest
    {
        private readonly Mock<IMessagePublisher> _messagePublisher;
        private readonly IRemoverContatoUseCase _removerContatoUseCase;
        private readonly ContatoBuilder _contatoBuilder;

        public RemoverRegionalUseCaseTest()
        {
            _messagePublisher = new Mock<IMessagePublisher>();
            _removerContatoUseCase = new RemoverContatoUseCase(_messagePublisher.Object);
            _contatoBuilder = new ContatoBuilder();
        }

        [Fact]
        public void RemoverContatoUseCase_Remover_Sucesso()
        {
            // Arrange
            _messagePublisher.Setup(s => s.PublishAsync(It.IsAny<Guid>()));

            // Act
            _removerContatoUseCase.Remover(Guid.NewGuid());

            // Assert            
            _messagePublisher.Verify(x => x.PublishAsync(It.IsAny<Guid>()), Times.Once());            
        }        
    }
}
