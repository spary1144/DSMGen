
using System;
// Definición clase Lugar_de_interesEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class Lugar_de_interesEN                                                                     : DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN


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





public Lugar_de_interesEN() : base ()
{
}



public Lugar_de_interesEN(int id, string nombre, string localización, DSMGenNHibernate.Enumerated.DSM.TipoLugarInteresEnum tipo
                          , int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario
                          )
{
        this.init (Id, nombre, localización, tipo, orden, itinerario);
}


public Lugar_de_interesEN(Lugar_de_interesEN lugar_de_interes)
{
        this.init (Id, lugar_de_interes.Nombre, lugar_de_interes.Localización, lugar_de_interes.Tipo, lugar_de_interes.Orden, lugar_de_interes.Itinerario);
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
        Lugar_de_interesEN t = obj as Lugar_de_interesEN;
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
