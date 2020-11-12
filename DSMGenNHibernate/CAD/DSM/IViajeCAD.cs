
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface IViajeCAD
{
ViajeEN ReadOIDDefault (int id
                        );

void ModifyDefault (ViajeEN viaje);

System.Collections.Generic.IList<ViajeEN> ReadAllDefault (int first, int size);




System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> BuscarpViaje (String v_nombre);


int CrearViaje (ViajeEN viaje);

void Modify (ViajeEN viaje);


void Destroy (int id
              );


void AgregarCompañero (int p_Viaje_OID, System.Collections.Generic.IList<int> p_compañeros_OIDs);

void AsignarItinerario (int p_Viaje_OID, System.Collections.Generic.IList<int> p_itinerarios_OIDs);

System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> BuscarpPais (String v_pais);
}
}
