
using System;
// Definición clase ItinerarioEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class ItinerarioEN
{
/**
 *	Atributo fechas
 */
private string fechas;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo viajes
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajes;



/**
 *	Atributo puntoDeItinerario
 */
private System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN> puntoDeItinerario;






public virtual string Fechas {
        get { return fechas; } set { fechas = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> Viajes {
        get { return viajes; } set { viajes = value;  }
}



public virtual System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN> PuntoDeItinerario {
        get { return puntoDeItinerario; } set { puntoDeItinerario = value;  }
}





public ItinerarioEN()
{
        viajes = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.ViajeEN>();
        puntoDeItinerario = new System.Collections.Generic.List<DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN>();
}



public ItinerarioEN(int id, string fechas, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajes, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN> puntoDeItinerario
                    )
{
        this.init (Id, fechas, viajes, puntoDeItinerario);
}


public ItinerarioEN(ItinerarioEN itinerario)
{
        this.init (Id, itinerario.Fechas, itinerario.Viajes, itinerario.PuntoDeItinerario);
}

private void init (int id
                   , string fechas, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.ViajeEN> viajes, System.Collections.Generic.IList<DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN> puntoDeItinerario)
{
        this.Id = id;


        this.Fechas = fechas;

        this.Viajes = viajes;

        this.PuntoDeItinerario = puntoDeItinerario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ItinerarioEN t = obj as ItinerarioEN;
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
