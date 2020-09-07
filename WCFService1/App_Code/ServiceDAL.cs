using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

/// <summary>
/// Descripción breve de ServiceDAL
/// </summary>
public class ServiceDAL:IServiceDAL
{
    public ServiceDAL()
    {
        
    }
	public IEnumerable<PersonM> ObtenerLista()
	{
		using (IDbConnection conexion = new SqlConnection(ConexionBD.ObtenerCadenaConexion()))
		{
			conexion.Open();
			var lstPersonas = conexion.Query<PersonM>("dbo.sp_persona_listar", commandType: CommandType.StoredProcedure);
			return lstPersonas;
		}
	}

	public PersonM Crear(PersonM item)
	{
		using (IDbConnection conexion = new SqlConnection(ConexionBD.ObtenerCadenaConexion()))
		{
			conexion.Open();
			var parametros = new DynamicParameters();
			parametros.Add("@p_cedula", item.Cedula);
			parametros.Add("@p_nombre", item.Nombre);
			parametros.Add("@p_telefono", item.Telefono);
			var Persona = conexion.Query("dbo.sp_persona_insertar", param: parametros, commandType: CommandType.StoredProcedure);
			return item;
		}
	}
	public PersonM Modificar(PersonM item)
	{
		using (IDbConnection conexion = new SqlConnection(ConexionBD.ObtenerCadenaConexion()))
		{
			conexion.Open();
			var parametros = new DynamicParameters();
			parametros.Add("@p_cedula", item.Cedula);
			parametros.Add("@p_nombre", item.Nombre);
			parametros.Add("@p_telefono", item.Telefono);
			var Persona = conexion.Query("dbo.sp_persona_modificar", param: parametros, commandType: CommandType.StoredProcedure);
			return item;
		}
	}
	public void Eliminar(PersonM item)
	{
		using (IDbConnection conexion = new SqlConnection(ConexionBD.ObtenerCadenaConexion()))
		{
			conexion.Open();
			var parametros = new DynamicParameters();
			parametros.Add("@p_cedula", item.Cedula);
			var Persona = conexion.Query<PersonM>("dbo.sp_persona_eliminar", param: parametros, commandType: CommandType.StoredProcedure);
			
		}
	}

	public PersonM Detalle(PersonM item)
	{
		return null;
	}
}