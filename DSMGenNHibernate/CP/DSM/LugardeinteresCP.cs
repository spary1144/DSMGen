
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
public partial class LugardeinteresCP : BasicCP
{
public LugardeinteresCP() : base ()
{
}

public LugardeinteresCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
