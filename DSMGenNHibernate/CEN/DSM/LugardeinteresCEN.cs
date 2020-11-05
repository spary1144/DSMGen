

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
 *      Definition of the class LugardeinteresCEN
 *
 */
public partial class LugardeinteresCEN
{
private ILugardeinteresCAD _ILugardeinteresCAD;

public LugardeinteresCEN()
{
        this._ILugardeinteresCAD = new LugardeinteresCAD ();
}

public LugardeinteresCEN(ILugardeinteresCAD _ILugardeinteresCAD)
{
        this._ILugardeinteresCAD = _ILugardeinteresCAD;
}

public ILugardeinteresCAD get_ILugardeinteresCAD ()
{
        return this._ILugardeinteresCAD;
}

public int New_ (int p_orden, int p_itinerario, string p_nombre, string p_localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum p_tipo)
{
        LugardeinteresEN lugardeinteresEN = null;
        int oid;

        //Initialized LugardeinteresEN
        lugardeinteresEN = new LugardeinteresEN ();
        lugardeinteresEN.Orden = p_orden;


        if (p_itinerario != -1) {
                // El argumento p_itinerario -> Property itinerario es oid = false
                // Lista de oids id
                lugardeinteresEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                lugardeinteresEN.Itinerario.Id = p_itinerario;
        }

        lugardeinteresEN.Nombre = p_nombre;

        lugardeinteresEN.Localización = p_localización;

        lugardeinteresEN.Tipo = p_tipo;

        //Call to LugardeinteresCAD

        oid = _ILugardeinteresCAD.New_ (lugardeinteresEN);
        return oid;
}

public void Modify (int p_Lugardeinteres_OID, int p_orden, string p_nombre, string p_localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum p_tipo)
{
        LugardeinteresEN lugardeinteresEN = null;

        //Initialized LugardeinteresEN
        lugardeinteresEN = new LugardeinteresEN ();
        lugardeinteresEN.Id = p_Lugardeinteres_OID;
        lugardeinteresEN.Orden = p_orden;
        lugardeinteresEN.Nombre = p_nombre;
        lugardeinteresEN.Localización = p_localización;
        lugardeinteresEN.Tipo = p_tipo;
        //Call to LugardeinteresCAD

        _ILugardeinteresCAD.Modify (lugardeinteresEN);
}

public void Destroy (int id
                     )
{
        _ILugardeinteresCAD.Destroy (id);
}
}
}
