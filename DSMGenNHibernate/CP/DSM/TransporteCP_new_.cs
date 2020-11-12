
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



/*PROTECTED REGION ID(usingDSMGenNHibernate.CP.DSM_Transporte_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CP.DSM
{
public partial class TransporteCP : BasicCP
{
public DSMGenNHibernate.EN.DSM.TransporteEN New_ (int p_orden, int p_itinerario, DSMGenNHibernate.Enumerated.DSM.TipoTransporteEnum p_tipo, string p_origen, string p_destino)
{
        /*PROTECTED REGION ID(DSMGenNHibernate.CP.DSM_Transporte_new_) ENABLED START*/

        ITransporteCAD transporteCAD = null;
        TransporteCEN transporteCEN = null;

        DSMGenNHibernate.EN.DSM.TransporteEN result = null;


        try
        {
                SessionInitializeTransaction ();
                transporteCAD = new TransporteCAD (session);
                transporteCEN = new  TransporteCEN (transporteCAD);




                int oid;
                //Initialized TransporteEN
                TransporteEN transporteEN;
                transporteEN = new TransporteEN ();
                transporteEN.Orden = p_orden;


                if (p_itinerario != -1) {
                        transporteEN.Itinerario = new DSMGenNHibernate.EN.DSM.ItinerarioEN ();
                        transporteEN.Itinerario.Id = p_itinerario;
                }

                transporteEN.Tipo = p_tipo;

                transporteEN.Origen = p_origen;

                transporteEN.Destino = p_destino;

                //Call to TransporteCAD

                oid = transporteCAD.New_ (transporteEN);
                result = transporteCAD.ReadOIDDefault (oid);



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
