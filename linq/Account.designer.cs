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

namespace linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ACCOUNT")]
	public partial class AccountDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertMANIFEST(MANIFEST instance);
    partial void UpdateMANIFEST(MANIFEST instance);
    partial void DeleteMANIFEST(MANIFEST instance);
    #endregion
		
		public AccountDataContext() : 
				base(global::linq.Properties.Settings.Default.ACCOUNTConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AccountDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AccountDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AccountDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AccountDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MANIFEST> MANIFEST
		{
			get
			{
				return this.GetTable<MANIFEST>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MANIFEST")]
	public partial class MANIFEST : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID;
		
		private System.DateTime _DATE;
		
		private decimal _COST;
		
		private string _REMARK;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(System.Guid value);
    partial void OnIDChanged();
    partial void OnDATEChanging(System.DateTime value);
    partial void OnDATEChanged();
    partial void OnCOSTChanging(decimal value);
    partial void OnCOSTChanged();
    partial void OnREMARKChanging(string value);
    partial void OnREMARKChanged();
    #endregion
		
		public MANIFEST()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE", DbType="Date NOT NULL")]
		public System.DateTime DATE
		{
			get
			{
				return this._DATE;
			}
			set
			{
				if ((this._DATE != value))
				{
					this.OnDATEChanging(value);
					this.SendPropertyChanging();
					this._DATE = value;
					this.SendPropertyChanged("DATE");
					this.OnDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COST", DbType="Money NOT NULL")]
		public decimal COST
		{
			get
			{
				return this._COST;
			}
			set
			{
				if ((this._COST != value))
				{
					this.OnCOSTChanging(value);
					this.SendPropertyChanging();
					this._COST = value;
					this.SendPropertyChanged("COST");
					this.OnCOSTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REMARK", DbType="VarChar(100)")]
		public string REMARK
		{
			get
			{
				return this._REMARK;
			}
			set
			{
				if ((this._REMARK != value))
				{
					this.OnREMARKChanging(value);
					this.SendPropertyChanging();
					this._REMARK = value;
					this.SendPropertyChanged("REMARK");
					this.OnREMARKChanged();
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
