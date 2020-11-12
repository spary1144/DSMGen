
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



/*PROTECTED REGION ID(usingDSMGenNHibernate.CP.DSM_Lugar_de_interes_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CP.DSM
{
public partial class Lugar_de_interesCP : BasicCP
{
public DSMGenNHibernate.EN.DSM.Lugar_de_interesEN New_ (int p_orden, int p_itinerario, string p_nombre, string p_localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum p_tipo)
{
        /*PROTECTED REGION ID(DSMGenNHibernate.CP.DSM_Lugar_de_interes_new_) ENABLED START*/

        ILugar_de_interesCAD lugar_de_interesCAD = null;
        Lugar_de_interesCEN lugar_de_interesCEN = null;

        DSMGenNHibernate.EN.DSM.Lugar_de_interesEN result = null;


        try
        {
                SessionInitializeTransaction ();
                lugar_de_interesCAD = new Lugar_de_interesCAD (session);
                lugar_de_interesCEN = new  Lugar_de_interesCEN (lugar_de_interesCAD);




                int oid;
                //Initialized Lugar_de_interesEN
                Lugar_de_interesEN lugar_de_interesEN;
                lugar_de_interesEN = new Lugar_de_interesEN ();
                lugar_de_interesEN.Orden = p_orden;


                if (p_itinerario != -1) {
                        lugar_de_interesEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                        lugar_de_interesEN.Itinerario.Id = p_itinerario;
                }

                lugar_de_interesEN.Nombre = p_nombre;

                lugar_de_interesEN.Localización = p_localización;

                lugar_de_interesEN.Tipo = p_tipo;

                //Call to Lugar_de_interesCAD

                oid = lugar_de_interesCAD.New_ (lugar_de_interesEN);
                result = lugar_de_interesCAD.ReadOIDDefault (oid);



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
