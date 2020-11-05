

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
 *      Definition of the class ItinerarioCEN
 *
 */
public partial class ItinerarioCEN
{
private IItinerarioCAD _IItinerarioCAD;

public ItinerarioCEN()
{
        this._IItinerarioCAD = new ItinerarioCAD ();
}

public ItinerarioCEN(IItinerarioCAD _IItinerarioCAD)
{
        this._IItinerarioCAD = _IItinerarioCAD;
}

public IItinerarioCAD get_IItinerarioCAD ()
{
        return this._IItinerarioCAD;
}

public int New_ (string p_fechas)
{
        ItinerarioEN itinerarioEN = null;
        int oid;

        //Initialized ItinerarioEN
        itinerarioEN = new ItinerarioEN ();
        itinerarioEN.Fechas = p_fechas;

        //Call to ItinerarioCAD

        oid = _IItinerarioCAD.New_ (itinerarioEN);
        return oid;
}

public void Modify (int p_Itinerario_OID, string p_fechas)
{
        ItinerarioEN itinerarioEN = null;

        //Initialized ItinerarioEN
        itinerarioEN = new ItinerarioEN ();
        itinerarioEN.Id = p_Itinerario_OID;
        itinerarioEN.Fechas = p_fechas;
        //Call to ItinerarioCAD

        _IItinerarioCAD.Modify (itinerarioEN);
}

public void Destroy (int id
                     )
{
        _IItinerarioCAD.Destroy (id);
}

public void AsignarViaje (int p_Itinerario_OID, System.Collections.Generic.IList<int> p_viajes_OIDs)
{
        //Call to ItinerarioCAD

        _IItinerarioCAD.AsignarViaje (p_Itinerario_OID, p_viajes_OIDs);
}
}
}
