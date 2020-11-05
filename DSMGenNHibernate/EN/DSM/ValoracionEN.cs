
using System;
// Definición clase ValoracionEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class ValoracionEN
{
/**
 *	Atributo usuario
 */
private DSMGenNHibernate.EN.DSM.UsuarioEN usuario;



/**
 *	Atributo viajes
 */
private DSMGenNHibernate.EN.DSM.ViajeEN viajes;



/**
 *	Atributo puntuacion
 */
private int puntuacion;



/**
 *	Atributo id
 */
private int id;






public virtual DSMGenNHibernate.EN.DSM.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual DSMGenNHibernate.EN.DSM.ViajeEN Viajes {
        get { return viajes; } set { viajes = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int id, DSMGenNHibernate.EN.DSM.UsuarioEN usuario, DSMGenNHibernate.EN.DSM.ViajeEN viajes, int puntuacion
                    )
{
        this.init (Id, usuario, viajes, puntuacion);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Usuario, valoracion.Viajes, valoracion.Puntuacion);
}

private void init (int id
                   , DSMGenNHibernate.EN.DSM.UsuarioEN usuario, DSMGenNHibernate.EN.DSM.ViajeEN viajes, int puntuacion)
{
        this.Id = id;


        this.Usuario = usuario;

        this.Viajes = viajes;

        this.Puntuacion = puntuacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
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
