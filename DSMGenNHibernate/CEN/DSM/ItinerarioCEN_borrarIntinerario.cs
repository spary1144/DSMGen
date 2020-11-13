
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


/*PROTECTED REGION ID(usingDSMGenNHibernate.CEN.DSM_Itinerario_borrarIntinerario) ENABLED START*/
//  references to other libraries

using System.Data.SqlClient;

using System.Data;
/*PROTECTED REGION END*/

namespace DSMGenNHibernate.CEN.DSM
{
public partial class ItinerarioCEN
{
public void BorrarIntinerario (int p_oid)
{
            /*PROTECTED REGION ID(DSMGenNHibernate.CEN.DSM_Itinerario_borrarIntinerario) ENABLED START*/

            // Write here your custom code...


            SqlConnection cnn = new SqlConnection(@"Server=(local)\sqlexpress; database=master; integrated security=yes");

            String deleteDataBase = @"delete itinerario from sys.databases where id = '" + p_oid + "'@";


            SqlCommand cmd = null;
            try
            {
                // Open conex
                cnn.Open();

                //DELETE database if exist
                cmd = new SqlCommand(deleteDataBase, cnn);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }


           Console.WriteLine("Delete hecho correctamente");

            throw new NotImplementedException ("Method BorrarIntinerario() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
