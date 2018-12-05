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
	public partial class PrestamoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPrestamo(Prestamo instance);
    partial void UpdatePrestamo(Prestamo instance);
    partial void DeletePrestamo(Prestamo instance);
    #endregion
		
		public PrestamoDataContext() : 
				base(global::AlmacenTecSP.Properties.Settings.Default.AlmacenTecSPConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PrestamoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrestamoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrestamoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrestamoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Prestamo> Prestamos
		{
			get
			{
				return this.GetTable<Prestamo>();
			}
		}
        public IEnumerable<Prestamo> GetAllCustomers()
        {
            var items = this.Prestamos.Select(item => item).OrderBy(item => item.idPrestamo);

            return items;
        }
    }
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prestamo")]
	public partial class Prestamo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idPrestamo;
		
		private int _idSolicitud;
		
		private bool _Entregado;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPrestamoChanging(int value);
    partial void OnidPrestamoChanged();
    partial void OnidSolicitudChanging(int value);
    partial void OnidSolicitudChanged();
    partial void OnEntregadoChanging(bool value);
    partial void OnEntregadoChanged();
    #endregion
		
		public Prestamo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPrestamo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idPrestamo
		{
			get
			{
				return this._idPrestamo;
			}
			set
			{
				if ((this._idPrestamo != value))
				{
					this.OnidPrestamoChanging(value);
					this.SendPropertyChanging();
					this._idPrestamo = value;
					this.SendPropertyChanged("idPrestamo");
					this.OnidPrestamoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSolicitud", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Entregado", DbType="Bit NOT NULL")]
		public bool Entregado
		{
			get
			{
				return this._Entregado;
			}
			set
			{
				if ((this._Entregado != value))
				{
					this.OnEntregadoChanging(value);
					this.SendPropertyChanging();
					this._Entregado = value;
					this.SendPropertyChanged("Entregado");
					this.OnEntregadoChanged();
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
