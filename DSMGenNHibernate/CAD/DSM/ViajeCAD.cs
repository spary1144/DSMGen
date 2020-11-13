
using System;
using System.Text;
using DSMGenNHibernate.CEN.DSM;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMGenNHibernate.EN.DSM;
using DSMGenNHibernate.Exceptions;


/*
 * Clase Viaje:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class ViajeCAD : BasicCAD, IViajeCAD
{
public ViajeCAD() : base ()
{
}

public ViajeCAD(ISession sessionAux) : base (sessionAux)
{
}



public ViajeEN ReadOIDDefault (int id
                               )
{
        ViajeEN viajeEN = null;

        try
        {
                SessionInitializeTransaction ();
                viajeEN = (ViajeEN)session.Get (typeof(ViajeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return viajeEN;
}

public System.Collections.Generic.IList<ViajeEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ViajeEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ViajeEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ViajeEN>();
                        else
                                result = session.CreateCriteria (typeof(ViajeEN)).List<ViajeEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ViajeEN viaje)
{
        try
        {
                SessionInitializeTransaction ();
                ViajeEN viajeEN = (ViajeEN)session.Load (typeof(ViajeEN), viaje.Id);

                viajeEN.Nombre = viaje.Nombre;


                viajeEN.Pais = viaje.Pais;


                viajeEN.Ciudad = viaje.Ciudad;


                viajeEN.Descripcion = viaje.Descripcion;








                viajeEN.ValoracionMedia = viaje.ValoracionMedia;

                session.Update (viajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> BuscarpViaje (int v_nombre)
{
        System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ViajeEN self where FROM ViajeEN as viaje inner join viaje.";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ViajeENbuscarpViajeHQL");
                query.SetParameter ("v_nombre", v_nombre);

                result = query.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public int CrearViaje (ViajeEN viaje)
{
        try
        {
                SessionInitializeTransaction ();
                if (viaje.Creador != null) {
                        // Argumento OID y no colección.
                        viaje.Creador = (DSMGenNHibernate.EN.DSM.UsuarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.UsuarioEN), viaje.Creador.Id);

                        viaje.Creador.ViajesCreados
                        .Add (viaje);
                }

                session.Save (viaje);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return viaje.Id;
}

public void Modify (ViajeEN viaje)
{
        try
        {
                SessionInitializeTransaction ();
                ViajeEN viajeEN = (ViajeEN)session.Load (typeof(ViajeEN), viaje.Id);

                viajeEN.Nombre = viaje.Nombre;


                viajeEN.Pais = viaje.Pais;


                viajeEN.Ciudad = viaje.Ciudad;


                viajeEN.Descripcion = viaje.Descripcion;


                viajeEN.ValoracionMedia = viaje.ValoracionMedia;

                session.Update (viajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ViajeEN viajeEN = (ViajeEN)session.Load (typeof(ViajeEN), id);
                session.Delete (viajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AgregarCompañero (int p_Viaje_OID, System.Collections.Generic.IList<int> p_compañeros_OIDs)
{
        DSMGenNHibernate.EN.DSM.ViajeEN viajeEN = null;
        try
        {
                SessionInitializeTransaction ();
                viajeEN = (ViajeEN)session.Load (typeof(ViajeEN), p_Viaje_OID);
                DSMGenNHibernate.EN.DSM.UsuarioEN compañerosENAux = null;
                if (viajeEN.Compañeros == null) {
                        viajeEN.Compañeros = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.UsuarioEN>();
                }

                foreach (int item in p_compañeros_OIDs) {
                        compañerosENAux = new DSMGenNHibernate.EN.DSM.UsuarioEN ();
                        compañerosENAux = (DSMGenNHibernate.EN.DSM.UsuarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.UsuarioEN), item);
                        compañerosENAux.ViajesCompartidos.Add (viajeEN);

                        viajeEN.Compañeros.Add (compañerosENAux);
                }


                session.Update (viajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AsignarItinerario (int p_Viaje_OID, System.Collections.Generic.IList<int> p_itinerarios_OIDs)
{
        DSMGenNHibernate.EN.DSM.ViajeEN viajeEN = null;
        try
        {
                SessionInitializeTransaction ();
                viajeEN = (ViajeEN)session.Load (typeof(ViajeEN), p_Viaje_OID);
                DSMGenNHibernate.EN.DSM.ItinerarioEN itinerariosENAux = null;
                if (viajeEN.Itinerarios == null) {
                        viajeEN.Itinerarios = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ItinerarioEN>();
                }

                foreach (int item in p_itinerarios_OIDs) {
                        itinerariosENAux = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                        itinerariosENAux = (DSMGenNHibernate.EN.DSM.ItinerarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ItinerarioEN), item);
                        itinerariosENAux.Viajes.Add (viajeEN);

                        viajeEN.Itinerarios.Add (itinerariosENAux);
                }


                session.Update (viajeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> BuscarpPais (int v_pais)
{
        System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ViajeEN self where FROM ViajeEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ViajeENbuscarpPaisHQL");
                query.SetParameter ("v_pais", v_pais);

                result = query.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ViajeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
