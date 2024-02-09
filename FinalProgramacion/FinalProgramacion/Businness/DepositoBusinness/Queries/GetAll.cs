using FinalProgramacion.Data;
using FinalProgramacion.Resultados.ResultadoDeposito;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FinalProgramacion.Businness.DepositoBusinness.Queries
{
    public class GetAll
    {
        public class GetAlll : IRequest<ResultadoDepositp>
        {

        }
        public class Manejador : IRequestHandler<GetAlll, ResultadoDepositp>
        {
            private readonly ContextDb _context;
            public Manejador(ContextDb context)
            {
                _context = context;
            }

            public async Task<ResultadoDepositp> Handle(GetAlll request, CancellationToken cancellationToken)
            {
                var resultadoDepositp = new ResultadoDepositp();
                
                var depositos = await _context.depositos.Include(x => x.Barrio).Include(x=>x.Barrio.Ciudad).Include(x=>x.Barrio.Ciudad.pais).ToArrayAsync();
                
                

                foreach(var deposito in depositos)
                {
                    var item = new ItemDeposito()
                    {
                        Id = deposito.Id,
                        Name = deposito.Name,
                        Activo = deposito.Activo,
                        metrosCuadrados = deposito.metrosCuadrados,
                        calle = deposito.calle,
                        numero = deposito.numero,
                        Barrio = deposito.Barrio.Name,
                        Ciudad = deposito.Barrio.Ciudad.Nombre,
                        Pais = deposito.Barrio.Ciudad.pais.Nombre
                        
                    };
                    resultadoDepositp.listDepositos.Add(item);
                }
                return resultadoDepositp;
            }
        }
    }
}
