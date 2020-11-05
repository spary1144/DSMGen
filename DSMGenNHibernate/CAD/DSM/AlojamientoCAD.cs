
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
 * Clase Alojamiento:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class AlojamientoCAD : BasicCAD, IAlojamientoCAD
{
public AlojamientoCAD() : base ()
{
}

public AlojamientoCAD(ISession sessionAux) : base (sessionAux)
{
}



public AlojamientoEN ReadOIDDefault (int id
                                     )
{
        AlojamientoEN alojamientoEN = null;

        try
        {
                SessionInitializeTransaction ();
                alojamientoEN = (AlojamientoEN)session.Get (typeof(AlojamientoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in AlojamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return alojamientoEN;
}

public System.Collections.Generic.IList<AlojamientoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AlojamientoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AlojamientoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AlojamientoEN>();
                        else
                                result = session.CreateCriteria (typeof(AlojamientoEN)).List<AlojamientoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in AlojamientoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AlojamientoEN alojamiento)
{
        try
        {
                SessionInitializeTransaction ();
                AlojamientoEN alojamientoEN = (AlojamientoEN)session.Load (typeof(AlojamientoEN), alojamiento.Id);

                alojamientoEN.Nombre = alojamiento.Nombre;


                alojamientoEN.Pais = alojamiento.Pais;


                alojamientoEN.Cp = alojamiento.Cp;


                alojamientoEN.Tipo = alojamiento.Tipo;

                session.Update (alojamientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in AlojamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AlojamientoEN alojamiento)
{
        try
        {
                SessionInitializeTransaction ();
                if (alojamiento.Itinerario != null) {
                        // Argumento OID y no colección.
                        alojamiento.Itinerario = (DSMGenNHibernate.EN.DSM.ItinerarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ItinerarioEN), alojamiento.Itinerario.Id);

                        alojamiento.Itinerario.PuntoDeItinerario
                        .Add (alojamiento);
                }

                session.Save (alojamiento);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in AlojamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return alojamiento.Id;
}

public void Modify (AlojamientoEN alojamiento)
{
        try
        {
                SessionInitializeTransaction ();
                AlojamientoEN alojamientoEN = (AlojamientoEN)session.Load (typeof(AlojamientoEN), alojamiento.Id);

                alojamientoEN.Orden = alojamiento.Orden;


                alojamientoEN.Nombre = alojamiento.Nombre;


                alojamientoEN.Pais = alojamiento.Pais;


                alojamientoEN.Cp = alojamiento.Cp;


                alojamientoEN.Tipo = alojamiento.Tipo;

                session.Update (alojamientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in AlojamientoCAD.", ex);
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
                AlojamientoEN alojamientoEN = (AlojamientoEN)session.Load (typeof(AlojamientoEN), id);
                session.Delete (alojamientoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in AlojamientoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
