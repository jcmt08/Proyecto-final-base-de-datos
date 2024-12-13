using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class ClassDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable listar_canciones()
        {
            SqlCommand cmd = new SqlCommand("listar_canciones", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable buscar_canciones(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_canciones", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cancion", obje.cancion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable buscar_canciones2(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_canciones2", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Artista", obje.artista);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable buscar_canciones3(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_canciones3", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Genero", obje.genero);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable buscar_canciones5(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_canciones4", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obje.id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable buscar_canciones6(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_canciones6", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ModoJuego", obje.ModoJuego);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable buscar_canciones7(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("buscar_canciones7", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", obje.username);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public String mantenimiento_canciones(ClassEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("mantenimiento_canciones", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obje.id);
            cmd.Parameters.AddWithValue("@Cancion", obje.cancion);
            cmd.Parameters.AddWithValue("@Artista", obje.artista);
            cmd.Parameters.AddWithValue("@Genero", obje.genero);
            cmd.Parameters.AddWithValue("@ModoJuego", obje.ModoJuego);
            cmd.Parameters.AddWithValue("@Username", obje.username);
            cmd.Parameters.AddWithValue("@Duracion", obje.duracion);
            cmd.Parameters.AddWithValue("@Estrellas", obje.estrellas);
            cmd.Parameters.AddWithValue("@CantidadNota", obje.notas);
            cmd.Parameters.AddWithValue("@FechaSubida", obje.FechaSubida);
            cmd.Parameters.AddWithValue("@FechaActualizacion", obje.FechaActu);
            cmd.Parameters.AddWithValue("@BPM", obje.BPM);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }

    }
}
