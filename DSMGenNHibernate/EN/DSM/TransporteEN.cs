
using System;
// Definición clase TransporteEN
namespace DSMGenNHibernate.EN.DSM
{
public partial class TransporteEN                                                                   : DSMGenNHibernate.EN.DSM.PuntoDeItinerarioEN


{
/**
 *	Atributo tipo
 */
private DSMGenNHibernate.Enumerated.DSM.TipoTransporteEnum tipo;



/**
 *	Atributo origen
 */
private string origen;



/**
 *	Atributo destino
 */
private string destino;






public virtual DSMGenNHibernate.Enumerated.DSM.TipoTransporteEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual string Origen {
        get { return origen; } set { origen = value;  }
}



public virtual string Destino {
        get { return destino; } set { destino = value;  }
}





public TransporteEN() : base ()
{
}



public TransporteEN(int id, DSMGenNHibernate.Enumerated.DSM.TipoTransporteEnum tipo, string origen, string destino
                    , int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario
                    )
{
        this.init (Id, tipo, origen, destino, orden, itinerario);
}


public TransporteEN(TransporteEN transporte)
{
        this.init (Id, transporte.Tipo, transporte.Origen, transporte.Destino, transporte.Orden, transporte.Itinerario);
}

private void init (int id
                   , DSMGenNHibernate.Enumerated.DSM.TipoTransporteEnum tipo, string origen, string destino, int orden, DSMGenNHibernate.EN.DSM.ItinerarioEN itinerario)
{
        this.Id = id;


        this.Tipo = tipo;

        this.Origen = origen;

        this.Destino = destino;

        this.Orden = orden;

        this.Itinerario = itinerario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TransporteEN t = obj as TransporteEN;
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
