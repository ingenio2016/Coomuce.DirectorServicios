using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Coomuce.DirectorServicios.Modelos
{
    public class HfdfrModel
    {
        public int idInfoHfdfr { get; set; }
        public string archivoAudioHfdfr { get; set; }
    }

    public class InfoHfdfrModel
    {
        public int idInfoHfdfr { get; set; }
        public string tipoDiligenciamientoHfdfr { get; set; }
        public string fechaVisitaHfdfr { get; set; }
        public string horaInicioHfdfr { get; set; }
        public string horaFinHfdfr { get; set; }
        public int idFuanAfiliado { get; set; }
        public short idCiudad { get; set; } 
        public string veredaInfoHfdfr { get; set; }
        public string barrioInfoHfdfr { get; set; }
        public string telefonoInfoHfdfr { get; set; }
        public string firmaHfdfr { get; set; }
        public int idUsuario { get; set; }
    }

    [XmlRootAttribute("Historia", Namespace = "http://www.cpandl.com", IsNullable = false)]
    public class HistoriaHfdfr
    {
        public string pregunta1 { get; set; }
        public string pregunta2 { get; set; }
        public string pregunta3 { get; set; }
        public string pregunta4 { get; set; }
        public string pregunta5 { get; set; }
        public string pregunta6 { get; set; }
        public string pregunta7 { get; set; }
        public Pregunta8 pregunta8 { get; set; }
        public string pregunta9 { get; set; }
        public string pregunta10 { get; set; }
        public string pregunta11 { get; set; }
        public string pregunta12 { get; set; }
        public string pregunta13 { get; set; }
        public List<Pregunta14> pregunta14 { get; set; } /// es listado
        public Pregunta15 pregunta15 { get; set; } // tiene varias opciones
        public string pregunta16 { get; set; }
        public string pregunta17 { get; set; }
        public string pregunta18 { get; set; }
        public string pregunta19 { get; set; }
        public Pregunta20 pregunta20 { get; set; } // multiple seleccion
        public string pregunta21 { get; set; }
        public string pregunta22 { get; set; }
        public string pregunta23 { get; set; }
        public Pregunta24 pregunta24 { get; set; } // multiple seleccion
        public string pregunta25 { get; set; }
        public List<Pregunta26> pregunta26 { get; set; } // lista
        public Pregunta27 pregunta27 { get; set; } // multiple seleccion
        public List<Pregunta28> pregunta28 { get; set; } // lista
        public string pregunta29 { get; set; }
        public Pregunta30 pregunta30 { get; set; } // multiple dato
        public List<Pregunta31> pregunta31 { get; set; } // lista
        public List<Pregunta32> pregunta32 { get; set; } // lista
        public List<Pregunta33> pregunta33 { get; set; } // lista
        public Pregunta34 pregunta34 { get; set; } // multiple seleccion
        public string pregunta35 { get; set; }
        public Pregunta36 pregunta36 { get; set; } // multiple seleccion
        public string pregunta37 { get; set; }
        public Pregunta38 pregunta38 { get; set; } // multiple seleccion
        public Pregunta39 pregunta39 { get; set; } // multiple seleccion
        public Pregunta40 pregunta40 { get; set; } // multiple seleccion
        public Pregunta41 pregunta41 { get; set; }
        public Pregunta42 pregunta42 { get; set; } // multiple seleccion
        public string pregunta43 { get; set; }
        public Pregunta44 pregunta44 { get; set; } // multiple seleccion
        public Pregunta45 pregunta45 { get; set; } // multiple seleccion
    }

    public class Pregunta8
    {
        public bool opcionMadre { get; set; }
        public bool opcionPadre { get; set; }
        public bool opcionHijos { get; set; }
        public bool opcionOtros { get; set; }
    }

    public class Pregunta14
    {
        public string nivel { get; set; }
        public bool madre { get; set; }
        public bool padre { get; set; }
    }

    public class Pregunta15
    {
        public string opcionA { get; set; }
        public string opcionB { get; set; }
        public string opcionC { get; set; }
        public string opcionD { get; set; }
        public string opcionE { get; set; }
        public string opcionF { get; set; }
        public string opcionG { get; set; }
    }

    public class Pregunta20
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF { get; set; }
    }

    public class Pregunta24
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF1 { get; set; }
        public bool opcionF2 { get; set; }
        public bool opcionG { get; set; }
        public bool opcionH { get; set; }
        public bool opcionI { get; set; }
        public bool opcionJ { get; set; }
        public bool opcionK { get; set; }
        public bool opcionL { get; set; }
        public bool opcionM { get; set; }
        public bool opcionN { get; set; }
        public bool opcionO { get; set; }
    }

    public class Pregunta26
    {
        public string nombreAnimal { get; set; }
        public bool seleccion { get; set; }
        public byte numero { get; set; }
    }

    public class Pregunta27
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF { get; set; }
    }

    public class Pregunta28
    {
        public string nombreAfiliado { get; set; }
        public string carnet { get; set; }
        public byte edad { get; set; }
        public string discapacidad { get; set; }
    }

    public class Pregunta30
    {
        public string personasF { get; set; }
        public string personasM { get; set; }
        public string personasNA { get; set; }
    }

    public class Pregunta31
    {
        public string carnet { get; set; }
        public string nombreFamiliar { get; set; }
    }

    public class Pregunta32
    {
        public string carnet { get; set; }
        public string nombreFamiliar { get; set; }
    }

    public class Pregunta33
    {
        public string carnet { get; set; }
        public string nombreFamiliar { get; set; }
    }

    public class Pregunta34
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF { get; set; }
        public bool opcionG { get; set; }
        public bool opcionH { get; set; }
    }

    public class Pregunta36
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF { get; set; }
        public bool opcionG { get; set; }
        public bool opcionH { get; set; }
    }

    public class Pregunta38
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF { get; set; }
    }

    public class Pregunta39
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF { get; set; }
    }

    public class Pregunta40
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
        public bool opcionF { get; set; }
    }

    public class Pregunta41 
    {
        public bool opcionNinguno { get; set; }
        public string opcionMama { get; set; }
        public string opcionPapa { get; set; }
        public string opcionOtro { get; set; }
    }

    public class Pregunta42
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
        public bool opcionE { get; set; }
    }

    public class Pregunta44
    {
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
    }

    public class Pregunta45
    {
        public byte edad { get; set; }
        public bool opcionA { get; set; }
        public bool opcionB { get; set; }
        public bool opcionC { get; set; }
        public bool opcionD { get; set; }
    }
}