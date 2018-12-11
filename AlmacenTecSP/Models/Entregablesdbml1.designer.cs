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

namespace AlmacenTecSP.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AlmacenTecSP")]
	public partial class EntregablesdbmlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEntregable(Entregable instance);
    partial void UpdateEntregable(Entregable instance);
    partial void DeleteEntregable(Entregable instance);
    #endregion
		
		public EntregablesdbmlDataContext() : 
				base(global::AlmacenTecSP.Properties.Settings.Default.AlmacenTecSPConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EntregablesdbmlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntregablesdbmlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntregablesdbmlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntregablesdbmlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Entregable> Entregables
		{
			get
			{
				return this.GetTable<Entregable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Entregables")]
	public partial class Entregable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idEntrg;
		
		private System.Nullable<int> _idCateg;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidEntrgChanging(int value);
    partial void OnidEntrgChanged();
    partial void OnidCategChanging(System.Nullable<int> value);
    partial void OnidCategChanged();
    #endregion
		
		public Entregable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEntrg", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idEntrg
		{
			get
			{
				return this._idEntrg;
			}
			set
			{
				if ((this._idEntrg != value))
				{
					this.OnidEntrgChanging(value);
					this.SendPropertyChanging();
					this._idEntrg = value;
					this.SendPropertyChanged("idEntrg");
					this.OnidEntrgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCateg", DbType="Int")]
		public System.Nullable<int> idCateg
		{
			get
			{
				return this._idCateg;
			}
			set
			{
				if ((this._idCateg != value))
				{
					this.OnidCategChanging(value);
					this.SendPropertyChanging();
					this._idCateg = value;
					this.SendPropertyChanged("idCateg");
					this.OnidCategChanged();
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
