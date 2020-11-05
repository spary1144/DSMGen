
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface ILugardeinteresCAD
{
LugardeinteresEN ReadOIDDefault (int id
                                 );

void ModifyDefault (LugardeinteresEN lugardeinteres);

System.Collections.Generic.IList<LugardeinteresEN> ReadAllDefault (int first, int size);




int New_ (LugardeinteresEN lugardeinteres);

void Modify (LugardeinteresEN lugardeinteres);


void Destroy (int id
              );
}
}
