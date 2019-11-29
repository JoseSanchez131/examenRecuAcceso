using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using static WebAPI.Models.Mercado;

namespace WebAPI.Controllers
{
    public class MercadoController : ApiController
    {

        // GET: api/Mercado/
        public IEnumerable <MercadoDTO> Get()
        { 
            var repo = new MercadoRepository();
            // List<Mercado> m = repo.Retrieve();
            List<MercadoDTO> m = repo.RetrieveDTO();
            return m;
        }

        // GET: api/Mercado?id_mercado=id_mercado
        public IEnumerable<MercadoDTO> GetTipoUnderOver(int id_mercado)
        {
            var repo = new MercadoRepository();
          
            List<MercadoDTO> mercado = repo.RetrieveTipoUnderOver(id_mercado);

            return mercado;
        }

        // POST: api/Mercado
        public void Post([FromBody]Mercado mercado)
        {
            var repo = new MercadoRepository();
            repo.insertarMercado(mercado);
        }

        // PUT: api/Mercado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercado/5
        public void Delete(int id)
        {
        }
    }
}
