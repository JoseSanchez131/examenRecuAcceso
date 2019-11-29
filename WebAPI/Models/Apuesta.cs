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
        public double Cuota { get; set; }
        public int DineroApostado { get; set; }
        public Apuesta(int IdApuesta, int IdMercado, String EmailFk, int TipoApuesta, double Cuota, int DineroApostado)
        {
            this.IdApuesta = IdApuesta;
            this.IdMercado = IdMercado;
            this.EmailFk = EmailFk;
            this.TipoApuesta = TipoApuesta;
            this.Cuota = Cuota;
            this.DineroApostado = DineroApostado;
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
        public ApuestaDTO1(int id_apuesta, int id_mercado, int tipo_apuesta, double cuota, int dinero_apostado)
        {
            this.Id_apuesta = id_apuesta;
            this.Id_mercado = id_mercado;
            Tipo_apuesta = tipo_apuesta;
            Cuota = cuota;
            Dinero_apostado = dinero_apostado;
        }


        public int Id_apuesta { get; set; }
        public int Id_mercado { get; set; }
        public int Tipo_apuesta { get; set; }
        public double Cuota { get; set; }
        public int Dinero_apostado { get; set; }
    }
}


public class ApuestaExamen
{
    public String EmailFk { get; set; }
    public int IdMercado { get; set; }
    public int DineroApostado { get; set; }
    public double Cuota { get; set; }


    public ApuestaExamen(String EmailFk, int DineroApostado, int IdMercado, double Cuota)
    {
        this.EmailFk = EmailFk;
        this.DineroApostado = DineroApostado;
        this.IdMercado = IdMercado;
        this.Cuota = Cuota;

    }
}
