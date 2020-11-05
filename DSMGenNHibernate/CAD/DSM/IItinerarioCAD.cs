
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface IItinerarioCAD
{
ItinerarioEN ReadOIDDefault (int id
                             );

void ModifyDefault (ItinerarioEN itinerario);

System.Collections.Generic.IList<ItinerarioEN> ReadAllDefault (int first, int size);







int New_ (ItinerarioEN itinerario);

void Modify (ItinerarioEN itinerario);


void Destroy (int id
              );


void AsignarViaje (int p_Itinerario_OID, System.Collections.Generic.IList<int> p_viajes_OIDs);
}
}
