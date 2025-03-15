using UseCase.Interfaces;

namespace TechChallenge.UseCase.ContatoUseCase.Remover
{
    public class RemoverContatoUseCase : IRemoverContatoUseCase
    {
        private readonly IMessagePublisher _messagePublisher;

        public RemoverContatoUseCase(IMessagePublisher messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }

        public void Remover(Guid id)
        {
            _messagePublisher.PublishAsync(id);
        }
    }
}
