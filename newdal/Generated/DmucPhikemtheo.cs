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
	/// Strongly-typed collection for the DmucPhikemtheo class.
	/// </summary>
    [Serializable]
	public partial class DmucPhikemtheoCollection : ActiveList<DmucPhikemtheo, DmucPhikemtheoCollection>
	{	   
		public DmucPhikemtheoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>DmucPhikemtheoCollection</returns>
		public DmucPhikemtheoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                DmucPhikemtheo o = this[i];
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
	/// This is an ActiveRecord class which wraps the dmuc_phikemtheo table.
	/// </summary>
	[Serializable]
	public partial class DmucPhikemtheo : ActiveRecord<DmucPhikemtheo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public DmucPhikemtheo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public DmucPhikemtheo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public DmucPhikemtheo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public DmucPhikemtheo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("dmuc_phikemtheo", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdKhoakcb = new TableSchema.TableColumn(schema);
				colvarIdKhoakcb.ColumnName = "id_khoakcb";
				colvarIdKhoakcb.DataType = DbType.Int16;
				colvarIdKhoakcb.MaxLength = 0;
				colvarIdKhoakcb.AutoIncrement = false;
				colvarIdKhoakcb.IsNullable = false;
				colvarIdKhoakcb.IsPrimaryKey = true;
				colvarIdKhoakcb.IsForeignKey = false;
				colvarIdKhoakcb.IsReadOnly = false;
				colvarIdKhoakcb.DefaultSetting = @"";
				colvarIdKhoakcb.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdKhoakcb);
				
				TableSchema.TableColumn colvarIdPhikemtheo = new TableSchema.TableColumn(schema);
				colvarIdPhikemtheo.ColumnName = "id_phikemtheo";
				colvarIdPhikemtheo.DataType = DbType.Int32;
				colvarIdPhikemtheo.MaxLength = 0;
				colvarIdPhikemtheo.AutoIncrement = false;
				colvarIdPhikemtheo.IsNullable = false;
				colvarIdPhikemtheo.IsPrimaryKey = true;
				colvarIdPhikemtheo.IsForeignKey = false;
				colvarIdPhikemtheo.IsReadOnly = false;
				colvarIdPhikemtheo.DefaultSetting = @"";
				colvarIdPhikemtheo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhikemtheo);
				
				TableSchema.TableColumn colvarIdPhikemtheongoaigio = new TableSchema.TableColumn(schema);
				colvarIdPhikemtheongoaigio.ColumnName = "id_phikemtheongoaigio";
				colvarIdPhikemtheongoaigio.DataType = DbType.Int32;
				colvarIdPhikemtheongoaigio.MaxLength = 0;
				colvarIdPhikemtheongoaigio.AutoIncrement = false;
				colvarIdPhikemtheongoaigio.IsNullable = false;
				colvarIdPhikemtheongoaigio.IsPrimaryKey = true;
				colvarIdPhikemtheongoaigio.IsForeignKey = false;
				colvarIdPhikemtheongoaigio.IsReadOnly = false;
				colvarIdPhikemtheongoaigio.DefaultSetting = @"";
				colvarIdPhikemtheongoaigio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhikemtheongoaigio);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("dmuc_phikemtheo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdKhoakcb")]
		[Bindable(true)]
		public short IdKhoakcb 
		{
			get { return GetColumnValue<short>(Columns.IdKhoakcb); }
			set { SetColumnValue(Columns.IdKhoakcb, value); }
		}
		  
		[XmlAttribute("IdPhikemtheo")]
		[Bindable(true)]
		public int IdPhikemtheo 
		{
			get { return GetColumnValue<int>(Columns.IdPhikemtheo); }
			set { SetColumnValue(Columns.IdPhikemtheo, value); }
		}
		  
		[XmlAttribute("IdPhikemtheongoaigio")]
		[Bindable(true)]
		public int IdPhikemtheongoaigio 
		{
			get { return GetColumnValue<int>(Columns.IdPhikemtheongoaigio); }
			set { SetColumnValue(Columns.IdPhikemtheongoaigio, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(short varIdKhoakcb,int varIdPhikemtheo,int varIdPhikemtheongoaigio)
		{
			DmucPhikemtheo item = new DmucPhikemtheo();
			
			item.IdKhoakcb = varIdKhoakcb;
			
			item.IdPhikemtheo = varIdPhikemtheo;
			
			item.IdPhikemtheongoaigio = varIdPhikemtheongoaigio;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(short varIdKhoakcb,int varIdPhikemtheo,int varIdPhikemtheongoaigio)
		{
			DmucPhikemtheo item = new DmucPhikemtheo();
			
				item.IdKhoakcb = varIdKhoakcb;
			
				item.IdPhikemtheo = varIdPhikemtheo;
			
				item.IdPhikemtheongoaigio = varIdPhikemtheongoaigio;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdKhoakcbColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPhikemtheoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPhikemtheongoaigioColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdKhoakcb = @"id_khoakcb";
			 public static string IdPhikemtheo = @"id_phikemtheo";
			 public static string IdPhikemtheongoaigio = @"id_phikemtheongoaigio";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}