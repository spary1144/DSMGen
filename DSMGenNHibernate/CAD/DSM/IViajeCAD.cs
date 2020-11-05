
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





int CrearViaje (ViajeEN viaje);

void Modify (ViajeEN viaje);


void Destroy (int id
              );


void AgregarCompañero (int p_Viaje_OID, System.Collections.Generic.IList<int> p_compañeros_OIDs);
}
}
