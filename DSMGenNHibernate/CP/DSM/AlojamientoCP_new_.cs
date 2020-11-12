
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



/*PROTECTED REGION ID(usingDSMGenNHibernate.CP.DSM_Alojamiento_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CP.DSM
{
public partial class AlojamientoCP : BasicCP
{
public DSMGenNHibernate.EN.DSM.AlojamientoEN New_ (int p_orden, int p_itinerario, string p_nombre, string p_pais, string p_cp, DSMGenNHibernate.Enumerated.DSM.TipoAlojamientoEnum p_tipo)
{
        /*PROTECTED REGION ID(DSMGenNHibernate.CP.DSM_Alojamiento_new_) ENABLED START*/

        IAlojamientoCAD alojamientoCAD = null;
        AlojamientoCEN alojamientoCEN = null;

        DSMGenNHibernate.EN.DSM.AlojamientoEN result = null;


        try
        {
                SessionInitializeTransaction ();
                alojamientoCAD = new AlojamientoCAD (session);
                alojamientoCEN = new  AlojamientoCEN (alojamientoCAD);




                int oid;
                //Initialized AlojamientoEN
                AlojamientoEN alojamientoEN;
                alojamientoEN = new AlojamientoEN ();
                alojamientoEN.Orden = p_orden;


                if (p_itinerario != -1) {
                        alojamientoEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                        alojamientoEN.Itinerario.Id = p_itinerario;
                }

                alojamientoEN.Nombre = p_nombre;

                alojamientoEN.Pais = p_pais;

                alojamientoEN.Cp = p_cp;

                alojamientoEN.Tipo = p_tipo;

                //Call to AlojamientoCAD

                oid = alojamientoCAD.New_ (alojamientoEN);
                result = alojamientoCAD.ReadOIDDefault (oid);



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
        return result;


        /*PROTECTED REGION END*/
}
}
}
