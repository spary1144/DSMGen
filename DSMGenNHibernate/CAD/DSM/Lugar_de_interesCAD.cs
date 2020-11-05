
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
 * Clase Lugar_de_interes:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class Lugar_de_interesCAD : BasicCAD, ILugar_de_interesCAD
{
public Lugar_de_interesCAD() : base ()
{
}

public Lugar_de_interesCAD(ISession sessionAux) : base (sessionAux)
{
}



public Lugar_de_interesEN ReadOIDDefault (int id
                                          )
{
        Lugar_de_interesEN lugar_de_interesEN = null;

        try
        {
                SessionInitializeTransaction ();
                lugar_de_interesEN = (Lugar_de_interesEN)session.Get (typeof(Lugar_de_interesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in Lugar_de_interesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lugar_de_interesEN;
}

public System.Collections.Generic.IList<Lugar_de_interesEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Lugar_de_interesEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Lugar_de_interesEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<Lugar_de_interesEN>();
                        else
                                result = session.CreateCriteria (typeof(Lugar_de_interesEN)).List<Lugar_de_interesEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in Lugar_de_interesCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Lugar_de_interesEN lugar_de_interes)
{
        try
        {
                SessionInitializeTransaction ();
                Lugar_de_interesEN lugar_de_interesEN = (Lugar_de_interesEN)session.Load (typeof(Lugar_de_interesEN), lugar_de_interes.Id);

                lugar_de_interesEN.Nombre = lugar_de_interes.Nombre;


                lugar_de_interesEN.Localización = lugar_de_interes.Localización;


                lugar_de_interesEN.Tipo = lugar_de_interes.Tipo;

                session.Update (lugar_de_interesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in Lugar_de_interesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (Lugar_de_interesEN lugar_de_interes)
{
        try
        {
                SessionInitializeTransaction ();
                if (lugar_de_interes.Itinerario != null) {
                        // Argumento OID y no colección.
                        lugar_de_interes.Itinerario = (DSMGenNHibernate.EN.DSM.ItinerarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ItinerarioEN), lugar_de_interes.Itinerario.Id);

                        lugar_de_interes.Itinerario.PuntoDeItinerario
                        .Add (lugar_de_interes);
                }

                session.Save (lugar_de_interes);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in Lugar_de_interesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lugar_de_interes.Id;
}

public void Modify (Lugar_de_interesEN lugar_de_interes)
{
        try
        {
                SessionInitializeTransaction ();
                Lugar_de_interesEN lugar_de_interesEN = (Lugar_de_interesEN)session.Load (typeof(Lugar_de_interesEN), lugar_de_interes.Id);

                lugar_de_interesEN.Orden = lugar_de_interes.Orden;


                lugar_de_interesEN.Nombre = lugar_de_interes.Nombre;


                lugar_de_interesEN.Localización = lugar_de_interes.Localización;


                lugar_de_interesEN.Tipo = lugar_de_interes.Tipo;

                session.Update (lugar_de_interesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in Lugar_de_interesCAD.", ex);
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
                Lugar_de_interesEN lugar_de_interesEN = (Lugar_de_interesEN)session.Load (typeof(Lugar_de_interesEN), id);
                session.Delete (lugar_de_interesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in Lugar_de_interesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
