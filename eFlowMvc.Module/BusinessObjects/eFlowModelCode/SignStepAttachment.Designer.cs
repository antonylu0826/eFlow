﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace eFlowApi.Module.BusinessObjects.eFlowModel
{

    public partial class SignStepAttachment : DevExpress.Persistent.BaseImpl.BaseObject
    {
        SignStep fSignStep;
        [Association(@"SignStepAttachmentReferencesFormSignStep")]
        public SignStep SignStep
        {
            get { return fSignStep; }
            set { SetPropertyValue<SignStep>(nameof(SignStep), ref fSignStep, value); }
        }
        DevExpress.Persistent.BaseImpl.FileData fDocument;
        [MemberDesignTimeVisibility(true)]
        public DevExpress.Persistent.BaseImpl.FileData Document
        {
            get { return fDocument; }
            set { SetPropertyValue<DevExpress.Persistent.BaseImpl.FileData>(nameof(Document), ref fDocument, value); }
        }
    }

}
