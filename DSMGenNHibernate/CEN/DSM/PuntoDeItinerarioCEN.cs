

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
 *      Definition of the class PuntoDeItinerarioCEN
 *
 */
public partial class PuntoDeItinerarioCEN
{
private IPuntoDeItinerarioCAD _IPuntoDeItinerarioCAD;

public PuntoDeItinerarioCEN()
{
        this._IPuntoDeItinerarioCAD = new PuntoDeItinerarioCAD ();
}

public PuntoDeItinerarioCEN(IPuntoDeItinerarioCAD _IPuntoDeItinerarioCAD)
{
        this._IPuntoDeItinerarioCAD = _IPuntoDeItinerarioCAD;
}

public IPuntoDeItinerarioCAD get_IPuntoDeItinerarioCAD ()
{
        return this._IPuntoDeItinerarioCAD;
}

public int New_ (int p_orden, int p_itinerario)
{
        PuntoDeItinerarioEN puntoDeItinerarioEN = null;
        int oid;

        //Initialized PuntoDeItinerarioEN
        puntoDeItinerarioEN = new PuntoDeItinerarioEN ();
        puntoDeItinerarioEN.Orden = p_orden;


        if (p_itinerario != -1) {
                // El argumento p_itinerario -> Property itinerario es oid = false
                // Lista de oids id
                puntoDeItinerarioEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                puntoDeItinerarioEN.Itinerario.Id = p_itinerario;
        }

        //Call to PuntoDeItinerarioCAD

        oid = _IPuntoDeItinerarioCAD.New_ (puntoDeItinerarioEN);
        return oid;
}

public void Modify (int p_PuntoDeItinerario_OID, int p_orden)
{
        PuntoDeItinerarioEN puntoDeItinerarioEN = null;

        //Initialized PuntoDeItinerarioEN
        puntoDeItinerarioEN = new PuntoDeItinerarioEN ();
        puntoDeItinerarioEN.Id = p_PuntoDeItinerario_OID;
        puntoDeItinerarioEN.Orden = p_orden;
        //Call to PuntoDeItinerarioCAD

        _IPuntoDeItinerarioCAD.Modify (puntoDeItinerarioEN);
}

public void Destroy (int id
                     )
{
        _IPuntoDeItinerarioCAD.Destroy (id);
}
}
}
