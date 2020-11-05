
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
}
}
