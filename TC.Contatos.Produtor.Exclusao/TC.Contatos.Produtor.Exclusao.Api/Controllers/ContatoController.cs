using Microsoft.AspNetCore.Mvc;
using UseCase.Interfaces;

namespace TechChallenge.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IRemoverContatoUseCase _removerContatoUseCase;

        public ContatoController(IRemoverContatoUseCase removerContatoUseCase)
        {
            _removerContatoUseCase = removerContatoUseCase;
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult Remover(Guid id)
        {
            try
            {
                _removerContatoUseCase.Remover(id);
                return Accepted();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
