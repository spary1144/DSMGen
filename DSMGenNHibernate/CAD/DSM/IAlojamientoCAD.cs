
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface IAlojamientoCAD
{
AlojamientoEN ReadOIDDefault (int id
                              );

void ModifyDefault (AlojamientoEN alojamiento);

System.Collections.Generic.IList<AlojamientoEN> ReadAllDefault (int first, int size);




int New_ (AlojamientoEN alojamiento);

void Modify (AlojamientoEN alojamiento);


void Destroy (int id
              );
}
}
