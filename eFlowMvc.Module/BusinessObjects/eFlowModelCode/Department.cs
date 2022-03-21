using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace eFlowApi.Module.BusinessObjects.eFlowModel
{

    public partial class Department
    {
        public Department(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
