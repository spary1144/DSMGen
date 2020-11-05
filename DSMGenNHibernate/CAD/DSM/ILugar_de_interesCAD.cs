
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface ILugar_de_interesCAD
{
Lugar_de_interesEN ReadOIDDefault (int id
                                   );

void ModifyDefault (Lugar_de_interesEN lugar_de_interes);

System.Collections.Generic.IList<Lugar_de_interesEN> ReadAllDefault (int first, int size);




int New_ (Lugar_de_interesEN lugar_de_interes);

void Modify (Lugar_de_interesEN lugar_de_interes);


void Destroy (int id
              );
}
}
