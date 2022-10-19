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

namespace dynamicField.FormWihtMasterPage
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ankit_Practice")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMstCity(MstCity instance);
    partial void UpdateMstCity(MstCity instance);
    partial void DeleteMstCity(MstCity instance);
    partial void InsertMstProduct(MstProduct instance);
    partial void UpdateMstProduct(MstProduct instance);
    partial void DeleteMstProduct(MstProduct instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Ankit_PracticeConnectionString"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<MstCity> MstCities
		{
			get
			{
				return this.GetTable<MstCity>();
			}
		}
		
		public System.Data.Linq.Table<MstProduct> MstProducts
		{
			get
			{
				return this.GetTable<MstProduct>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MstCity")]
	public partial class MstCity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CityCode;
		
		private System.Nullable<int> _CityCodeOther;
		
		private string _CityDesc;
		
		private string _CityRemark;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCityCodeChanging(int value);
    partial void OnCityCodeChanged();
    partial void OnCityCodeOtherChanging(System.Nullable<int> value);
    partial void OnCityCodeOtherChanged();
    partial void OnCityDescChanging(string value);
    partial void OnCityDescChanged();
    partial void OnCityRemarkChanging(string value);
    partial void OnCityRemarkChanged();
    #endregion
		
		public MstCity()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityCode", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CityCode
		{
			get
			{
				return this._CityCode;
			}
			set
			{
				if ((this._CityCode != value))
				{
					this.OnCityCodeChanging(value);
					this.SendPropertyChanging();
					this._CityCode = value;
					this.SendPropertyChanged("CityCode");
					this.OnCityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityCodeOther", DbType="Int")]
		public System.Nullable<int> CityCodeOther
		{
			get
			{
				return this._CityCodeOther;
			}
			set
			{
				if ((this._CityCodeOther != value))
				{
					this.OnCityCodeOtherChanging(value);
					this.SendPropertyChanging();
					this._CityCodeOther = value;
					this.SendPropertyChanged("CityCodeOther");
					this.OnCityCodeOtherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityDesc", DbType="VarChar(30)")]
		public string CityDesc
		{
			get
			{
				return this._CityDesc;
			}
			set
			{
				if ((this._CityDesc != value))
				{
					this.OnCityDescChanging(value);
					this.SendPropertyChanging();
					this._CityDesc = value;
					this.SendPropertyChanged("CityDesc");
					this.OnCityDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityRemark", DbType="VarChar(30)")]
		public string CityRemark
		{
			get
			{
				return this._CityRemark;
			}
			set
			{
				if ((this._CityRemark != value))
				{
					this.OnCityRemarkChanging(value);
					this.SendPropertyChanging();
					this._CityRemark = value;
					this.SendPropertyChanged("CityRemark");
					this.OnCityRemarkChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MstProduct")]
	public partial class MstProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private string _ProductName;
		
		private string _Size;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<System.DateTime> _MfgDate;
		
		private string _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnMfgDateChanging(System.Nullable<System.DateTime> value);
    partial void OnMfgDateChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    #endregion
		
		public MstProduct()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(50)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(5)")]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(10,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MfgDate", DbType="Date")]
		public System.Nullable<System.DateTime> MfgDate
		{
			get
			{
				return this._MfgDate;
			}
			set
			{
				if ((this._MfgDate != value))
				{
					this.OnMfgDateChanging(value);
					this.SendPropertyChanging();
					this._MfgDate = value;
					this.SendPropertyChanged("MfgDate");
					this.OnMfgDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(50)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
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
