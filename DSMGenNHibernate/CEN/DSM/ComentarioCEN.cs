

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using DSMGenNHibernate.Exceptions;

using DSMGenNHibernate.EN.DSM;
using DSMGenNHibernate.CAD.DSM;


namespace DSMGenNHibernate.CEN.DSM
{
/*
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int New_ (string p_contenido, int p_usuario, int p_viaje)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Contenido = p_contenido;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                comentarioEN.Usuario = new DSMGenNHibernate.EN.DSM.UsuarioEN ();
                comentarioEN.Usuario.Id = p_usuario;
        }


        if (p_viaje != -1) {
                // El argumento p_viaje -> Property viaje es oid = false
                // Lista de oids id
                comentarioEN.Viaje = new DSMGenNHibernate.EN.DSM.ViajeEN ();
                comentarioEN.Viaje.Id = p_viaje;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.New_ (comentarioEN);
        return oid;
}

public void Modify (int p_Comentario_OID, string p_contenido)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Contenido = p_contenido;
        //Call to ComentarioCAD

        _IComentarioCAD.Modify (comentarioEN);
}

public void Destroy (int id
                     )
{
        _IComentarioCAD.Destroy (id);
}
}
}
