
using System;
// Definición clase PuntoDeItinerarioEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class PuntoDeItinerarioEN
{
/**
 *	Atributo orden
 */
private int orden;



/**
 *	Atributo itinerario
 */
private DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario;



/**
 *	Atributo id
 */
private int id;






public virtual int Orden {
        get { return orden; } set { orden = value;  }
}



public virtual DSMGenNHibernate.EN.DSM.ItinerarioEN Itinerario {
        get { return itinerario; } set { itinerario = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public PuntoDeItinerarioEN()
{
}



public PuntoDeItinerarioEN(int id, int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario
                           )
{
        this.init (Id, orden, itinerario);
}


public PuntoDeItinerarioEN(PuntoDeItinerarioEN puntoDeItinerario)
{
        this.init (Id, puntoDeItinerario.Orden, puntoDeItinerario.Itinerario);
}

private void init (int id
                   , int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario)
{
        this.Id = id;


        this.Orden = orden;

        this.Itinerario = itinerario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PuntoDeItinerarioEN t = obj as PuntoDeItinerarioEN;
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
