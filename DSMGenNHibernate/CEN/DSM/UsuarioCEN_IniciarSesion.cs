
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMGenNHibernate.Exceptions;
using DSMGenNHibernate.EN.DSM;
using DSMGenNHibernate.CAD.DSM;


/*PROTECTED REGION ID(usingDSMGenNHibernate.CEN.DSM_Usuario_IniciarSesion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CEN.DSM
{
public partial class UsuarioCEN
{
public void IniciarSesion (int p_oid)
{
        /*PROTECTED REGION ID(DSMGenNHibernate.CEN.DSM_Usuario_IniciarSesion) ENABLED START*/
        String salida = null;
        UsuarioEN usuen = _IUsuarioCAD.ReadOID (p_oid);

        if (usuen != null && usuen.Pass.Equals (Utils.Util.GetEncondeMD5 ("1234")))
                salida = "login realizado de manera correcta";

        return salida;
        // Write here your custom code...

        throw new NotImplementedException ("Method IniciarSesion() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
