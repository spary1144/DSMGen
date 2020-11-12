
using System;
// Definición clase UsuarioEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class UsuarioEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo viajesCompartidos
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesCompartidos;



/**
 *	Atributo viajesGuardados
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesGuardados;



/**
 *	Atributo comentarios
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> comentarios;



/**
 *	Atributo usuario
 */
private DSMGenNHibernate.EN.DSM.UsuarioEN usuario;



/**
 *	Atributo amigos
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> amigos;



/**
 *	Atributo viajesCreados
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesCreados;



/**
 *	Atributo valoraciones
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> valoraciones;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> ViajesCompartidos {
        get { return viajesCompartidos; } set { viajesCompartidos = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> ViajesGuardados {
        get { return viajesGuardados; } set { viajesGuardados = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> Comentarios {
        get { return comentarios; } set { comentarios = value;  }
}



public virtual DSMGenNHibernate.EN.DSM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> Amigos {
        get { return amigos; } set { amigos = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> ViajesCreados {
        get { return viajesCreados; } set { viajesCreados = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> Valoraciones {
        get { return valoraciones; } set { valoraciones = value;  }
}






public virtual string Attribute {
        /*PROTECTED REGION ID(EN_derived__vnJ1ICKxEeutgf5rSjBNxQ) ENABLED START*/
        // Write here your custom code...
        get { throw new NotSupportedException ("get	Attribute() not yet implemented."); }
        /*PROTECTED REGION END*/
}


public UsuarioEN()
{
        viajesCompartidos = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
        viajesGuardados = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
        comentarios = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ComentarioEN>();
        amigos = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.UsuarioEN>();
        viajesCreados = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
        valoraciones = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ValoracionEN>();
}



public UsuarioEN(int id, string nombre, String pass, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesCompartidos, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesGuardados, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> comentarios, DSMGenNHibernate.EN.DSM.UsuarioEN usuario, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> amigos, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesCreados, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> valoraciones
                 )
{
        this.init (Id, nombre, pass, viajesCompartidos, viajesGuardados, comentarios, usuario, amigos, viajesCreados, valoraciones);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Id, usuario.Nombre, usuario.Pass, usuario.ViajesCompartidos, usuario.ViajesGuardados, usuario.Comentarios, usuario.Usuario, usuario.Amigos, usuario.ViajesCreados, usuario.Valoraciones);
}

private void init (int id
                   , string nombre, String pass, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesCompartidos, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesGuardados, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> comentarios, DSMGenNHibernate.EN.DSM.UsuarioEN usuario, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> amigos, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajesCreados, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> valoraciones)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Pass = pass;

        this.ViajesCompartidos = viajesCompartidos;

        this.ViajesGuardados = viajesGuardados;

        this.Comentarios = comentarios;

        this.Usuario = usuario;

        this.Amigos = amigos;

        this.ViajesCreados = viajesCreados;

        this.Valoraciones = valoraciones;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
