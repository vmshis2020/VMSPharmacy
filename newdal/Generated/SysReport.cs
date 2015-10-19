using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace VNS.HIS.DAL
{
	/// <summary>
	/// Strongly-typed collection for the SysReport class.
	/// </summary>
    [Serializable]
	public partial class SysReportCollection : ActiveList<SysReport, SysReportCollection>
	{	   
		public SysReportCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SysReportCollection</returns>
		public SysReportCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SysReport o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the Sys_Reports table.
	/// </summary>
	[Serializable]
	public partial class SysReport : ActiveRecord<SysReport>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SysReport()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SysReport(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SysReport(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SysReport(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("Sys_Reports", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMaBaocao = new TableSchema.TableColumn(schema);
				colvarMaBaocao.ColumnName = "ma_baocao";
				colvarMaBaocao.DataType = DbType.String;
				colvarMaBaocao.MaxLength = 100;
				colvarMaBaocao.AutoIncrement = false;
				colvarMaBaocao.IsNullable = false;
				colvarMaBaocao.IsPrimaryKey = true;
				colvarMaBaocao.IsForeignKey = false;
				colvarMaBaocao.IsReadOnly = false;
				colvarMaBaocao.DefaultSetting = @"";
				colvarMaBaocao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaBaocao);
				
				TableSchema.TableColumn colvarMaNhom = new TableSchema.TableColumn(schema);
				colvarMaNhom.ColumnName = "ma_nhom";
				colvarMaNhom.DataType = DbType.String;
				colvarMaNhom.MaxLength = 20;
				colvarMaNhom.AutoIncrement = false;
				colvarMaNhom.IsNullable = true;
				colvarMaNhom.IsPrimaryKey = false;
				colvarMaNhom.IsForeignKey = false;
				colvarMaNhom.IsReadOnly = false;
				colvarMaNhom.DefaultSetting = @"";
				colvarMaNhom.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaNhom);
				
				TableSchema.TableColumn colvarTieuDe = new TableSchema.TableColumn(schema);
				colvarTieuDe.ColumnName = "tieu_de";
				colvarTieuDe.DataType = DbType.String;
				colvarTieuDe.MaxLength = 255;
				colvarTieuDe.AutoIncrement = false;
				colvarTieuDe.IsNullable = true;
				colvarTieuDe.IsPrimaryKey = false;
				colvarTieuDe.IsForeignKey = false;
				colvarTieuDe.IsReadOnly = false;
				colvarTieuDe.DefaultSetting = @"";
				colvarTieuDe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTieuDe);
				
				TableSchema.TableColumn colvarFileRieng = new TableSchema.TableColumn(schema);
				colvarFileRieng.ColumnName = "file_rieng";
				colvarFileRieng.DataType = DbType.String;
				colvarFileRieng.MaxLength = 200;
				colvarFileRieng.AutoIncrement = false;
				colvarFileRieng.IsNullable = true;
				colvarFileRieng.IsPrimaryKey = false;
				colvarFileRieng.IsForeignKey = false;
				colvarFileRieng.IsReadOnly = false;
				colvarFileRieng.DefaultSetting = @"";
				colvarFileRieng.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileRieng);
				
				TableSchema.TableColumn colvarFileChuan = new TableSchema.TableColumn(schema);
				colvarFileChuan.ColumnName = "file_chuan";
				colvarFileChuan.DataType = DbType.String;
				colvarFileChuan.MaxLength = 200;
				colvarFileChuan.AutoIncrement = false;
				colvarFileChuan.IsNullable = true;
				colvarFileChuan.IsPrimaryKey = false;
				colvarFileChuan.IsForeignKey = false;
				colvarFileChuan.IsReadOnly = false;
				colvarFileChuan.DefaultSetting = @"";
				colvarFileChuan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileChuan);
				
				TableSchema.TableColumn colvarMoTa = new TableSchema.TableColumn(schema);
				colvarMoTa.ColumnName = "mo_ta";
				colvarMoTa.DataType = DbType.String;
				colvarMoTa.MaxLength = 255;
				colvarMoTa.AutoIncrement = false;
				colvarMoTa.IsNullable = true;
				colvarMoTa.IsPrimaryKey = false;
				colvarMoTa.IsForeignKey = false;
				colvarMoTa.IsReadOnly = false;
				colvarMoTa.DefaultSetting = @"";
				colvarMoTa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMoTa);
				
				TableSchema.TableColumn colvarPrintNumber = new TableSchema.TableColumn(schema);
				colvarPrintNumber.ColumnName = "printNumber";
				colvarPrintNumber.DataType = DbType.Int16;
				colvarPrintNumber.MaxLength = 0;
				colvarPrintNumber.AutoIncrement = false;
				colvarPrintNumber.IsNullable = true;
				colvarPrintNumber.IsPrimaryKey = false;
				colvarPrintNumber.IsForeignKey = false;
				colvarPrintNumber.IsReadOnly = false;
				
						colvarPrintNumber.DefaultSetting = @"((1))";
				colvarPrintNumber.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrintNumber);
				
				TableSchema.TableColumn colvarNguoiTao = new TableSchema.TableColumn(schema);
				colvarNguoiTao.ColumnName = "nguoi_tao";
				colvarNguoiTao.DataType = DbType.String;
				colvarNguoiTao.MaxLength = 30;
				colvarNguoiTao.AutoIncrement = false;
				colvarNguoiTao.IsNullable = true;
				colvarNguoiTao.IsPrimaryKey = false;
				colvarNguoiTao.IsForeignKey = false;
				colvarNguoiTao.IsReadOnly = false;
				colvarNguoiTao.DefaultSetting = @"";
				colvarNguoiTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiTao);
				
				TableSchema.TableColumn colvarNgayTao = new TableSchema.TableColumn(schema);
				colvarNgayTao.ColumnName = "ngay_tao";
				colvarNgayTao.DataType = DbType.DateTime;
				colvarNgayTao.MaxLength = 0;
				colvarNgayTao.AutoIncrement = false;
				colvarNgayTao.IsNullable = true;
				colvarNgayTao.IsPrimaryKey = false;
				colvarNgayTao.IsForeignKey = false;
				colvarNgayTao.IsReadOnly = false;
				colvarNgayTao.DefaultSetting = @"";
				colvarNgayTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayTao);
				
				TableSchema.TableColumn colvarNguoiSua = new TableSchema.TableColumn(schema);
				colvarNguoiSua.ColumnName = "nguoi_sua";
				colvarNguoiSua.DataType = DbType.String;
				colvarNguoiSua.MaxLength = 30;
				colvarNguoiSua.AutoIncrement = false;
				colvarNguoiSua.IsNullable = true;
				colvarNguoiSua.IsPrimaryKey = false;
				colvarNguoiSua.IsForeignKey = false;
				colvarNguoiSua.IsReadOnly = false;
				colvarNguoiSua.DefaultSetting = @"";
				colvarNguoiSua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiSua);
				
				TableSchema.TableColumn colvarNgaySua = new TableSchema.TableColumn(schema);
				colvarNgaySua.ColumnName = "ngay_sua";
				colvarNgaySua.DataType = DbType.DateTime;
				colvarNgaySua.MaxLength = 0;
				colvarNgaySua.AutoIncrement = false;
				colvarNgaySua.IsNullable = true;
				colvarNgaySua.IsPrimaryKey = false;
				colvarNgaySua.IsForeignKey = false;
				colvarNgaySua.IsReadOnly = false;
				colvarNgaySua.DefaultSetting = @"";
				colvarNgaySua.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgaySua);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("Sys_Reports",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MaBaocao")]
		[Bindable(true)]
		public string MaBaocao 
		{
			get { return GetColumnValue<string>(Columns.MaBaocao); }
			set { SetColumnValue(Columns.MaBaocao, value); }
		}
		  
		[XmlAttribute("MaNhom")]
		[Bindable(true)]
		public string MaNhom 
		{
			get { return GetColumnValue<string>(Columns.MaNhom); }
			set { SetColumnValue(Columns.MaNhom, value); }
		}
		  
		[XmlAttribute("TieuDe")]
		[Bindable(true)]
		public string TieuDe 
		{
			get { return GetColumnValue<string>(Columns.TieuDe); }
			set { SetColumnValue(Columns.TieuDe, value); }
		}
		  
		[XmlAttribute("FileRieng")]
		[Bindable(true)]
		public string FileRieng 
		{
			get { return GetColumnValue<string>(Columns.FileRieng); }
			set { SetColumnValue(Columns.FileRieng, value); }
		}
		  
		[XmlAttribute("FileChuan")]
		[Bindable(true)]
		public string FileChuan 
		{
			get { return GetColumnValue<string>(Columns.FileChuan); }
			set { SetColumnValue(Columns.FileChuan, value); }
		}
		  
		[XmlAttribute("MoTa")]
		[Bindable(true)]
		public string MoTa 
		{
			get { return GetColumnValue<string>(Columns.MoTa); }
			set { SetColumnValue(Columns.MoTa, value); }
		}
		  
		[XmlAttribute("PrintNumber")]
		[Bindable(true)]
		public short? PrintNumber 
		{
			get { return GetColumnValue<short?>(Columns.PrintNumber); }
			set { SetColumnValue(Columns.PrintNumber, value); }
		}
		  
		[XmlAttribute("NguoiTao")]
		[Bindable(true)]
		public string NguoiTao 
		{
			get { return GetColumnValue<string>(Columns.NguoiTao); }
			set { SetColumnValue(Columns.NguoiTao, value); }
		}
		  
		[XmlAttribute("NgayTao")]
		[Bindable(true)]
		public DateTime? NgayTao 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgayTao); }
			set { SetColumnValue(Columns.NgayTao, value); }
		}
		  
		[XmlAttribute("NguoiSua")]
		[Bindable(true)]
		public string NguoiSua 
		{
			get { return GetColumnValue<string>(Columns.NguoiSua); }
			set { SetColumnValue(Columns.NguoiSua, value); }
		}
		  
		[XmlAttribute("NgaySua")]
		[Bindable(true)]
		public DateTime? NgaySua 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgaySua); }
			set { SetColumnValue(Columns.NgaySua, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMaBaocao,string varMaNhom,string varTieuDe,string varFileRieng,string varFileChuan,string varMoTa,short? varPrintNumber,string varNguoiTao,DateTime? varNgayTao,string varNguoiSua,DateTime? varNgaySua)
		{
			SysReport item = new SysReport();
			
			item.MaBaocao = varMaBaocao;
			
			item.MaNhom = varMaNhom;
			
			item.TieuDe = varTieuDe;
			
			item.FileRieng = varFileRieng;
			
			item.FileChuan = varFileChuan;
			
			item.MoTa = varMoTa;
			
			item.PrintNumber = varPrintNumber;
			
			item.NguoiTao = varNguoiTao;
			
			item.NgayTao = varNgayTao;
			
			item.NguoiSua = varNguoiSua;
			
			item.NgaySua = varNgaySua;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varMaBaocao,string varMaNhom,string varTieuDe,string varFileRieng,string varFileChuan,string varMoTa,short? varPrintNumber,string varNguoiTao,DateTime? varNgayTao,string varNguoiSua,DateTime? varNgaySua)
		{
			SysReport item = new SysReport();
			
				item.MaBaocao = varMaBaocao;
			
				item.MaNhom = varMaNhom;
			
				item.TieuDe = varTieuDe;
			
				item.FileRieng = varFileRieng;
			
				item.FileChuan = varFileChuan;
			
				item.MoTa = varMoTa;
			
				item.PrintNumber = varPrintNumber;
			
				item.NguoiTao = varNguoiTao;
			
				item.NgayTao = varNgayTao;
			
				item.NguoiSua = varNguoiSua;
			
				item.NgaySua = varNgaySua;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MaBaocaoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MaNhomColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TieuDeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FileRiengColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FileChuanColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MoTaColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn PrintNumberColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiSuaColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn NgaySuaColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MaBaocao = @"ma_baocao";
			 public static string MaNhom = @"ma_nhom";
			 public static string TieuDe = @"tieu_de";
			 public static string FileRieng = @"file_rieng";
			 public static string FileChuan = @"file_chuan";
			 public static string MoTa = @"mo_ta";
			 public static string PrintNumber = @"printNumber";
			 public static string NguoiTao = @"nguoi_tao";
			 public static string NgayTao = @"ngay_tao";
			 public static string NguoiSua = @"nguoi_sua";
			 public static string NgaySua = @"ngay_sua";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}