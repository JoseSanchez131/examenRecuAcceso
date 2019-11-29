using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ApuestaController : ApiController
    {
     
        //EJERCICIO1:
        //Devolvemos los valores introducimos en ApuestaExamen.

        // GET: api/ApuestaExamen/
        public IEnumerable <ApuestaExamen> Get()
        {
            var repo = new ApuestaRepository();
            // List <Apuesta> a = repo.Retrieve();
            List<ApuestaExamen> a = repo.RetrieveExamen();
            return a;
        }

        // GET: api/Apuesta?cuota=cuota1&cuota=cuota2
        
        public IEnumerable<ApuestaDTO1> GetCuota(double cuota, double cuotamax)
        {
            var repo = new ApuestaRepository();

            List<ApuestaDTO1> apuesta = repo.RetrieveCuota (cuota, cuotamax);

            return apuesta;
        }


        // GET: api/Apuesta?id_mercado=id_mercado
       
        public IEnumerable<ApuestaDTO> GetTipoUnderOver(int id_mercado_fk)
        {
            var repo = new ApuestaRepository();

            List<ApuestaDTO> apuesta = repo.RetrieveDatos(id_mercado_fk);

            return apuesta;
        }



        // POST: api/Apuesta
        public void Post([FromBody]Apuesta apuesta)
        {
            Debug.WriteLine("DENTRO de post apuesta vale " + apuesta);
            var repo = new ApuestaRepository();
            repo.insertarApuesta(apuesta);
        }

        // PUT: api/Apuesta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuesta/5
        public void Delete(int id)
        {
        }
    }
}
