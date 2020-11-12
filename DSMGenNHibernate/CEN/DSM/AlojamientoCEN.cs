

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
 *      Definition of the class AlojamientoCEN
 *
 */
public partial class AlojamientoCEN
{
private IAlojamientoCAD _IAlojamientoCAD;

public AlojamientoCEN()
{
        this._IAlojamientoCAD = new AlojamientoCAD ();
}

public AlojamientoCEN(IAlojamientoCAD _IAlojamientoCAD)
{
        this._IAlojamientoCAD = _IAlojamientoCAD;
}

public IAlojamientoCAD get_IAlojamientoCAD ()
{
        return this._IAlojamientoCAD;
}

public int New_ (int p_orden, int p_itinerario, string p_nombre, string p_pais, string p_cp, DSMGenNHibernate.Enumerated.DSM.TipoAlojamientoEnum p_tipo)
{
        AlojamientoEN alojamientoEN = null;
        int oid;

        //Initialized AlojamientoEN
        alojamientoEN = new AlojamientoEN ();
        alojamientoEN.Orden = p_orden;


        if (p_itinerario != -1) {
                // El argumento p_itinerario -> Property itinerario es oid = false
                // Lista de oids id
                alojamientoEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                alojamientoEN.Itinerario.Id = p_itinerario;
        }

        alojamientoEN.Nombre = p_nombre;

        alojamientoEN.Pais = p_pais;

        alojamientoEN.Cp = p_cp;

        alojamientoEN.Tipo = p_tipo;

        //Call to AlojamientoCAD

        oid = _IAlojamientoCAD.New_ (alojamientoEN);
        return oid;
}

public void Modify (int p_Alojamiento_OID, int p_orden, string p_nombre, string p_pais, string p_cp, DSMGenNHibernate.Enumerated.DSM.TipoAlojamientoEnum p_tipo)
{
        AlojamientoEN alojamientoEN = null;

        //Initialized AlojamientoEN
        alojamientoEN = new AlojamientoEN ();
        alojamientoEN.Id = p_Alojamiento_OID;
        alojamientoEN.Orden = p_orden;
        alojamientoEN.Nombre = p_nombre;
        alojamientoEN.Pais = p_pais;
        alojamientoEN.Cp = p_cp;
        alojamientoEN.Tipo = p_tipo;
        //Call to AlojamientoCAD

        _IAlojamientoCAD.Modify (alojamientoEN);
}

public void Destroy (int id
                     )
{
        _IAlojamientoCAD.Destroy (id);
}
}
}
