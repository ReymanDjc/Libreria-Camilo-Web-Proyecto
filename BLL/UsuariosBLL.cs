using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuariosBLL
    {
		public static bool Guardar(Usuarios usuario)
		{
			using (var conec = new Repository<Usuarios>())
			{
				try
				{
					return conec.Guardar(usuario);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}

		public static bool Authenticar(Usuarios usuario)
		{
			using (var conec = new Repository<Usuarios>())
			{

			}
		
			return false;
		}

		public static bool Eliminar(Usuarios usuario)
		{
			using (var conec = new Repository<Usuarios>())
			{
				try
				{
					return conec.Eliminar(usuario);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}

		public static bool Modificar(Usuarios usuario)
		{
			using (var conec = new Repository<Usuarios>())
			{
				try
				{
					return conec.Modificar(usuario);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}


		public static Usuarios Buscar(Expression<Func<Usuarios, bool>> criterio)
		{
			using (var conec = new Repository<Usuarios>())
			{
				try
				{
					return conec.Buscar(criterio);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> criterio)
		{
			using (var conec = new Repository<Usuarios>())
			{
				try
				{
					return conec.GetList(criterio);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		public static List<Usuarios> GetListAll()
		{
			using (var conec = new Repository<Usuarios>())
			{
				try
				{
					return conec.GetListAll();
				}
				catch (Exception)
				{

					throw;
				}
			}
		}



	}
}
