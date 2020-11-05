
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
 * Clase PuntoDeItinerario:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class PuntoDeItinerarioCAD : BasicCAD, IPuntoDeItinerarioCAD
{
public PuntoDeItinerarioCAD() : base ()
{
}

public PuntoDeItinerarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public PuntoDeItinerarioEN ReadOIDDefault (int id
                                           )
{
        PuntoDeItinerarioEN puntoDeItinerarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntoDeItinerarioEN = (PuntoDeItinerarioEN)session.Get (typeof(PuntoDeItinerarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in PuntoDeItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntoDeItinerarioEN;
}

public System.Collections.Generic.IList<PuntoDeItinerarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PuntoDeItinerarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PuntoDeItinerarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PuntoDeItinerarioEN>();
                        else
                                result = session.CreateCriteria (typeof(PuntoDeItinerarioEN)).List<PuntoDeItinerarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in PuntoDeItinerarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PuntoDeItinerarioEN puntoDeItinerario)
{
        try
        {
                SessionInitializeTransaction ();
                PuntoDeItinerarioEN puntoDeItinerarioEN = (PuntoDeItinerarioEN)session.Load (typeof(PuntoDeItinerarioEN), puntoDeItinerario.Id);

                puntoDeItinerarioEN.Orden = puntoDeItinerario.Orden;


                session.Update (puntoDeItinerarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in PuntoDeItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PuntoDeItinerarioEN puntoDeItinerario)
{
        try
        {
                SessionInitializeTransaction ();
                if (puntoDeItinerario.Itinerario != null) {
                        // Argumento OID y no colección.
                        puntoDeItinerario.Itinerario = (DSMGenNHibernate.EN.DSM.ItinerarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ItinerarioEN), puntoDeItinerario.Itinerario.Id);

                        puntoDeItinerario.Itinerario.PuntoDeItinerario
                        .Add (puntoDeItinerario);
                }

                session.Save (puntoDeItinerario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in PuntoDeItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntoDeItinerario.Id;
}

public void Modify (PuntoDeItinerarioEN puntoDeItinerario)
{
        try
        {
                SessionInitializeTransaction ();
                PuntoDeItinerarioEN puntoDeItinerarioEN = (PuntoDeItinerarioEN)session.Load (typeof(PuntoDeItinerarioEN), puntoDeItinerario.Id);

                puntoDeItinerarioEN.Orden = puntoDeItinerario.Orden;

                session.Update (puntoDeItinerarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in PuntoDeItinerarioCAD.", ex);
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
                PuntoDeItinerarioEN puntoDeItinerarioEN = (PuntoDeItinerarioEN)session.Load (typeof(PuntoDeItinerarioEN), id);
                session.Delete (puntoDeItinerarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in PuntoDeItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
