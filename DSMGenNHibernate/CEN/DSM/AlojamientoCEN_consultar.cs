
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


/*PROTECTED REGION ID(usingDSMGenNHibernate.CEN.DSM_Alojamiento_consultar) ENABLED START*/
//  references to other libraries
using System.Data.SqlClient;

using System.Data;
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CEN.DSM
{
public partial class AlojamientoCEN
{
public void Consultar (int p_oid)
{
        /*PROTECTED REGION ID(DSMGenNHibernate.CEN.DSM_Alojamiento_consultar) ENABLED START*/

        // Write here your custom code...




        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        String nombre = @"SELECT name FROM master.dbo.DSMGenNHibernate WHERE id = '" + p_oid + @"'";
        String pais = @"SELECT pais FROM master.dbo.DSMGenNHibernate WHERE id = '" + p_oid + @"'";
        String cp = @"SELECT cp FROM master.dbo.DSMGenNHibernate WHERE id = '" + p_oid + @"'";
        String tipo = @"SELECT tipo FROM master.dbo.DSMGenNHibernate WHERE id = '" + p_oid + @"'";

        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();




                //DELETE database if exist
                cmd = new SqlCommand (nombre, cnn);
                cmd.ExecuteNonQuery ();

                cmd = new SqlCommand (pais, cnn);
                cmd.ExecuteNonQuery ();

                cmd = new SqlCommand (cp, cnn);
                cmd.ExecuteNonQuery ();

                cmd = new SqlCommand (tipo, cnn);
                cmd.ExecuteNonQuery ();
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }


        Console.WriteLine ("Nombre:" + nombre);
        Console.WriteLine ("Pa�s:" + pais);
        Console.WriteLine ("Codigo postal:" + cp);
        Console.WriteLine ("Tipo:" + tipo);



        throw new NotImplementedException ("Method Consultar() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
