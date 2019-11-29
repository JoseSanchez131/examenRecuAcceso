using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Eventos
    {
        public Eventos(int id_evento, string local, string visitant, int goles)
        {
            Id_evento = id_evento;
            Local = local;
            Visitant = visitant;
            Goles = goles;
        }

        public int Id_evento { get; set; }
        public string Local { get; set; }
        public string Visitant { get; set; }
        public int Goles { get; set; }
    }

    public class EventosDTO
    {

        public EventosDTO( string local, string visitant)
        {
            
            Local = local;
            Visitant = visitant;
        }

        public string Local { get; set; }
        public string Visitant { get; set; }
        

    }

    public class EventosDTOExamen
    {
        public EventosDTOExamen(int id_evento, string local, string visitant, double dinero)
        {
            Id_evento = id_evento;
            Local = local;
            Visitant = visitant;
           
        }

        public int Id_evento { get; set; }
        public string Local { get; set; }
        public string Visitant { get; set; }
       
    

}
}