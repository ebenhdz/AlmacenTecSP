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
	public partial class ConsumiblesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertConsumible(Consumible instance);
    partial void UpdateConsumible(Consumible instance);
    partial void DeleteConsumible(Consumible instance);
    #endregion
		
		public ConsumiblesDataContext() : 
				base(global::AlmacenTecSP.Properties.Settings.Default.AlmacenTecSPConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConsumiblesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConsumiblesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConsumiblesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConsumiblesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Consumible> Consumibles
		{
			get
			{
				return this.GetTable<Consumible>();
			}
		}
        public IEnumerable<Consumible> GetAllCustomers()
        {
            var items = this.Consumibles.Select(item => item).OrderBy(item => item.idCateg);

            return items;
        }
    }
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Consumibles")]
	public partial class Consumible : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idConsu;
		
		private int _idCateg;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidConsuChanging(int value);
    partial void OnidConsuChanged();
    partial void OnidCategChanging(int value);
    partial void OnidCategChanged();
    #endregion
		
		public Consumible()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idConsu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idConsu
		{
			get
			{
				return this._idConsu;
			}
			set
			{
				if ((this._idConsu != value))
				{
					this.OnidConsuChanging(value);
					this.SendPropertyChanging();
					this._idConsu = value;
					this.SendPropertyChanged("idConsu");
					this.OnidConsuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCateg", DbType="Int NOT NULL")]
		public int idCateg
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
