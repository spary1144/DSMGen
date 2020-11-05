
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
 * Clase Lugar de interes:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class LugardeinteresCAD : BasicCAD, ILugardeinteresCAD
{
public LugardeinteresCAD() : base ()
{
}

public LugardeinteresCAD(ISession sessionAux) : base (sessionAux)
{
}



public LugardeinteresEN ReadOIDDefault (int id
                                        )
{
        LugardeinteresEN lugardeinteresEN = null;

        try
        {
                SessionInitializeTransaction ();
                lugardeinteresEN = (LugardeinteresEN)session.Get (typeof(LugardeinteresEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in LugardeinteresCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lugardeinteresEN;
}

public System.Collections.Generic.IList<LugardeinteresEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LugardeinteresEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LugardeinteresEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LugardeinteresEN>();
                        else
                                result = session.CreateCriteria (typeof(LugardeinteresEN)).List<LugardeinteresEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in LugardeinteresCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LugardeinteresEN lugardeinteres)
{
        try
        {
                SessionInitializeTransaction ();
                LugardeinteresEN lugardeinteresEN = (LugardeinteresEN)session.Load (typeof(LugardeinteresEN), lugardeinteres.Id);

                lugardeinteresEN.Nombre = lugardeinteres.Nombre;


                lugardeinteresEN.Localización = lugardeinteres.Localización;


                lugardeinteresEN.Tipo = lugardeinteres.Tipo;

                session.Update (lugardeinteresEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in LugardeinteresCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LugardeinteresEN lugardeinteres)
{
        try
        {
                SessionInitializeTransaction ();
                if (lugardeinteres.Itinerario != null) {
                        // Argumento OID y no colección.
                        lugardeinteres.Itinerario = (DSMGenNHibernate.EN.DSM.ItinerarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ItinerarioEN), lugardeinteres.Itinerario.Id);

                        lugardeinteres.Itinerario.PuntoDeItinerario
                        .Add (lugardeinteres);
                }

                session.Save (lugardeinteres);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in LugardeinteresCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lugardeinteres.Id;
}

public void Modify (LugardeinteresEN lugardeinteres)
{
        try
        {
                SessionInitializeTransaction ();
                LugardeinteresEN lugardeinteresEN = (LugardeinteresEN)session.Load (typeof(LugardeinteresEN), lugardeinteres.Id);

                lugardeinteresEN.Orden = lugardeinteres.Orden;


                lugardeinteresEN.Nombre = lugardeinteres.Nombre;


                lugardeinteresEN.Localización = lugardeinteres.Localización;


                lugardeinteresEN.Tipo = lugardeinteres.Tipo;

                session.Update (lugardeinteresEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in LugardeinteresCAD.", ex);
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
                LugardeinteresEN lugardeinteresEN = (LugardeinteresEN)session.Load (typeof(LugardeinteresEN), id);
                session.Delete (lugardeinteresEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in LugardeinteresCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
