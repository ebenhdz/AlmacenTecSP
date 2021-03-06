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
	public partial class SolicitudDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSolicitud(Solicitud instance);
    partial void UpdateSolicitud(Solicitud instance);
    partial void DeleteSolicitud(Solicitud instance);
    #endregion
		
		public SolicitudDataContext() : 
				base(global::AlmacenTecSP.Properties.Settings.Default.AlmacenTecSPConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public SolicitudDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SolicitudDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SolicitudDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SolicitudDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Solicitud> Solicituds
		{
			get
			{
				return this.GetTable<Solicitud>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Solicitud")]
	public partial class Solicitud : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idSolicitud;
		
		private string _nomreSolicitante;
		
		private System.DateTime _fecha;
		
		private string _motivo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidSolicitudChanging(int value);
    partial void OnidSolicitudChanged();
    partial void OnnomreSolicitanteChanging(string value);
    partial void OnnomreSolicitanteChanged();
    partial void OnfechaChanging(System.DateTime value);
    partial void OnfechaChanged();
    partial void OnmotivoChanging(string value);
    partial void OnmotivoChanged();
    #endregion
		
		public Solicitud()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSolicitud", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idSolicitud
		{
			get
			{
				return this._idSolicitud;
			}
			set
			{
				if ((this._idSolicitud != value))
				{
					this.OnidSolicitudChanging(value);
					this.SendPropertyChanging();
					this._idSolicitud = value;
					this.SendPropertyChanged("idSolicitud");
					this.OnidSolicitudChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomreSolicitante", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nomreSolicitante
		{
			get
			{
				return this._nomreSolicitante;
			}
			set
			{
				if ((this._nomreSolicitante != value))
				{
					this.OnnomreSolicitanteChanging(value);
					this.SendPropertyChanging();
					this._nomreSolicitante = value;
					this.SendPropertyChanged("nomreSolicitante");
					this.OnnomreSolicitanteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="DateTime NOT NULL")]
		public System.DateTime fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this.OnfechaChanging(value);
					this.SendPropertyChanging();
					this._fecha = value;
					this.SendPropertyChanged("fecha");
					this.OnfechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_motivo", DbType="VarChar(200)")]
		public string motivo
		{
			get
			{
				return this._motivo;
			}
			set
			{
				if ((this._motivo != value))
				{
					this.OnmotivoChanging(value);
					this.SendPropertyChanging();
					this._motivo = value;
					this.SendPropertyChanged("motivo");
					this.OnmotivoChanged();
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
