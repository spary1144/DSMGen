
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
 * Clase Itinerario:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class ItinerarioCAD : BasicCAD, IItinerarioCAD
{
public ItinerarioCAD() : base ()
{
}

public ItinerarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ItinerarioEN ReadOIDDefault (int id
                                    )
{
        ItinerarioEN itinerarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                itinerarioEN = (ItinerarioEN)session.Get (typeof(ItinerarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return itinerarioEN;
}

public System.Collections.Generic.IList<ItinerarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ItinerarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ItinerarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ItinerarioEN>();
                        else
                                result = session.CreateCriteria (typeof(ItinerarioEN)).List<ItinerarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ItinerarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ItinerarioEN itinerario)
{
        try
        {
                SessionInitializeTransaction ();
                ItinerarioEN itinerarioEN = (ItinerarioEN)session.Load (typeof(ItinerarioEN), itinerario.Id);

                itinerarioEN.Fechas = itinerario.Fechas;



                session.Update (itinerarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ItinerarioEN itinerario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (itinerario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return itinerario.Id;
}

public void Modify (ItinerarioEN itinerario)
{
        try
        {
                SessionInitializeTransaction ();
                ItinerarioEN itinerarioEN = (ItinerarioEN)session.Load (typeof(ItinerarioEN), itinerario.Id);

                itinerarioEN.Fechas = itinerario.Fechas;

                session.Update (itinerarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ItinerarioCAD.", ex);
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
                ItinerarioEN itinerarioEN = (ItinerarioEN)session.Load (typeof(ItinerarioEN), id);
                session.Delete (itinerarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AsignarViaje (int p_Itinerario_OID, System.Collections.Generic.IList<int> p_viajes_OIDs)
{
        DSMGenNHibernate.EN.DSM.ItinerarioEN itinerarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                itinerarioEN = (ItinerarioEN)session.Load (typeof(ItinerarioEN), p_Itinerario_OID);
                DSMGenNHibernate.EN.DSM.ViajeEN viajesENAux = null;
                if (itinerarioEN.Viajes == null) {
                        itinerarioEN.Viajes = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
                }

                foreach (int item in p_viajes_OIDs) {
                        viajesENAux = new DSMGenNHibernate.EN.DSM.ViajeEN ();
                        viajesENAux = (DSMGenNHibernate.EN.DSM.ViajeEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ViajeEN), item);
                        viajesENAux.Itinerarios.Add (itinerarioEN);

                        itinerarioEN.Viajes.Add (viajesENAux);
                }


                session.Update (itinerarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in ItinerarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
