
using System;
// Definición clase ViajeEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class ViajeEN
{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo pais
 */
private string pais;



/**
 *	Atributo ciudad
 */
private string ciudad;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo compañeros
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> compañeros;



/**
 *	Atributo usuarios
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> usuarios;



/**
 *	Atributo itinerarios
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ItinerarioEN> itinerarios;



/**
 *	Atributo comentarios
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> comentarios;



/**
 *	Atributo creador
 */
private DSMGenNHibernate.EN.DSM.UsuarioEN creador;



/**
 *	Atributo valoraciones
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> valoraciones;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Pais {
        get { return pais; } set { pais = value;  }
}



public virtual string Ciudad {
        get { return ciudad; } set { ciudad = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> Compañeros {
        get { return compañeros; } set { compañeros = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> Usuarios {
        get { return usuarios; } set { usuarios = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ItinerarioEN> Itinerarios {
        get { return itinerarios; } set { itinerarios = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> Comentarios {
        get { return comentarios; } set { comentarios = value;  }
}



public virtual DSMGenNHibernate.EN.DSM.UsuarioEN Creador {
        get { return creador; } set { creador = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> Valoraciones {
        get { return valoraciones; } set { valoraciones = value;  }
}





public ViajeEN()
{
        compañeros = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.UsuarioEN>();
        usuarios = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.UsuarioEN>();
        itinerarios = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ItinerarioEN>();
        comentarios = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ComentarioEN>();
        valoraciones = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ValoracionEN>();
}



public ViajeEN(int id, string nombre, string pais, string ciudad, string descripcion, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> compañeros, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> usuarios, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ItinerarioEN> itinerarios, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> comentarios, DSMGenNHibernate.EN.DSM.UsuarioEN creador, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> valoraciones
               )
{
        this.init (Id, nombre, pais, ciudad, descripcion, compañeros, usuarios, itinerarios, comentarios, creador, valoraciones);
}


public ViajeEN(ViajeEN viaje)
{
        this.init (Id, viaje.Nombre, viaje.Pais, viaje.Ciudad, viaje.Descripcion, viaje.Compañeros, viaje.Usuarios, viaje.Itinerarios, viaje.Comentarios, viaje.Creador, viaje.Valoraciones);
}

private void init (int id
                   , string nombre, string pais, string ciudad, string descripcion, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> compañeros, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.UsuarioEN> usuarios, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ItinerarioEN> itinerarios, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ComentarioEN> comentarios, DSMGenNHibernate.EN.DSM.UsuarioEN creador, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ValoracionEN> valoraciones)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Pais = pais;

        this.Ciudad = ciudad;

        this.Descripcion = descripcion;

        this.Compañeros = compañeros;

        this.Usuarios = usuarios;

        this.Itinerarios = itinerarios;

        this.Comentarios = comentarios;

        this.Creador = creador;

        this.Valoraciones = valoraciones;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ViajeEN t = obj as ViajeEN;
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
