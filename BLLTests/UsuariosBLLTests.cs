using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            //Usuarios u = new Usuarios();
            //Assert.IsNotNull(UsuariosBLL.Guardar(u));
            Assert.IsTrue(BLL.UsuariosBLL.Guardar(new Entidades.Usuarios(1, "Sea01", "Seatiel", "bhj12345", DateTime.Now)));
        }

        [TestMethod()]
        public void AuthenticarTest()
        {
            Assert.AreNotEqual(AuthenticarTest());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListAllTest()
        {
            Assert.Fail();
        }
    }
}