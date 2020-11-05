

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
 *      Definition of the class TransporteCEN
 *
 */
public partial class TransporteCEN
{
private ITransporteCAD _ITransporteCAD;

public TransporteCEN()
{
        this._ITransporteCAD = new TransporteCAD ();
}

public TransporteCEN(ITransporteCAD _ITransporteCAD)
{
        this._ITransporteCAD = _ITransporteCAD;
}

public ITransporteCAD get_ITransporteCAD ()
{
        return this._ITransporteCAD;
}

public int New_ (int p_orden, int p_itinerario, DSMGenNHibernate.Enumerated.DSM.TipoTransporteEnum p_tipo, string p_origen, string p_destino)
{
        TransporteEN transporteEN = null;
        int oid;

        //Initialized TransporteEN
        transporteEN = new TransporteEN ();
        transporteEN.Orden = p_orden;


        if (p_itinerario != -1) {
                // El argumento p_itinerario -> Property itinerario es oid = false
                // Lista de oids id
                transporteEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                transporteEN.Itinerario.Id = p_itinerario;
        }

        transporteEN.Tipo = p_tipo;

        transporteEN.Origen = p_origen;

        transporteEN.Destino = p_destino;

        //Call to TransporteCAD

        oid = _ITransporteCAD.New_ (transporteEN);
        return oid;
}

public void Modify (int p_Transporte_OID, int p_orden, DSMGenNHibernate.Enumerated.DSM.TipoTransporteEnum p_tipo, string p_origen, string p_destino)
{
        TransporteEN transporteEN = null;

        //Initialized TransporteEN
        transporteEN = new TransporteEN ();
        transporteEN.Id = p_Transporte_OID;
        transporteEN.Orden = p_orden;
        transporteEN.Tipo = p_tipo;
        transporteEN.Origen = p_origen;
        transporteEN.Destino = p_destino;
        //Call to TransporteCAD

        _ITransporteCAD.Modify (transporteEN);
}

public void Destroy (int id
                     )
{
        _ITransporteCAD.Destroy (id);
}
}
}
