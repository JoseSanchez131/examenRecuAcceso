using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Apuesta
    {

        public int IdApuesta { get; set; }
        public int IdMercado { get; set; }
        public String EmailFk { get; set; }
        public int TipoApuesta { get; set; }
        public int DineroApostado { get; set; }
        public Apuesta(int IdApuesta, int ap_mercado, String ap_usuario, int ap_tipo, int ap_dinero)
        {
            this.IdApuesta = IdApuesta;
            this.IdMercado = ap_mercado;
            EmailFk = ap_usuario;
            this.TipoApuesta = ap_tipo;
            this.DineroApostado = ap_dinero;
        }

    }

    public class ApuestaDTO
    {
        public ApuestaDTO(string email_fk, double tipo_apuesta, double cuota, int dinero_apostado)
        {

            Email_fk = email_fk;
            Tipo_apuesta = tipo_apuesta;
            Cuota = cuota;
            Dinero_apostado = dinero_apostado;
        }


        public string Email_fk { get; set; }
        public double Tipo_apuesta { get; set; }
        public double Cuota { get; set; }
        public int Dinero_apostado { get; set; }
    }

    public class ApuestaDTO1
    {
        public ApuestaDTO1(string email_fk, int id_apuesta, int id_mercado, int tipo_apuesta, double cuota, int dinero_apostado)
        {
            Email_fk = email_fk;
            this.Id_apuesta = id_apuesta;
            this.Id_mercado = id_mercado;
            Tipo_apuesta = tipo_apuesta;
            Cuota = cuota;
            Dinero_apostado = dinero_apostado;
        }


        public string Email_fk { get; set; }
        public int Id_apuesta { get; set; }
        public int Id_mercado { get; set; }
        public int Tipo_apuesta { get; set; }
        public double Cuota { get; set; }
        public int Dinero_apostado { get; set; }
    }
}


public class ApuestaExamen
{
    public String email_fk { get; set; }
    public int id_mercado_fk { get; set; }

    public double Cuota { get; set; }
    public double dinero_apostado { get; set; }


    public ApuestaExamen(String email_fk, int id_mercado_fk, double Cuota, double dinero_apostado)
    {
        this.email_fk = email_fk;
        this.id_mercado_fk = id_mercado_fk;
        this.Cuota = Cuota;
        this.dinero_apostado = dinero_apostado;

    }

    
    }
