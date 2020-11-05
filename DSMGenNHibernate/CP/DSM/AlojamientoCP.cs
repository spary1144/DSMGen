
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using DSMGenNHibernate.Exceptions;
using DSMGenNHibernate.EN.DSM;
using DSMGenNHibernate.CAD.DSM;
using DSMGenNHibernate.CEN.DSM;



namespace DSMGenNHibernate.CP.DSM
{
public partial class AlojamientoCP : BasicCP
{
public AlojamientoCP() : base ()
{
}

public AlojamientoCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
