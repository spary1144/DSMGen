
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using DSMGenNHibernate.EN.DSM;
using DSMGenNHibernate.CAD.DSM;
using DSMGenNHibernate.CEN.DSM;



/*PROTECTED REGION ID(usingDSMGenNHibernate.CP.DSM_Usuario_agregarAmigos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CP.DSM
{
public partial class UsuarioCP : BasicCP
{
public void AgregarAmigos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_amigos_OIDs)
{
        /*PROTECTED REGION ID(DSMGenNHibernate.CP.DSM_Usuario_agregarAmigos) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new  UsuarioCEN (usuarioCAD);






                //Call to UsuarioCAD

                usuarioCAD.AgregarAmigos (p_Usuario_OID, p_amigos_OIDs);



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
