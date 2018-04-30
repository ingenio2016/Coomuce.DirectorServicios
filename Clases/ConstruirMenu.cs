using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Coomuce.DirectorServicios.Modelos;

namespace Coomuce.DirectorServicios.Clases
{
    public class ConstruirMenu
    {
        public static List<menu> Contruir(int? a, List<obj> o)
        {
            List<menu> lista = new List<menu>();
            var e = o.Where(x => x.idPadreMenu == a).OrderBy(x => x.ordenMenu).ToList();
            List<menu> hijos;
            foreach (var i in e)
            {
                hijos = Contruir(i.idMenu, o);

                lista.Add(new menu
                {
                    idMenu = i.idMenu,
                    idPadreMenu = i.idPadreMenu,
                    text = i.nomMenu,
                    iconCls = i.iconoMenu,
                    vista = i.idVista,
                    idDomVista = i.idDomVista,
                    orden = i.ordenMenu,
                    leaf = ((hijos.Count > 0) ? false : true),
                    children = hijos
                });
            }

            return lista;
        }
    }
}