
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id
                             );

void ModifyDefault (ComentarioEN comentario);

System.Collections.Generic.IList<ComentarioEN> ReadAllDefault (int first, int size);



int New_ (ComentarioEN comentario);

void Modify (ComentarioEN comentario);


void Destroy (int id
              );
}
}
