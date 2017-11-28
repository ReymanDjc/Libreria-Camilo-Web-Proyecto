using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class FacturasBLL
    {
        /*public static Facturas facturasReturned = null;
        public static List<Facturas> facturasReturnedList = null;*/


        public static bool EliminarRelacion(Entidades.Facturas facturaG)

        {
            using (var repositorio = new DAL.Repository<Entidades.Facturas>())
            {
                bool relacionesEliminadas = true;

                List<Entidades.FacturasProductos> listaRelaciones = BLL.FacturasProductosBLL.GetList(R => R.FacturaId == facturaG.FacturaId);

                foreach (var relacion in listaRelaciones)
                {
                    if (!FacturasProductosBLL.Eliminar(relacion))
                    {
                        relacionesEliminadas = false;
                    }
                }

                if (relacionesEliminadas)
                {
                    return repositorio.Eliminar(facturaG);
                }
                return false;

            }

        }



        public static bool Guardar(Entidades.Facturas Facturag, List<Entidades.FacturasProductos> listaRelaciones)
		{
			using (var repositorio = new DAL.Repository<Entidades.Facturas>())
			{
				bool FacuraGuardada;
				bool relacionesGuardadas = false;
				if (Buscar(P => P.FacturaId == Facturag.FacturaId) == null)
				{
					FacuraGuardada = repositorio.Guardar(Facturag);
				}
				else
				{
					FacuraGuardada = repositorio.Modificar(Facturag);
				}
				if (FacuraGuardada)
				{
					relacionesGuardadas = true;
					if (listaRelaciones != null)
					{

						foreach (var relacion in listaRelaciones)
						{
							relacion.FacturaId = Facturag.FacturaId;
							if (!BLL.FacturasProductosBLL.Guardar(relacion))
							{
								relacionesGuardadas = false;

							}
						}
					}

				}
				return relacionesGuardadas;
			}
		}



		public static bool Guardar(Facturas facturas)
        {
            using (var context = new Repository<Facturas>())
            {
                try
                {
                    if (Buscar(p => p.FacturaId == facturas.FacturaId) == null)
                    {
                        return context.Guardar(facturas);
                    }
                    else
                    {
                        return context.Modificar(facturas);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(Facturas factura)
        {
            using (var context = new DAL.Repository<Facturas>())
            {
                try
                {
                    return context.Eliminar(factura);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Modificar(Facturas factura)
        {
            using (var conec = new Repository<Facturas>())
            {
                try
                {
                    return conec.Modificar(factura);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }


		public static Facturas Buscar(Expression<Func<Facturas, bool>> criterioBusqueda)
		{

			using (var repositorio = new DAL.Repository<Facturas>())
			{
				return repositorio.Buscar(criterioBusqueda);
			}


		}
		public static List<Facturas> GetList(Expression<Func<Facturas, bool>> criterio)
        {
            using (var conec = new Repository<Facturas>())
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


        public static List<Facturas> GetListAll()
        {
            using (var conec = new Repository<Facturas>())
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
