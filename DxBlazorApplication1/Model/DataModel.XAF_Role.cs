﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 6/10/2022 12:24:24 μμ
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

#nullable enable annotations
#nullable disable warnings

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace DxBlazorApplication1
{
    public partial class XAF_Role {

        public XAF_Role()
        {
            this.XAF_Roles1 = new List<XAF_Role>();
            this.XAF_Roles = new List<XAF_Role>();
            this.XAF_Users = new List<XAF_User>();
            OnCreated();
        }

        public virtual int ID { get; set; }

        public virtual string? Name { get; set; }

        public virtual bool IsAdministrative { get; set; }

        public virtual bool CanEditModel { get; set; }

        /// <summary>
        /// When 0 the role is not visible to the end users and cannot be assigned to new users.
        /// </summary>
        public virtual bool IS_VISIBLE { get; set; }

        public virtual IList<XAF_Role> XAF_Roles1 { get; set; }

        public virtual IList<XAF_Role> XAF_Roles { get; set; }

        public virtual IList<XAF_User> XAF_Users { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}