using System;
using ClassBiblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ClienteTest
    {
        //ClienteCollection
        ClientesCollection collection = new ClientesCollection();

        //Añadir Cliente
        [TestMethod]
        public void AgregarCliente()
        {
            Clientes c = new Clientes()
            {
                Rut = "19383285-7",
                NombreContacto = "Jorge Medina",
                EmailContacto = "jp.Medina.Rozas@biolab.cl",
                Direccion = "Las Fosas 30, Peñalolen",
                RazonSocial = "BioLab Ltda.",
                Telefono = "5622649336",
                ActividadEmpresa = new ActividadEmpresas(4, "Comercio"),
                TipoEmpresa = new TipoEmpresas(30, "Limitada")
            };

            bool respuesta = collection.GuardarCliente(c);
            Assert.AreEqual(true, respuesta);
        }

        //Añadir Cliente erroneo
        [TestMethod]
        public void AgregarClienteErroneo()
        {
            Clientes c = new Clientes()
            {
                Rut = "19383285-734345",
                NombreContacto = "A",
                EmailContacto = "A",
                Direccion = "L",
                RazonSocial = "B",
                Telefono = "5",
                ActividadEmpresa = new ActividadEmpresas(3, "Manufactura"),
                TipoEmpresa = new TipoEmpresas(40, "Sociedad Anonima")
            };

            bool respuesta = collection.GuardarCliente(c);
            Assert.AreEqual(false, respuesta);
        }

        //Modificar Cliente
        [TestMethod]
        public void ModificarCliente()
        {
            Clientes c = new Clientes()
            {
                Rut = "19383285-7",
                NombreContacto = "Jorge Medina Rozas",
                EmailContacto = "jp.Medina.Rozas@biolab.cl",
                Direccion = "Las Fosas 30, Ñuñoa",
                RazonSocial = "BioLab",
                Telefono = "56226493368",
                ActividadEmpresa = new ActividadEmpresas(4, "Comercio"),
                TipoEmpresa = new TipoEmpresas(30, "Limitada")
            };

            bool respuesta = collection.ModificarCliente(c);
            Assert.AreEqual(true, respuesta);
        }

        //Modificar Cliente erroneo
        [TestMethod]
        public void ModificarClienteErroneo()
        {
            Clientes c = new Clientes()
            {
                Rut = "19383285-734345",
                NombreContacto = "RR",
                EmailContacto = "R",
                Direccion = "R",
                RazonSocial = "B",
                Telefono = "5",
                ActividadEmpresa = new ActividadEmpresas(3, "Manufactura"),
                TipoEmpresa = new TipoEmpresas(40, "Sociedad Anonima")
            };

            bool respuesta = collection.ModificarCliente(c);
            Assert.AreEqual(false, respuesta);
        }

        //Buscar Cliente
        [TestMethod]
        public void BuscarCliente()
        {
            String rut = "19383285-7";

            var respuesta = collection.BuscarCliente(rut);
            Assert.IsNotNull(respuesta);
        }

        //Buscar Cliente erroneo
        [TestMethod]
        public void BuscarClienteErroneo()
        {
            string rut = "19383285-734345";

            var respuesta = collection.BuscarCliente(rut);
            Assert.IsNull(respuesta);
        }

        //Eliminar Cliente
        [TestMethod]
        public void NEliminarCliente()
        {
            String rut = "19383285-7";

            bool respuesta = collection.EliminarCliente(rut);
            Assert.AreEqual(true, respuesta);
        }

        //Eliminar Cliente erroneo
        [TestMethod]
        public void NEliminarClienteErroneo()
        {
            string rut = "19383285-734345";

            bool respuesta = collection.EliminarCliente(rut);
            Assert.AreEqual(false, respuesta);
        }
    }
}
