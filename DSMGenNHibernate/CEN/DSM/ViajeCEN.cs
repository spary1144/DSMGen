

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
 *      Definition of the class ViajeCEN
 *
 */
public partial class ViajeCEN
{
private IViajeCAD _IViajeCAD;

public ViajeCEN()
{
        this._IViajeCAD = new ViajeCAD ();
}

public ViajeCEN(IViajeCAD _IViajeCAD)
{
        this._IViajeCAD = _IViajeCAD;
}

public IViajeCAD get_IViajeCAD ()
{
        return this._IViajeCAD;
}

public int CrearViaje (string p_nombre, string p_pais, string p_ciudad, string p_descripcion, int p_creador, double p_valoracionMedia)
{
        ViajeEN viajeEN = null;
        int oid;

        //Initialized ViajeEN
        viajeEN = new ViajeEN ();
        viajeEN.Nombre = p_nombre;

        viajeEN.Pais = p_pais;

        viajeEN.Ciudad = p_ciudad;

        viajeEN.Descripcion = p_descripcion;


        if (p_creador != -1) {
                // El argumento p_creador -> Property creador es oid = false
                // Lista de oids id
                viajeEN.Creador = new DSMGenNHibernate.EN.DSM.UsuarioEN ();
                viajeEN.Creador.Id = p_creador;
        }

        viajeEN.ValoracionMedia = p_valoracionMedia;

        //Call to ViajeCAD

        oid = _IViajeCAD.CrearViaje (viajeEN);
        return oid;
}

public void Modify (int p_Viaje_OID, string p_nombre, string p_pais, string p_ciudad, string p_descripcion, double p_valoracionMedia)
{
        ViajeEN viajeEN = null;

        //Initialized ViajeEN
        viajeEN = new ViajeEN ();
        viajeEN.Id = p_Viaje_OID;
        viajeEN.Nombre = p_nombre;
        viajeEN.Pais = p_pais;
        viajeEN.Ciudad = p_ciudad;
        viajeEN.Descripcion = p_descripcion;
        viajeEN.ValoracionMedia = p_valoracionMedia;
        //Call to ViajeCAD

        _IViajeCAD.Modify (viajeEN);
}

public void Destroy (int id
                     )
{
        _IViajeCAD.Destroy (id);
}

public void AgregarCompañero (int p_Viaje_OID, System.Collections.Generic.IList<int> p_compañeros_OIDs)
{
        //Call to ViajeCAD

        _IViajeCAD.AgregarCompañero (p_Viaje_OID, p_compañeros_OIDs);
}
public void AsignarItinerario (int p_Viaje_OID, System.Collections.Generic.IList<int> p_itinerarios_OIDs)
{
        //Call to ViajeCAD

        _IViajeCAD.AsignarItinerario (p_Viaje_OID, p_itinerarios_OIDs);
}
}
}
