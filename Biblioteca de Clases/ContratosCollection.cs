﻿using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class ContratosCollection
    {
        //Conexion A BD
        private DataBaseLocalEntities _db = new DataBaseLocalEntities();
        public DataBaseLocalEntities DB { get => _db; set => _db = value; }

        //Metodos Customer
        //Método para leer todo
        public IEnumerable<Object> LeerContratos()
        {
            return (from c in DB.Contrato select c).ToList();
        }

        //Listado trabajable
        public List<Contratos> ListaContrato()
        {
            return (from c in DB.Contrato
                    join ci in DB.Cliente on c.RutCliente equals ci.RutCliente
                    join m in DB.ModalidadServicio on c.IdModalidad equals m.IdModalidad
                    join t in DB.TipoEvento on m.IdTipoEvento equals t.IdTipoEvento
                    join ac in DB.ActividadEmpresa on ci.IdActividadEmpresa equals ac.IdActividadEmpresa
                    join te in DB.TipoEmpresa on ci.IdTipoEmpresa equals te.IdTipoEmpresa
                    select new Contratos()
                    {
                        NumeroContrato = c.Numero,
                        NombreEvento = c.NombreEvento,
                        Direccion = c.Direccion,
                        CantidadAsistentes = c.Asistentes,
                        PersonalAdicional = c.PersonalAdicional,
                        Total = c.ValorTotalContrato,
                        Observaciones = c.Observaciones,
                        Realizado = c.Realizado,
                        CreacionContrato = c.Creacion,
                        TerminoContrato = c.Termino,
                        InicioEvento = c.FechaHoraInicio,
                        TerminoEvento = c.FechaHoraTermino,
                        Cliente = new Clientes()
                        {
                            Rut = ci.RutCliente,
                            NombreContacto = ci.NombreContacto,
                            Direccion = ci.Direccion,
                            Telefono = ci.Telefono,
                            EmailContacto = ci.MailContacto,
                            RazonSocial = ci.RazonSocial,
                            ActividadEmpresa = new ActividadEmpresas()
                            { Id = ac.IdActividadEmpresa, Descripcion = ac.Descripcion },
                            TipoEmpresa = new TipoEmpresas()
                            { Id = te.IdTipoEmpresa, Descripcion = te.Descripcion }
                        },
                        ModalidadServicio = new ModalidadServicios()
                        { 
                            Id = c.IdModalidad,
                            Nombre = m.Nombre,
                            PersonalBase = m.PersonalBase,
                            Valorbase = m.ValorBase,
                            TipoEvento = new TipoEventos()
                            { Id = m.IdTipoEvento, Descripcion = t.Descripcion } 
        
                        }
                    }).ToList();
        }

        //Metodo Buscar Contrato
        public Contratos BuscarContrato(string numeroContrato)
        {
            var aux = from c in ListaContrato()
                      where c.NumeroContrato == numeroContrato 
                      select c;
            if (aux.Count() > 0)
            {
                return aux.First();
            }
            else
            {
                return null;
            }
        }

        //Buscar Contrato por Numero
        public List<Contratos> BuscarContratoPorNumero(string numeroContrato)
        {
            List<Contratos> auxList = (from c in ListaContrato()
                                      where c.NumeroContrato.Contains(numeroContrato)
                                      select c).ToList();
            return auxList;
        }

        //Buscar Contrato por Rut
        public List<Contratos> BuscarContratoPorRut(string rut)
        {
            List<Contratos> auxList = (from c in ListaContrato()
                                       where c.Cliente.Rut.Contains(rut)
                                       select c).ToList();
            return auxList;
        }

        //Buscar Contrato por Tipo Evento 
        public List<Contratos> BuscarContratoPorTipo(TipoEventos tipoEvento)
        {
            List<Contratos> auxList = (from c in ListaContrato()
                                       where c.ModalidadServicio.TipoEvento.Id == (tipoEvento.Id)
                                       select c).ToList();
            return auxList;
        }

        //Añadir Contrato
        public bool GuardarContrato(Contratos contrato)
        {
            try
            {
                Contrato cont = new Contrato()
                {
                    RutCliente = contrato.Cliente.Rut,
                    Numero = contrato.NumeroContrato,
                    NombreEvento = contrato.NombreEvento,
                    Direccion = contrato.Direccion,
                    Asistentes = contrato.CantidadAsistentes,
                    PersonalAdicional = contrato.PersonalAdicional,
                    ValorTotalContrato = contrato.Total,
                    Observaciones = contrato.Observaciones,
                    Realizado = contrato.Realizado,
                    Creacion = contrato.CreacionContrato,
                    Termino = contrato.TerminoContrato,
                    FechaHoraInicio = contrato.InicioEvento,
                    FechaHoraTermino = contrato.TerminoEvento,
                    IdModalidad = contrato.ModalidadServicio.Id,
                    IdTipoEvento = contrato.ModalidadServicio.TipoEvento.Id
                };
                DB.Contrato.Add(cont);
                DB.SaveChanges();
                return true;
        }
            catch (Exception)
            {
                return false;
            }
}

        //Terminar Vigencia
        public bool TerminarContrato(string numero)
        {
            try
            {
                var aux = from c in DB.Contrato
                          where c.Numero == numero
                          select c;
                if (aux.Count() > 0)
                {
                    if (aux.First().Termino == null)
                    {
                        //Para determinar si terminó o no
                        if (aux.First().FechaHoraInicio > DateTime.Now)
                        {
                            aux.First().Realizado = false;
                        }
                        else
                        {
                            aux.First().Realizado = true;
                        }
                        aux.First().Termino = DateTime.Now;
                        aux.First().Observaciones = "NO VIGENTE" + Environment.NewLine + "FECHA TERMINO: " +
                            DateTime.Today + Environment.NewLine + aux.First().Observaciones;
                        DB.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Traer Datos Doble Busqueda 
        public Object BuscarDatosExtra(string nroContrato)
        {
            var clist = from con in DB.Contrato
                        where con.Numero == nroContrato
                        select con;
            Contrato c = clist.First();
            if(c.IdTipoEvento == 10)
            {
                var aux = c.CoffeeBreak;
                CoffeBreaks r = new CoffeBreaks(aux.Numero, aux.Vegetariana);
                return r;
            }
            else if (c.IdTipoEvento == 20)
            {
                var aux = c.Cocktail;
                var aux2 = aux.TipoAmbientacion;
                Cocktails r = new Cocktails()
                {
                    Numero = aux.Numero,
                    Ambientacion = new Ambientacion(aux2.IdTipoAmbientacion, aux2.Descripcion),
                    PoseeAmbientacion = aux.Ambientacion,
                    MusicaAmbiental = aux.MusicaAmbiental,
                    MusicaCliente = aux.MusicaCliente
                };
                return r;                                            
            }
            else if (c.IdTipoEvento == 30)
            {
                var aux = c.Cenas;
                var aux2 = aux.TipoAmbientacion;
                Cena r = new Cena()
                {
                    Numero = aux.Numero,
                    Ambientacion = new Ambientacion(aux2.IdTipoAmbientacion, aux2.Descripcion),
                    MusicaAmbiental = aux.MusicaAmbiental,
                    LocalOnBreak = aux.LocalOnBreak,
                    OtroLocal = aux.OtroLocalOnBreak,
                    ValorArriendo = aux.ValorArriendo
                };
                return r;
            }
            else
            {
                return null;
            }
        }

        //Agregar Datos Extra
        public bool AgregarExtra(object extra)
        {
            try
            {
                if(extra is CoffeBreaks)
                {
                    CoffeBreaks aux = (CoffeBreaks)extra;
                    CoffeeBreak c = new CoffeeBreak()
                    {
                        Numero = aux.Numero,
                        Vegetariana = aux.Vegetariano
                    };
                    DB.CoffeeBreak.Add(c);
                    DB.SaveChanges();
                    return true;
                }
                else if (extra is Cocktails)
                {
                    Cocktails aux = (Cocktails)extra;
                    Cocktail c = new Cocktail()
                    {
                        Numero = aux.Numero,
                        IdTipoAmbientacion = aux.Ambientacion.IdAmbientacion,
                        Ambientacion = aux.PoseeAmbientacion,
                        MusicaAmbiental = aux.MusicaAmbiental,
                        MusicaCliente = aux.MusicaCliente
                    };
                    DB.Cocktail.Add(c);
                    DB.SaveChanges();
                    return true;
                }
                else if (extra is Cena)
                {
                    Cena aux = (Cena)extra;
                    Cenas c = new Cenas()
                    {
                        Numero = aux.Numero,
                        IdTipoAmbientacion = aux.Ambientacion.IdAmbientacion,
                        MusicaAmbiental = aux.MusicaAmbiental,
                        LocalOnBreak = aux.LocalOnBreak,
                        OtroLocalOnBreak = aux.OtroLocal,
                        ValorArriendo = aux.ValorArriendo
                    };
                    DB.Cenas.Add(c);
                    DB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Metodo solo de Testeo
        public bool borrarContrato(string numero)
        {
            try
            {
                Contrato con = DB.Contrato.Find(numero);
                DB.Contrato.Remove(con);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Listar Modalidades
        public List<ModalidadServicios> ListarModalidades()
        {
            return (from m in DB.ModalidadServicio
                    join t in DB.TipoEvento on m.IdTipoEvento equals t.IdTipoEvento
                    select new ModalidadServicios()
                    {
                        Id = m.IdModalidad,
                        Nombre = m.Nombre,
                        Valorbase = m.ValorBase,
                        PersonalBase = m.PersonalBase,
                        TipoEvento = new TipoEventos()
                        { Id = m.IdTipoEvento, Descripcion = m.TipoEvento.Descripcion }
                    }).ToList();
        }
        
        //Listar Tipo Evento
        public List<TipoEventos> ListarTipoEvento()
        {
            return (from t in DB.TipoEvento
                    select new TipoEventos()
                    { Id = t.IdTipoEvento, Descripcion = t.Descripcion}
                    ).ToList();
        }

        //Listar Ambientaciones 
        public List<Ambientacion> ListarTipoAmbientacion()
        {
            return (from t in DB.TipoAmbientacion
                    select new Ambientacion()
                    { IdAmbientacion = t.IdTipoAmbientacion, Descripcion = t.Descripcion }
                    ).ToList();
        }
    }
}
