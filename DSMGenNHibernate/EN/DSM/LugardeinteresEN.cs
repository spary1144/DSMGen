
using System;
// Definición clase LugardeinteresEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class LugardeinteresEN                                                                       : DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN


{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo localización
 */
private string localización;



/**
 *	Atributo tipo
 */
private DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum tipo;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Localización {
        get { return localización; } set { localización = value;  }
}



public virtual DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}





public LugardeinteresEN() : base ()
{
}



public LugardeinteresEN(int id, string nombre, string localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum tipo
                        , int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario
                        )
{
        this.init (Id, nombre, localización, tipo, orden, itinerario);
}


public LugardeinteresEN(LugardeinteresEN lugardeinteres)
{
        this.init (Id, lugardeinteres.Nombre, lugardeinteres.Localización, lugardeinteres.Tipo, lugardeinteres.Orden, lugardeinteres.Itinerario);
}

private void init (int id
                   , string nombre, string localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum tipo, int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Localización = localización;

        this.Tipo = tipo;

        this.Orden = orden;

        this.Itinerario = itinerario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LugardeinteresEN t = obj as LugardeinteresEN;
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
