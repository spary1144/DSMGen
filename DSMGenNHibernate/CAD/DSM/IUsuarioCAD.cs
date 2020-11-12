
using System;
using DSMGenNHibernate.EN.DSM;

namespace DSMGenNHibernate.CAD.DSM
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int id
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);





int New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (int id
              );


void AgregarViajesGuardados (int p_Usuario_OID, System.Collections.Generic.IList<int> p_viajesGuardados_OIDs);

void AgregarAmigos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_amigos_OIDs);

UsuarioEN ReadOID (int id
                   );


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);


System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> BuscarAmigo (int u_nombre);
}
}
