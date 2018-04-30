using Coomuce.DirectorServicios.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace Coomuce.DirectorServicios
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioFicha042
    {

        public IList<Ficha_042EL> Ficha042 = new List<Ficha_042EL>();
        public IList<RespuestasFicha_042EL> ResFicha042 = new List<RespuestasFicha_042EL>();
        public RespuestasFicha_042EL ResFicha = new RespuestasFicha_042EL();
        public Ficha_042EL Ficha = new Ficha_042EL();

        //[WebGet()]
        [OperationContract]
        public IList<VerificaFicha_042EL> VerificaFicha042(String Usuario, String Contraseña, String Carnet)
        {
            IList<VerificaFicha_042EL> Resultados = new List<VerificaFicha_042EL>();
            VerificaFicha_042EL Resultado = new VerificaFicha_042EL();
            if (Carnet != "")
            {
                Ficha_042Client Cliente = new Ficha_042Client();
                Cliente.InnerChannel.OperationTimeout = new TimeSpan(0, 20, 0);
                Resultado = Cliente.VerificaFicha042(Usuario, Contraseña, Carnet);
                Resultados = new List<VerificaFicha_042EL>();
                Resultados.Add(Resultado);
                Cliente.Close();
            }
            else
            {
                Resultado.Carnet = "";
                Resultado.AfiliadoActivo = false;
                Resultado.ExisteAfiliado = false;
                Resultado.ExisteFicha = false;
                Resultado.Mensaje = "Por favor Digitar un Carnet";
                Resultados.Add(Resultado);
            }

            return Resultados;
        }

    }
}
