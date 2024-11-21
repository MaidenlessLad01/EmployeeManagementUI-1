﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeUI
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeDetails")]
	public partial class database1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblAdminLogin(tblAdminLogin instance);
    partial void UpdatetblAdminLogin(tblAdminLogin instance);
    partial void DeletetblAdminLogin(tblAdminLogin instance);
    #endregion
		
		public database1DataContext() : 
				base(global::EmployeeUI.Properties.Settings.Default.EmployeeDetailsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public database1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public database1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public database1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public database1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblUserLogin> tblUserLogins
		{
			get
			{
				return this.GetTable<tblUserLogin>();
			}
		}
		
		public System.Data.Linq.Table<tblAdminLogin> tblAdminLogins
		{
			get
			{
				return this.GetTable<tblAdminLogin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUserLogin")]
	public partial class tblUserLogin
	{
		
		private System.Nullable<int> _employeeID;
		
		private string _username;
		
		private string _password;
		
		private string _role;
		
		public tblUserLogin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employeeID", DbType="Int")]
		public System.Nullable<int> employeeID
		{
			get
			{
				return this._employeeID;
			}
			set
			{
				if ((this._employeeID != value))
				{
					this._employeeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(30)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(30)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="VarChar(30)")]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this._role = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblAdminLogin")]
	public partial class tblAdminLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _adminID;
		
		private System.Nullable<int> _employeeID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnadminIDChanging(int value);
    partial void OnadminIDChanged();
    partial void OnemployeeIDChanging(System.Nullable<int> value);
    partial void OnemployeeIDChanged();
    #endregion
		
		public tblAdminLogin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int adminID
		{
			get
			{
				return this._adminID;
			}
			set
			{
				if ((this._adminID != value))
				{
					this.OnadminIDChanging(value);
					this.SendPropertyChanging();
					this._adminID = value;
					this.SendPropertyChanged("adminID");
					this.OnadminIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employeeID", DbType="Int")]
		public System.Nullable<int> employeeID
		{
			get
			{
				return this._employeeID;
			}
			set
			{
				if ((this._employeeID != value))
				{
					this.OnemployeeIDChanging(value);
					this.SendPropertyChanging();
					this._employeeID = value;
					this.SendPropertyChanged("employeeID");
					this.OnemployeeIDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591