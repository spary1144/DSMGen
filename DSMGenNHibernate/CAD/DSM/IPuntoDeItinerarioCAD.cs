
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface IPuntoDeItinerarioCAD
{
PuntoDeItinerarioEN ReadOIDDefault (int id
                                    );

void ModifyDefault (PuntoDeItinerarioEN puntoDeItinerario);

System.Collections.Generic.IList<PuntoDeItinerarioEN> ReadAllDefault (int first, int size);



int New_ (PuntoDeItinerarioEN puntoDeItinerario);

void Modify (PuntoDeItinerarioEN puntoDeItinerario);


void Destroy (int id
              );
}
}
