

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMGenNHibernate.Exceptions;

using DSMGenNHibernate.EN.DSM;
using DSMGenNHibernate.CAD.DSM;


namespace DSMGenNHibernate.CEN.DSM
{
/*
 *      Definition of the class Lugar_de_interesCEN
 *
 */
public partial class Lugar_de_interesCEN
{
private ILugar_de_interesCAD _ILugar_de_interesCAD;

public Lugar_de_interesCEN()
{
        this._ILugar_de_interesCAD = new Lugar_de_interesCAD ();
}

public Lugar_de_interesCEN(ILugar_de_interesCAD _ILugar_de_interesCAD)
{
        this._ILugar_de_interesCAD = _ILugar_de_interesCAD;
}

public ILugar_de_interesCAD get_ILugar_de_interesCAD ()
{
        return this._ILugar_de_interesCAD;
}

public int New_ (int p_orden, int p_itinerario, string p_nombre, string p_localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum p_tipo)
{
        Lugar_de_interesEN lugar_de_interesEN = null;
        int oid;

        //Initialized Lugar_de_interesEN
        lugar_de_interesEN = new Lugar_de_interesEN ();
        lugar_de_interesEN.Orden = p_orden;


        if (p_itinerario != -1) {
                // El argumento p_itinerario -> Property itinerario es oid = false
                // Lista de oids id
                lugar_de_interesEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                lugar_de_interesEN.Itinerario.Id = p_itinerario;
        }

        lugar_de_interesEN.Nombre = p_nombre;

        lugar_de_interesEN.Localización = p_localización;

        lugar_de_interesEN.Tipo = p_tipo;

        //Call to Lugar_de_interesCAD

        oid = _ILugar_de_interesCAD.New_ (lugar_de_interesEN);
        return oid;
}

public void Modify (int p_Lugar_de_interes_OID, int p_orden, string p_nombre, string p_localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum p_tipo)
{
        Lugar_de_interesEN lugar_de_interesEN = null;

        //Initialized Lugar_de_interesEN
        lugar_de_interesEN = new Lugar_de_interesEN ();
        lugar_de_interesEN.Id = p_Lugar_de_interes_OID;
        lugar_de_interesEN.Orden = p_orden;
        lugar_de_interesEN.Nombre = p_nombre;
        lugar_de_interesEN.Localización = p_localización;
        lugar_de_interesEN.Tipo = p_tipo;
        //Call to Lugar_de_interesCAD

        _ILugar_de_interesCAD.Modify (lugar_de_interesEN);
}

public void Destroy (int id
                     )
{
        _ILugar_de_interesCAD.Destroy (id);
}
}
}
