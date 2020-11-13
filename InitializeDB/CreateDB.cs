
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DSMGenNHibernate.EN.DSM;
using DSMGenNHibernate.CEN.DSM;
using DSMGenNHibernate.CAD.DSM;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
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
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes

                Console.WriteLine ("Estamos dentro");
                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");



                // Usuarios Inicializados
                UsuarioCEN usucen1 = new UsuarioCEN ();
                int user1 = usucen1.New_ ("Jorge", "1234");
                int user2 = usucen1.New_ ("Laureano", "1234");
                int user3 = usucen1.New_ ("Alicia", "1234");
                int user4 = usucen1.New_ ("Trap", "1234");


                UsuarioCAD usu1CAD = new UsuarioCAD ();
                UsuarioCEN usu1CEN = new UsuarioCEN (usu1CAD);
                UsuarioEN usu1EN = usu1CEN.ReadOID (usucen1.New_ ("Alex", "1234"));


                UsuarioEN usuen = new UsuarioEN ();
                int id1 = usuen.Id;
                //Viajes Inicializados
                ViajeCEN viajecen = new ViajeCEN ();
                int v1 = viajecen.CrearViaje ("Viaje 1", "España", "Alicante", "El mejor viaje de laureano", id1, 0.0);
                int v2 = viajecen.CrearViaje ("Viaje 2", "Francia", "Paris", "El peor viaje de laureano", usuen.Id, 0.0);
                int v3 = viajecen.CrearViaje ("Viaje 3", "Rusia", "Moskva", "Un viaje normal de laureano", usuen.Id, 0.0);

                //Valoracion de Viaje

                ValoracionCEN vViaje = new ValoracionCEN ();
                int valV = vViaje.New_ (user4, v1, 4.0);


                //Itinerario
                ItinerarioCEN itinerarioCEN = new ItinerarioCEN ();
                itinerarioCEN.New_ ("10/10/00");

                ItinerarioCAD itinerariocad = new ItinerarioCAD ();
                ItinerarioCEN itinerarioCEN2 = new ItinerarioCEN (itinerariocad);

                ItinerarioEN itinerarioEN = new ItinerarioEN ();

                //Inicializar punto de itinerario

                PuntoDeItinerarioCEN pdicen = new PuntoDeItinerarioCEN ();
                //El primer punto será 0 porque es el de partida
                pdicen.New_ (0, itinerarioEN.Id);

                TransporteCAD transportecad = new TransporteCAD ();
                TransporteCEN transportecen = new TransporteCEN (transportecad);
                TransporteEN transpoerteen = new TransporteEN ();
                transportecad.New_ (transpoerteen);
                transpoerteen.Tipo = 1;


                // Alojamiento

                AlojamientoCAD alojamientoCAD = new AlojamientoCAD ();
                AlojamientoCEN alojamientoCEN = new AlojamientoCEN ();
                AlojamientoEN alojamientoEN = new AlojamientoEN ();
                alojamientoCAD.New_ (alojamientoEN);

                alojamientoEN.Tipo = 1;

                alojamientoCEN.Consultar (alojamientoEN.Id);




                //Sitio de interes

                Lugar_de_interesCAD lugar_De_InteresCAD = new Lugar_de_interesCAD ();
                Lugar_de_interesCEN lugar_De_InteresCEN = new Lugar_de_interesCEN ();
                Lugar_de_interesEN lugar_De_InteresEN = new Lugar_de_interesEN ();

                lugar_De_InteresCAD.New_ (lugar_De_InteresEN);

                lugar_De_InteresEN.Tipo = 1;

                //Comentarios
                ComentarioCAD comentarioCAD = new ComentarioCAD ();
                ComentarioEN comentarioen = new ComentarioEN ();
                comentarioCAD.New_ (comentarioen);




                /*
                 * if (usucen1.IniciarSesion (id, "1234") != null) {
                 *     Console.WriteLine ("Jorge ha inciado sesi�n");
                 * }*/


                //cambio

                //Esto es un cambio

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
