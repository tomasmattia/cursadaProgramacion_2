using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class ProveedorDeDatos
    {
        public SqlConnection sqlconexion;
        public SqlCommand sqlcomander;

        public ProveedorDeDatos()
        {
            sqlconexion = new SqlConnection(Entidades.Properties.Settings.Default.conexion);
        }

        public List<Persona> ObtenerPersonasBD()
        {
            // crea 4 personas y las agrega
            try
            {
                List<Persona> listaDePersonas = new List<Persona>();
                sqlconexion.Open();
                sqlcomander = new SqlCommand();
                sqlcomander.Connection = sqlconexion;
                sqlcomander.CommandType = System.Data.CommandType.Text;
                sqlcomander.CommandText = "SELECT id,nombre,apellido,edad FROM Personas";
                SqlDataReader reader = sqlcomander.ExecuteReader();
                while (reader.Read())
                {
                    listaDePersonas.Add(new Persona((int)reader[0], (string)reader[1], (string)reader[2], (int)reader[3]));
                }
                reader.Close();
                sqlconexion.Close();
                return listaDePersonas;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<Persona> ObtenerPersonasHC()
        {
            // crea 4 personas y las agrega
            Persona P1 = new Persona(1, "Pepe", "Lopez", 20);
            Persona P2 = new Persona(2, "Jorge", "Lopez", 20);
            Persona P3 = new Persona(3, "Raul", "Lopez", 20);
            Persona P4 = new Persona(4, "Juan", "Lopez", 20);
            List<Persona> listaDePersonas = new List<Persona>();
            listaDePersonas.Add(P1);
            listaDePersonas.Add(P2);
            listaDePersonas.Add(P3);
            listaDePersonas.Add(P4);
            return listaDePersonas;
        }

        public static Persona ObtenerPersonaID(int id)
        {
            foreach(Persona p in ObtenerPersonasHC())
            {
                if (p.id == id)
                {
                    return p;
                }
            }
            return null;
        }

        public Persona ObtenerPersonaIdBD(int id)
        {
            sqlconexion.Open();
            sqlcomander = new SqlCommand();
            sqlcomander.Connection = sqlconexion;
            sqlcomander.CommandType = System.Data.CommandType.Text;
            sqlcomander.CommandText = "SELECT id,nombre,apellido,edad FROM Personas WHERE id="+id;
            SqlDataReader reader = sqlcomander.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                Persona unaP= new Persona((int)reader[0], (string)reader[1], (string)reader[2], (int)reader[3]);
                reader.Close();
                sqlconexion.Close();
                return unaP;
            }
            sqlconexion.Close();
            return null;
        }

        public static bool AgregarPersona(Persona unaP)
        {
            List<Persona> listaPersonas = ObtenerPersonasHC();
            Persona otraP = ObtenerPersonaID(unaP.id);
            if (otraP == null)
            {
                listaPersonas.Add(unaP);
                return true;
            }
            return false;  
        }

        public bool AgregarPersonaDB(Persona unaP)
        {
            sqlconexion.Open();
            sqlcomander = new SqlCommand();
            sqlcomander.Connection = sqlconexion;
            sqlcomander.CommandType = System.Data.CommandType.Text;
            try
            {
                sqlcomander.CommandText = "INSERT INTO Personas (nombre,apellido,edad) values('" + unaP.nombre + "','" + unaP.apellido + "'," + unaP.edad + ")";
                sqlcomander.ExecuteNonQuery();
                sqlconexion.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                sqlconexion.Close();
                return false;
            }
        }

        public static bool ModificarPersona(Persona unaP)
        {
            Persona otraP=ObtenerPersonaID(unaP.id);
            if (otraP != null)
            {
                otraP = unaP;
                return true;
            }
            return false;   
        }

        public bool ModificarPersonaBD(Persona unaP)
        {
            sqlconexion.Open();
            sqlcomander = new SqlCommand();
            sqlcomander.Connection = sqlconexion;
            sqlcomander.CommandType = System.Data.CommandType.Text;
            try
            {
                sqlcomander.CommandText = "UPDATE Personas SET nombre='" + unaP.nombre + "',apellido='" + unaP.apellido + "',edad=" + unaP.edad + " WHERE id="+unaP.id;
                sqlcomander.ExecuteNonQuery();
                sqlconexion.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                sqlconexion.Close();
                return false;
            }
        }

        public static bool EliminarPersona(Persona unaP)
        {
            List<Persona> listaPersonas = ObtenerPersonasHC();
            foreach (Persona p in listaPersonas)
            {
                if (p.id == unaP.id)
                {
                    listaPersonas.Remove(unaP);
                    return true;
                }
            }
            return false;
        }

        public bool EliminarPersonaDB(Persona unaP)
        {
            sqlconexion.Open();
            sqlcomander = new SqlCommand();
            sqlcomander.Connection = sqlconexion;
            sqlcomander.CommandType = System.Data.CommandType.Text;
            try
            {
                sqlcomander.CommandText = "DELETE FROM Personas WHERE id=" + unaP.id;
                sqlcomander.ExecuteNonQuery();
                sqlconexion.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                sqlconexion.Close();
                return false;
            }
        }

        public DataTable ObtenerPersonasBD(bool valor)
        {
            DataTable myTable= new DataTable("Personas");
            sqlconexion.Open();
            sqlcomander = new SqlCommand();
            sqlcomander.Connection = sqlconexion;
            sqlcomander.CommandType = System.Data.CommandType.Text;
            sqlcomander.CommandText = "SELECT id,nombre,apellido,edad FROM Personas";
            SqlDataReader reader = sqlcomander.ExecuteReader();
            myTable.Load(reader);
            reader.Close();
            sqlconexion.Close();
            return myTable;
        }
        
    }
}
