
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface ITransporteCAD
{
TransporteEN ReadOIDDefault (int id
                             );

void ModifyDefault (TransporteEN transporte);

System.Collections.Generic.IList<TransporteEN> ReadAllDefault (int first, int size);




int New_ (TransporteEN transporte);

void Modify (TransporteEN transporte);


void Destroy (int id
              );
}
}
