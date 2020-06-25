using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class ContratosCollection
    {
        //Conexion A BD
        private OnBreakEntitiesLocal _db = new OnBreakEntitiesLocal();
        public OnBreakEntitiesLocal DB { get => _db; set => _db = value; }

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
                        Vigente = c.Realizado,
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
                    Realizado = contrato.Vigente,
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
                    aux.First().Realizado = false;
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
    }
}
