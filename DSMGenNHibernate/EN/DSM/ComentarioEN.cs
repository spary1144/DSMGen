
using System;
// Definición clase ComentarioEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class ComentarioEN
{
/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo usuario
 */
private DSMGenNHibernate.EN.DSM.UsuarioEN usuario;



/**
 *	Atributo viaje
 */
private DSMGenNHibernate.EN.DSM.ViajeEN viaje;






public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual DSMGenNHibernate.EN.DSM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual DSMGenNHibernate.EN.DSM.ViajeEN Viaje {
        get { return viaje; } set { viaje = value;  }
}





public ComentarioEN()
{
}



public ComentarioEN(int id, string contenido, DSMGenNHibernate.EN.DSM.UsuarioEN usuario, DSMGenNHibernate.EN.DSM.ViajeEN viaje
                    )
{
        this.init (Id, contenido, usuario, viaje);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Contenido, comentario.Usuario, comentario.Viaje);
}

private void init (int id
                   , string contenido, DSMGenNHibernate.EN.DSM.UsuarioEN usuario, DSMGenNHibernate.EN.DSM.ViajeEN viaje)
{
        this.Id = id;


        this.Contenido = contenido;

        this.Usuario = usuario;

        this.Viaje = viaje;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
