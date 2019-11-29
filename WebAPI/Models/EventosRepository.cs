using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class EventosRepository
    {

        private MySqlConnection Connect()
        {

            String connString = "Server=localhost;Port=3306;Database=ejercicio1_accesodatos;Uid=root;password='';SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<Eventos> Retrieve()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from eventos";

            try
            {

                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Eventos e = null;
                List<Eventos> eventos = new List<Eventos>();
                while (res.Read())
                {

                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetInt32(3));

                    e = new Eventos(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetInt32(3));

                    eventos.Add(e);
                }

                con.Close();
                return eventos;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexion");
                return null;
            }
        }

        internal List<EventosDTO> RetrieveDTO()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from eventos";

            try
            {

                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                EventosDTO e = null;
                List<EventosDTO> eventos = new List<EventosDTO>();
                while (res.Read())
                {

                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetInt32(3));

                    e = new EventosDTO(res.GetString(1), res.GetString(2));

                    eventos.Add(e);
                }

                con.Close();
                return eventos;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexion");
                return null;
            }
        }


        internal void insertarEvento(Eventos e)
        {

            CultureInfo culInfo = new System.Globalization.CultureInfo("es-ES");

            culInfo.NumberFormat.NumberDecimalSeparator = ".";

            culInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            culInfo.NumberFormat.PercentDecimalSeparator = ".";
            culInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = culInfo;


            Debug.WriteLine("apuesta vale " + e);

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "insert into evento (id_evento, local, visitant,goles) values ('" + e.Id_evento + "','" + e.Local + "' ,'" + e.Local + "' ,'" + e.Goles + "');";
            Debug.WriteLine("comando " + command.CommandText);



            try
            {
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (MySqlException)
            {

                Debug.WriteLine("Se ha producido un error de conexión");
                con.Close();
            }




        }
    }

}