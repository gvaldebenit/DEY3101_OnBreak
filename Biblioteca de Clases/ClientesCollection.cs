using DALC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassBiblioteca
{
    public class ClientesCollection
    {
        //Conexion a BD
        private OnBreakEntities _db = new OnBreakEntities();
        public OnBreakEntities DB { get => _db; set => _db = value; }

        //Metodos Customer
        //Método para leer todo
        public IEnumerable<Object> LeerClientes()
        {
            return (from c in DB.Cliente select c).ToList();
        }

        //Listado trabajable
        public List<Clientes> ListaCliente()
        {
            return (from c in DB.Cliente
                    join t in DB.TipoEmpresa on c.IdTipoEmpresa equals t.IdTipoEmpresa
                    join a in DB.ActividadEmpresa on c.IdActividadEmpresa equals a.IdActividadEmpresa
                    select new Clientes()
                    {
                        Rut = c.RutCliente,
                        NombreContacto = c.NombreContacto,
                        Direccion = c.Direccion,
                        Telefono = c.Telefono,
                        EmailContacto = c.MailContacto,
                        RazonSocial = c.RazonSocial,
                        ActividadEmpresa = new ActividadEmpresas()
                        {
                            Id = c.IdActividadEmpresa, Descripcion = a.Descripcion
                        },
                        TipoEmpresa = new TipoEmpresas() 
                        { 
                            Id = c.IdTipoEmpresa, Descripcion = t.Descripcion
                        },
                    }).ToList();
        }

        //Metodo Buscar Cliente
        public Clientes BuscarCliente(String rut)
        {
            var aux = from c in ListaCliente()
                      where c.Rut == rut
                      select c;
            if (aux.Count() > 0)
            {
                return aux.First();
            } else
            {
                return null;
            }            
        }

        //Buscar Cliente por Actividad de Empresa
        public List<Clientes> BuscarClientePorActividadEmpresa(ActividadEmpresas actividadEmpresa)
        {
            List<Clientes> auxList = (from c in ListaCliente()
                                      where c.ActividadEmpresa.Id == (actividadEmpresa.Id)
                                      select c).ToList();
            return auxList;
        }
        
        //Buscar Cliente por Rut
        public List<Clientes> BuscarClientePorRut(String rut)
        {
            List<Clientes> auxList = (from c in ListaCliente()
                                     where c.Rut.Contains(rut)
                                     select c).ToList();
            return auxList;
            
        }

        //Buscar Cliente por Tipo de Empresa
        public List<Clientes> BuscarClientePorTipoEmpresa(TipoEmpresas tipoEmpresa)
        {
            List<Clientes> auxList = (from c in ListaCliente()
                                     where c.TipoEmpresa.Id == (tipoEmpresa.Id)
                                     select c).ToList();
            return auxList;
            
        }

        //Añadir Cliente
        public bool GuardarCliente(Clientes cliente)
        {
            try
            {
                Cliente temp = new Cliente()
                {
                    RutCliente = cliente.Rut,
                    NombreContacto = cliente.NombreContacto,
                    Direccion = cliente.Direccion,
                    Telefono = cliente.Telefono,
                    MailContacto = cliente.EmailContacto,
                    RazonSocial = cliente.RazonSocial,
                    IdActividadEmpresa = cliente.ActividadEmpresa.Id,
                    IdTipoEmpresa = cliente.TipoEmpresa.Id
                };
                DB.Cliente.Add(temp);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        //Borrar Cliente
        public bool EliminarCliente(string rut)
        {
            try
            {
                Cliente cli = DB.Cliente.Find(rut);
                DB.Cliente.Remove(cli);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        //Modificar Cliente
        public bool ModificarCliente(Clientes cliente) 
        {
            try
            {
                var temp = DB.Cliente.Find(cliente.Rut);
                temp.RazonSocial = cliente.RazonSocial;
                temp.NombreContacto = cliente.NombreContacto;
                temp.Direccion = cliente.Direccion;
                temp.Telefono = cliente.Telefono;
                temp.MailContacto = cliente.EmailContacto;
                temp.IdActividadEmpresa = cliente.ActividadEmpresa.Id;
                temp.IdTipoEmpresa = cliente.TipoEmpresa.Id;
                if(DB.SaveChanges() == 1)
                {
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

        //Listado de ActividadEmpresas
        public List<ActividadEmpresas> ListarActividadEmpresas()
        {
            return (from a in DB.ActividadEmpresa
                    select new ActividadEmpresas()
                    {
                        Id = a.IdActividadEmpresa,
                        Descripcion = a.Descripcion
                    }).ToList();
        }

        //Listado de TipoEmpresa
        public List<TipoEmpresas> ListarTipoEmpresas()
        {
            return (from t in DB.TipoEmpresa
                    select new TipoEmpresas()
                    {
                        Id = t.IdTipoEmpresa,
                        Descripcion = t.Descripcion
                    }).ToList();
        }
    }
}
