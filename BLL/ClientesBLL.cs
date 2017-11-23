using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            using (var conec = new Repository<Clientes>())
            {
                try
                {
                    return conec.Guardar(cliente);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return false;
        }


        public static bool Eliminar(Clientes cliente)
        {
            using (var conec = new Repository<Clientes>())
            {
                try
                {
                    return conec.Eliminar(cliente);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }

        public static bool Modificar(Clientes cliente)
        {
            using (var conec = new Repository<Clientes>())
            {
                try
                {
                    return conec.Modificar(cliente);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }

        public static Clientes Buscar(Expression<Func<Clientes, bool>> criterio)
        {
            using (var conec = new Repository<Clientes>())
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


        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> criterio)
        {
            using (var conec = new Repository<Clientes>())
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

        public static List<Clientes> GetListAll()
        {
            using (var conec = new Repository<Clientes>())
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
