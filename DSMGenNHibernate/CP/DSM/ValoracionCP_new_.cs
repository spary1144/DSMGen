
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



/*PROTECTED REGION ID(usingDSMGenNHibernate.CP.DSM_Valoracion_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CP.DSM
{
public partial class ValoracionCP : BasicCP
{
public DSMGenNHibernate.EN.DSM.ValoracionEN New_ (int p_usuario, int p_viajes, double p_puntuacion)
{
        /*PROTECTED REGION ID(DSMGenNHibernate.CP.DSM_Valoracion_new_) ENABLED START*/

        IValoracionCAD valoracionCAD = null;
        ValoracionCEN valoracionCEN = null;
        ViajeCAD viajecad = null;
        ViajeCEN viajecen = null;

        DSMGenNHibernate.EN.DSM.ValoracionEN result = null;


        try
        {
                SessionInitializeTransaction ();
                valoracionCAD = new ValoracionCAD (session);
                valoracionCEN = new  ValoracionCEN (valoracionCAD);
                viajecad = new ViajeCAD (session);
                viajecen = new ViajeCEN (viajecad);


                int oid;
                //Initialized ValoracionEN
                ValoracionEN valoracionEN;
                valoracionEN = new ValoracionEN ();

                if (p_usuario != -1) {
                        valoracionEN.Usuario = new DSMGenNHibernate.EN.DSM.UsuarioEN ();
                        valoracionEN.Usuario.Id = p_usuario;
                }


                if (p_viajes != -1) {
                        valoracionEN.Viajes = new DSMGenNHibernate.EN.DSM.ViajeEN ();
                        valoracionEN.Viajes.Id = p_viajes;
                }

                valoracionEN.Puntuacion = p_puntuacion;

                //Call to ValoracionCAD

                oid = valoracionCAD.New_ (valoracionEN);
                result = valoracionCAD.ReadOIDDefault (oid);

                ViajeEN viajeen = viajecad.ReadOIDDefault (p_viajes);
                int valoracion = p_puntuacion;
                //Aqui calculamos la media

                double a = viajeen.ValoracionMedia;
                viajeen. = (a + p_puntuacion) / 2;
                // esta variable es la que actualizamos despu�s del calculo viajeen.ValoracionMedia
                //

                viajecad.ModifyDefault (viajeen);

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
