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

namespace LoginC
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeDB")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertregister(register instance);
    partial void Updateregister(register instance);
    partial void Deleteregister(register instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<register> registers
		{
			get
			{
				return this.GetTable<register>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.register")]
	public partial class register : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _rid;
		
		private string _rname;
		
		private string _remailid;
		
		private string _Userpassword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnridChanging(int value);
    partial void OnridChanged();
    partial void OnrnameChanging(string value);
    partial void OnrnameChanged();
    partial void OnremailidChanging(string value);
    partial void OnremailidChanged();
    partial void OnUserpasswordChanging(string value);
    partial void OnUserpasswordChanged();
    #endregion
		
		public register()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int rid
		{
			get
			{
				return this._rid;
			}
			set
			{
				if ((this._rid != value))
				{
					this.OnridChanging(value);
					this.SendPropertyChanging();
					this._rid = value;
					this.SendPropertyChanged("rid");
					this.OnridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string rname
		{
			get
			{
				return this._rname;
			}
			set
			{
				if ((this._rname != value))
				{
					this.OnrnameChanging(value);
					this.SendPropertyChanging();
					this._rname = value;
					this.SendPropertyChanged("rname");
					this.OnrnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_remailid", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string remailid
		{
			get
			{
				return this._remailid;
			}
			set
			{
				if ((this._remailid != value))
				{
					this.OnremailidChanging(value);
					this.SendPropertyChanging();
					this._remailid = value;
					this.SendPropertyChanged("remailid");
					this.OnremailidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Userpassword", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Userpassword
		{
			get
			{
				return this._Userpassword;
			}
			set
			{
				if ((this._Userpassword != value))
				{
					this.OnUserpasswordChanging(value);
					this.SendPropertyChanging();
					this._Userpassword = value;
					this.SendPropertyChanged("Userpassword");
					this.OnUserpasswordChanged();
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
