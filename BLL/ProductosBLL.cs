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
	public class ProductosBLL
	{

		public static bool Guardar(Productos producto)
		{
			using (var conec = new Repository<Productos>())
			{
				try
				{
					return conec.Guardar(producto);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}

		public static bool Eliminar(Productos producto)
		{
			using (var conec = new Repository<Productos>())
			{
				try
				{
					return conec.Eliminar(producto);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}

		public static bool Modificar(Productos producto)
		{
			using (var conec = new Repository<Productos>())
			{
				try
				{
					return conec.Modificar(producto);
				}
				catch (Exception)
				{

					throw;
				}
			}
			return false;
		}


		public static Productos Buscar(Expression<Func<Productos, bool>> criterio)
		{
			using (var conec = new Repository<Productos>())
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

		public static Productos BuscarOtro(int id)
		{
			using (var context = new Repository<Productos>())
			{
				try
				{
					return context.BuscarOtro(id);
				}
				catch (Exception)
				{

					throw;
				}
			}
		}



		public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
		{
			using (var conec = new Repository<Productos>())
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

		public static List<Productos> GetListAll()
		{
			using (var conec = new Repository<Productos>())
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
