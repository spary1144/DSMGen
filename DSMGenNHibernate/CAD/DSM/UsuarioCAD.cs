
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
 * Clase Usuario:
 *
 */

namespace DSMGenNHibernate.CAD.DSM
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (int id
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Pass = usuario.Pass;








                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Id;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Pass = usuario.Pass;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), id);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AgregarViajesGuardados (int p_Usuario_OID, System.Collections.Generic.IList<int> p_viajesGuardados_OIDs)
{
        DSMGenNHibernate.EN.DSM.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                DSMGenNHibernate.EN.DSM.ViajeEN viajesGuardadosENAux = null;
                if (usuarioEN.ViajesGuardados == null) {
                        usuarioEN.ViajesGuardados = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
                }

                foreach (int item in p_viajesGuardados_OIDs) {
                        viajesGuardadosENAux = new DSMGenNHibernate.EN.DSM.ViajeEN ();
                        viajesGuardadosENAux = (DSMGenNHibernate.EN.DSM.ViajeEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.ViajeEN), item);
                        viajesGuardadosENAux.Usuarios.Add (usuarioEN);

                        usuarioEN.ViajesGuardados.Add (viajesGuardadosENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AgregarAmigos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_amigos_OIDs)
{
        DSMGenNHibernate.EN.DSM.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                DSMGenNHibernate.EN.DSM.UsuarioEN amigosENAux = null;
                if (usuarioEN.Amigos == null) {
                        usuarioEN.Amigos = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.UsuarioEN>();
                }

                foreach (int item in p_amigos_OIDs) {
                        amigosENAux = new DSMGenNHibernate.EN.DSM.UsuarioEN ();
                        amigosENAux = (DSMGenNHibernate.EN.DSM.UsuarioEN)session.Load (typeof(DSMGenNHibernate.EN.DSM.UsuarioEN), item);
                        amigosENAux.Usuario = usuarioEN;

                        usuarioEN.Amigos.Add (amigosENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is DSMGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new DSMGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
