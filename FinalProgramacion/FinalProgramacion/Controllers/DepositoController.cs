using FinalProgramacion.Resultados.ResultadoDeposito;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static FinalProgramacion.Businness.DepositoBusinness.Queries.GetAll;
using static FinalProgramacion.Businness.DepositoBusinness.Queries.GetArgentina;

namespace FinalProgramacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositoController : ControllerBase
    {
        private readonly IMediator mediator;
        public DepositoController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ResultadoDepositp> GetAll()
        {
            return await mediator.Send(new GetAlll());
        }
        [HttpGet]
        [Route("GetAllArgentina")]
        public async Task<ResultadoDepositp> GetAllArgentina()
        {
            return await mediator.Send(new GetAllArgentina());
        }
    }
}
