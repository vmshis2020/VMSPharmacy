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
	/// Strongly-typed collection for the SysVersion class.
	/// </summary>
    [Serializable]
	public partial class SysVersionCollection : ActiveList<SysVersion, SysVersionCollection>
	{	   
		public SysVersionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SysVersionCollection</returns>
		public SysVersionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SysVersion o = this[i];
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
	/// This is an ActiveRecord class which wraps the Sys_Version table.
	/// </summary>
	[Serializable]
	public partial class SysVersion : ActiveRecord<SysVersion>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SysVersion()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SysVersion(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SysVersion(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SysVersion(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Sys_Version", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPkIntID = new TableSchema.TableColumn(schema);
				colvarPkIntID.ColumnName = "PK_intID";
				colvarPkIntID.DataType = DbType.Int32;
				colvarPkIntID.MaxLength = 0;
				colvarPkIntID.AutoIncrement = true;
				colvarPkIntID.IsNullable = false;
				colvarPkIntID.IsPrimaryKey = true;
				colvarPkIntID.IsForeignKey = false;
				colvarPkIntID.IsReadOnly = false;
				colvarPkIntID.DefaultSetting = @"";
				colvarPkIntID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPkIntID);
				
				TableSchema.TableColumn colvarSFileName = new TableSchema.TableColumn(schema);
				colvarSFileName.ColumnName = "sFileName";
				colvarSFileName.DataType = DbType.String;
				colvarSFileName.MaxLength = 50;
				colvarSFileName.AutoIncrement = false;
				colvarSFileName.IsNullable = false;
				colvarSFileName.IsPrimaryKey = false;
				colvarSFileName.IsForeignKey = false;
				colvarSFileName.IsReadOnly = false;
				colvarSFileName.DefaultSetting = @"";
				colvarSFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSFileName);
				
				TableSchema.TableColumn colvarSRarFileName = new TableSchema.TableColumn(schema);
				colvarSRarFileName.ColumnName = "sRarFileName";
				colvarSRarFileName.DataType = DbType.String;
				colvarSRarFileName.MaxLength = 50;
				colvarSRarFileName.AutoIncrement = false;
				colvarSRarFileName.IsNullable = true;
				colvarSRarFileName.IsPrimaryKey = false;
				colvarSRarFileName.IsForeignKey = false;
				colvarSRarFileName.IsReadOnly = false;
				colvarSRarFileName.DefaultSetting = @"";
				colvarSRarFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSRarFileName);
				
				TableSchema.TableColumn colvarObjData = new TableSchema.TableColumn(schema);
				colvarObjData.ColumnName = "objData";
				colvarObjData.DataType = DbType.Binary;
				colvarObjData.MaxLength = 2147483647;
				colvarObjData.AutoIncrement = false;
				colvarObjData.IsNullable = false;
				colvarObjData.IsPrimaryKey = false;
				colvarObjData.IsForeignKey = false;
				colvarObjData.IsReadOnly = false;
				colvarObjData.DefaultSetting = @"";
				colvarObjData.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObjData);
				
				TableSchema.TableColumn colvarSVersion = new TableSchema.TableColumn(schema);
				colvarSVersion.ColumnName = "sVersion";
				colvarSVersion.DataType = DbType.String;
				colvarSVersion.MaxLength = 30;
				colvarSVersion.AutoIncrement = false;
				colvarSVersion.IsNullable = true;
				colvarSVersion.IsPrimaryKey = false;
				colvarSVersion.IsForeignKey = false;
				colvarSVersion.IsReadOnly = false;
				colvarSVersion.DefaultSetting = @"";
				colvarSVersion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSVersion);
				
				TableSchema.TableColumn colvarIntRar = new TableSchema.TableColumn(schema);
				colvarIntRar.ColumnName = "intRar";
				colvarIntRar.DataType = DbType.Int16;
				colvarIntRar.MaxLength = 0;
				colvarIntRar.AutoIncrement = false;
				colvarIntRar.IsNullable = true;
				colvarIntRar.IsPrimaryKey = false;
				colvarIntRar.IsForeignKey = false;
				colvarIntRar.IsReadOnly = false;
				colvarIntRar.DefaultSetting = @"";
				colvarIntRar.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIntRar);
				
				TableSchema.TableColumn colvarIntPatch = new TableSchema.TableColumn(schema);
				colvarIntPatch.ColumnName = "intPatch";
				colvarIntPatch.DataType = DbType.Int16;
				colvarIntPatch.MaxLength = 0;
				colvarIntPatch.AutoIncrement = false;
				colvarIntPatch.IsNullable = true;
				colvarIntPatch.IsPrimaryKey = false;
				colvarIntPatch.IsForeignKey = false;
				colvarIntPatch.IsReadOnly = false;
				colvarIntPatch.DefaultSetting = @"";
				colvarIntPatch.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIntPatch);
				
				TableSchema.TableColumn colvarTUpdatedDate = new TableSchema.TableColumn(schema);
				colvarTUpdatedDate.ColumnName = "tUpdatedDate";
				colvarTUpdatedDate.DataType = DbType.DateTime;
				colvarTUpdatedDate.MaxLength = 0;
				colvarTUpdatedDate.AutoIncrement = false;
				colvarTUpdatedDate.IsNullable = true;
				colvarTUpdatedDate.IsPrimaryKey = false;
				colvarTUpdatedDate.IsForeignKey = false;
				colvarTUpdatedDate.IsReadOnly = false;
				colvarTUpdatedDate.DefaultSetting = @"";
				colvarTUpdatedDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTUpdatedDate);
				
				TableSchema.TableColumn colvarDblCapacity = new TableSchema.TableColumn(schema);
				colvarDblCapacity.ColumnName = "dblCapacity";
				colvarDblCapacity.DataType = DbType.Int32;
				colvarDblCapacity.MaxLength = 0;
				colvarDblCapacity.AutoIncrement = false;
				colvarDblCapacity.IsNullable = true;
				colvarDblCapacity.IsPrimaryKey = false;
				colvarDblCapacity.IsForeignKey = false;
				colvarDblCapacity.IsReadOnly = false;
				colvarDblCapacity.DefaultSetting = @"";
				colvarDblCapacity.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDblCapacity);
				
				TableSchema.TableColumn colvarSDesc = new TableSchema.TableColumn(schema);
				colvarSDesc.ColumnName = "sDesc";
				colvarSDesc.DataType = DbType.String;
				colvarSDesc.MaxLength = 255;
				colvarSDesc.AutoIncrement = false;
				colvarSDesc.IsNullable = true;
				colvarSDesc.IsPrimaryKey = false;
				colvarSDesc.IsForeignKey = false;
				colvarSDesc.IsReadOnly = false;
				colvarSDesc.DefaultSetting = @"";
				colvarSDesc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSDesc);
				
				TableSchema.TableColumn colvarIsUpdate = new TableSchema.TableColumn(schema);
				colvarIsUpdate.ColumnName = "isUpdate";
				colvarIsUpdate.DataType = DbType.Byte;
				colvarIsUpdate.MaxLength = 0;
				colvarIsUpdate.AutoIncrement = false;
				colvarIsUpdate.IsNullable = true;
				colvarIsUpdate.IsPrimaryKey = false;
				colvarIsUpdate.IsForeignKey = false;
				colvarIsUpdate.IsReadOnly = false;
				
						colvarIsUpdate.DefaultSetting = @"((0))";
				colvarIsUpdate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsUpdate);
				
				TableSchema.TableColumn colvarSFolder = new TableSchema.TableColumn(schema);
				colvarSFolder.ColumnName = "sFolder";
				colvarSFolder.DataType = DbType.String;
				colvarSFolder.MaxLength = 255;
				colvarSFolder.AutoIncrement = false;
				colvarSFolder.IsNullable = true;
				colvarSFolder.IsPrimaryKey = false;
				colvarSFolder.IsForeignKey = false;
				colvarSFolder.IsReadOnly = false;
				colvarSFolder.DefaultSetting = @"";
				colvarSFolder.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSFolder);
				
				TableSchema.TableColumn colvarBytConfirmed = new TableSchema.TableColumn(schema);
				colvarBytConfirmed.ColumnName = "bytConfirmed";
				colvarBytConfirmed.DataType = DbType.Byte;
				colvarBytConfirmed.MaxLength = 0;
				colvarBytConfirmed.AutoIncrement = false;
				colvarBytConfirmed.IsNullable = true;
				colvarBytConfirmed.IsPrimaryKey = false;
				colvarBytConfirmed.IsForeignKey = false;
				colvarBytConfirmed.IsReadOnly = false;
				colvarBytConfirmed.DefaultSetting = @"";
				colvarBytConfirmed.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBytConfirmed);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("Sys_Version",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("PkIntID")]
		[Bindable(true)]
		public int PkIntID 
		{
			get { return GetColumnValue<int>(Columns.PkIntID); }
			set { SetColumnValue(Columns.PkIntID, value); }
		}
		  
		[XmlAttribute("SFileName")]
		[Bindable(true)]
		public string SFileName 
		{
			get { return GetColumnValue<string>(Columns.SFileName); }
			set { SetColumnValue(Columns.SFileName, value); }
		}
		  
		[XmlAttribute("SRarFileName")]
		[Bindable(true)]
		public string SRarFileName 
		{
			get { return GetColumnValue<string>(Columns.SRarFileName); }
			set { SetColumnValue(Columns.SRarFileName, value); }
		}
		  
		[XmlAttribute("ObjData")]
		[Bindable(true)]
		public byte[] ObjData 
		{
			get { return GetColumnValue<byte[]>(Columns.ObjData); }
			set { SetColumnValue(Columns.ObjData, value); }
		}
		  
		[XmlAttribute("SVersion")]
		[Bindable(true)]
		public string SVersion 
		{
			get { return GetColumnValue<string>(Columns.SVersion); }
			set { SetColumnValue(Columns.SVersion, value); }
		}
		  
		[XmlAttribute("IntRar")]
		[Bindable(true)]
		public short? IntRar 
		{
			get { return GetColumnValue<short?>(Columns.IntRar); }
			set { SetColumnValue(Columns.IntRar, value); }
		}
		  
		[XmlAttribute("IntPatch")]
		[Bindable(true)]
		public short? IntPatch 
		{
			get { return GetColumnValue<short?>(Columns.IntPatch); }
			set { SetColumnValue(Columns.IntPatch, value); }
		}
		  
		[XmlAttribute("TUpdatedDate")]
		[Bindable(true)]
		public DateTime? TUpdatedDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.TUpdatedDate); }
			set { SetColumnValue(Columns.TUpdatedDate, value); }
		}
		  
		[XmlAttribute("DblCapacity")]
		[Bindable(true)]
		public int? DblCapacity 
		{
			get { return GetColumnValue<int?>(Columns.DblCapacity); }
			set { SetColumnValue(Columns.DblCapacity, value); }
		}
		  
		[XmlAttribute("SDesc")]
		[Bindable(true)]
		public string SDesc 
		{
			get { return GetColumnValue<string>(Columns.SDesc); }
			set { SetColumnValue(Columns.SDesc, value); }
		}
		  
		[XmlAttribute("IsUpdate")]
		[Bindable(true)]
		public byte? IsUpdate 
		{
			get { return GetColumnValue<byte?>(Columns.IsUpdate); }
			set { SetColumnValue(Columns.IsUpdate, value); }
		}
		  
		[XmlAttribute("SFolder")]
		[Bindable(true)]
		public string SFolder 
		{
			get { return GetColumnValue<string>(Columns.SFolder); }
			set { SetColumnValue(Columns.SFolder, value); }
		}
		  
		[XmlAttribute("BytConfirmed")]
		[Bindable(true)]
		public byte? BytConfirmed 
		{
			get { return GetColumnValue<byte?>(Columns.BytConfirmed); }
			set { SetColumnValue(Columns.BytConfirmed, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSFileName,string varSRarFileName,byte[] varObjData,string varSVersion,short? varIntRar,short? varIntPatch,DateTime? varTUpdatedDate,int? varDblCapacity,string varSDesc,byte? varIsUpdate,string varSFolder,byte? varBytConfirmed)
		{
			SysVersion item = new SysVersion();
			
			item.SFileName = varSFileName;
			
			item.SRarFileName = varSRarFileName;
			
			item.ObjData = varObjData;
			
			item.SVersion = varSVersion;
			
			item.IntRar = varIntRar;
			
			item.IntPatch = varIntPatch;
			
			item.TUpdatedDate = varTUpdatedDate;
			
			item.DblCapacity = varDblCapacity;
			
			item.SDesc = varSDesc;
			
			item.IsUpdate = varIsUpdate;
			
			item.SFolder = varSFolder;
			
			item.BytConfirmed = varBytConfirmed;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varPkIntID,string varSFileName,string varSRarFileName,byte[] varObjData,string varSVersion,short? varIntRar,short? varIntPatch,DateTime? varTUpdatedDate,int? varDblCapacity,string varSDesc,byte? varIsUpdate,string varSFolder,byte? varBytConfirmed)
		{
			SysVersion item = new SysVersion();
			
				item.PkIntID = varPkIntID;
			
				item.SFileName = varSFileName;
			
				item.SRarFileName = varSRarFileName;
			
				item.ObjData = varObjData;
			
				item.SVersion = varSVersion;
			
				item.IntRar = varIntRar;
			
				item.IntPatch = varIntPatch;
			
				item.TUpdatedDate = varTUpdatedDate;
			
				item.DblCapacity = varDblCapacity;
			
				item.SDesc = varSDesc;
			
				item.IsUpdate = varIsUpdate;
			
				item.SFolder = varSFolder;
			
				item.BytConfirmed = varBytConfirmed;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PkIntIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SFileNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SRarFileNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ObjDataColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SVersionColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IntRarColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IntPatchColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TUpdatedDateColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn DblCapacityColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn SDescColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IsUpdateColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SFolderColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn BytConfirmedColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string PkIntID = @"PK_intID";
			 public static string SFileName = @"sFileName";
			 public static string SRarFileName = @"sRarFileName";
			 public static string ObjData = @"objData";
			 public static string SVersion = @"sVersion";
			 public static string IntRar = @"intRar";
			 public static string IntPatch = @"intPatch";
			 public static string TUpdatedDate = @"tUpdatedDate";
			 public static string DblCapacity = @"dblCapacity";
			 public static string SDesc = @"sDesc";
			 public static string IsUpdate = @"isUpdate";
			 public static string SFolder = @"sFolder";
			 public static string BytConfirmed = @"bytConfirmed";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
