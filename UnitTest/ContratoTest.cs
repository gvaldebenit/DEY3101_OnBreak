using System;
using ClassBiblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ContratoTest
    {
        //Collections
        ClientesCollection coll2 = new ClientesCollection();
        ContratosCollection coll = new ContratosCollection();

        //Añadir Contrato
        [TestMethod]
        public void AgregarContrato()
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
            coll2.GuardarCliente(c);

            Contratos co = new Contratos()
            {
                Cliente = c,
                NumeroContrato = "202007062050",
                NombreEvento = "Cocktail",
                Direccion = "Las Fosas 30",
                ModalidadServicio = new ModalidadServicios("CB001", new TipoEventos(10, "Coffee Break"), "Light Break", 3, 2),
                CantidadAsistentes = 20,
                PersonalAdicional = 3,
                Total = 10,
                InicioEvento = DateTime.Parse("10-12-2020 13:50:00"),
                TerminoEvento = DateTime.Parse("10-12-2020 15:00:00"),
                Observaciones = "NADA"
            };

            bool respuesta = coll.GuardarContrato(co);
            Assert.AreEqual(true, respuesta);
        }

        //BuscarContrato
        [TestMethod]
        public void BuscarContrato()
        {
            String numero = "202007062050";
            var respuesta = coll.BuscarContrato(numero);
            Assert.IsNotNull(respuesta);
        }

        //Terminar Contrato
        [TestMethod]
        public void TerminarContratoVigente()
        {
            String numero = "202007062050";
            bool respuesta = coll.TerminarContrato(numero);
            Assert.AreEqual(true, respuesta);
        }

        //Intentar Terminar Contrato ya Terminado
        [TestMethod]
        public void TerminarContratoTerminado()
        {
            String numero = "202007062050";
            bool respuesta = coll.TerminarContrato(numero);
            Assert.AreEqual(false, respuesta);
        }

        //probar Realizado y No Realizado
        [TestMethod]
        public void ValidezContratoNoRealizado()
        {
            String numero = "202007062050";
            var contrato = coll.BuscarContrato(numero);
            Assert.AreEqual(false, contrato.Realizado);
        }

        //Ver Contrato Realizado
        [TestMethod]
        public void ValidezContratoRealizado()
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

            Contratos co = new Contratos()
            {
                Cliente = c,
                NumeroContrato = "202007062100",
                NombreEvento = "Cocktail",
                Direccion = "Las Fosas 30",
                ModalidadServicio = new ModalidadServicios("CB001", new TipoEventos(10, "Coffee Break"), "Light Break", 3, 2),
                CantidadAsistentes = 20,
                PersonalAdicional = 3,
                Total = 10,
                CreacionContrato = DateTime.Parse("10-06-2020 11:30:00"),
                InicioEvento = DateTime.Parse("11-06-2020 13:50:00"),
                TerminoEvento = DateTime.Parse("12-06-2020 15:00:00"),
                Observaciones = "NADA"
            };

            coll.GuardarContrato(co);

            String numero = "202007062100";
            var contrato = coll.BuscarContrato(numero);
            Assert.AreEqual(true, contrato.Realizado);
        }

        //Eliminar Contratos para posterior tests
        [TestMethod]
        public void WEliminarContrato1()
        {
            String numero = "202007062100";
            bool respuesta = coll.borrarContrato(numero);
            Assert.AreEqual(true, respuesta);
        }
        //Eliminar Contratos para posterior tests
        [TestMethod]
        public void WEliminarContrato2()
        {
            String numero = "202007062050";
            bool respuesta = coll.borrarContrato(numero);
            Assert.AreEqual(true, respuesta);
        }
    }


}

