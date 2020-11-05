
using System;
// Definición clase AlojamientoEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class AlojamientoEN                                                                  : DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN


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
 *	Atributo cp
 */
private string cp;



/**
 *	Atributo tipo
 */
private DSMGenNHibernate.Enumerated.DSM.TipoAlojamientoEnum tipo;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Pais {
        get { return pais; } set { pais = value;  }
}



public virtual string Cp {
        get { return cp; } set { cp = value;  }
}



public virtual DSMGenNHibernate.Enumerated.DSM.TipoAlojamientoEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}





public AlojamientoEN() : base ()
{
}



public AlojamientoEN(int id, string nombre, string pais, string cp, DSMGenNHibernate.Enumerated.DSM.TipoAlojamientoEnum tipo
                     , int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario
                     )
{
        this.init (Id, nombre, pais, cp, tipo, orden, itinerario);
}


public AlojamientoEN(AlojamientoEN alojamiento)
{
        this.init (Id, alojamiento.Nombre, alojamiento.Pais, alojamiento.Cp, alojamiento.Tipo, alojamiento.Orden, alojamiento.Itinerario);
}

private void init (int id
                   , string nombre, string pais, string cp, DSMGenNHibernate.Enumerated.DSM.TipoAlojamientoEnum tipo, int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Pais = pais;

        this.Cp = cp;

        this.Tipo = tipo;

        this.Orden = orden;

        this.Itinerario = itinerario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AlojamientoEN t = obj as AlojamientoEN;
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
