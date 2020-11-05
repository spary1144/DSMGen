
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
 * Clase Transporte:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class TransporteCAD : BasicCAD, ITransporteCAD
{
public TransporteCAD() : base ()
{
}

public TransporteCAD(ISession sessionAux) : base (sessionAux)
{
}



public TransporteEN ReadOIDDefault (int id
                                    )
{
        TransporteEN transporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                transporteEN = (TransporteEN)session.Get (typeof(TransporteEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in TransporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return transporteEN;
}

public System.Collections.Generic.IList<TransporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TransporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TransporteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TransporteEN>();
                        else
                                result = session.CreateCriteria (typeof(TransporteEN)).List<TransporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in TransporteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TransporteEN transporte)
{
        try
        {
                SessionInitializeTransaction ();
                TransporteEN transporteEN = (TransporteEN)session.Load (typeof(TransporteEN), transporte.Id);

                transporteEN.Tipo = transporte.Tipo;


                transporteEN.Origen = transporte.Origen;


                transporteEN.Destino = transporte.Destino;

                session.Update (transporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in TransporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (TransporteEN transporte)
{
        try
        {
                SessionInitializeTransaction ();
                if (transporte.Itinerario != null) {
                        // Argumento OID y no colección.
                        transporte.Itinerario = (DSMGenNHibernate.EN.DSM.ItinerarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ItinerarioEN), transporte.Itinerario.Id);

                        transporte.Itinerario.PuntoDeItinerario
                        .Add (transporte);
                }

                session.Save (transporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in TransporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return transporte.Id;
}

public void Modify (TransporteEN transporte)
{
        try
        {
                SessionInitializeTransaction ();
                TransporteEN transporteEN = (TransporteEN)session.Load (typeof(TransporteEN), transporte.Id);

                transporteEN.Orden = transporte.Orden;


                transporteEN.Tipo = transporte.Tipo;


                transporteEN.Origen = transporte.Origen;


                transporteEN.Destino = transporte.Destino;

                session.Update (transporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in TransporteCAD.", ex);
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
                TransporteEN transporteEN = (TransporteEN)session.Load (typeof(TransporteEN), id);
                session.Delete (transporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in TransporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
