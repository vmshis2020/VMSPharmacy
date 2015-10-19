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
    /// Controller class for qhe_nhanvien_quyensudung
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class QheNhanvienQuyensudungController
    {
        // Preload our schema..
        QheNhanvienQuyensudung thisSchemaLoad = new QheNhanvienQuyensudung();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public QheNhanvienQuyensudungCollection FetchAll()
        {
            QheNhanvienQuyensudungCollection coll = new QheNhanvienQuyensudungCollection();
            Query qry = new Query(QheNhanvienQuyensudung.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public QheNhanvienQuyensudungCollection FetchByID(object IdNhanvien)
        {
            QheNhanvienQuyensudungCollection coll = new QheNhanvienQuyensudungCollection().Where("id_nhanvien", IdNhanvien).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public QheNhanvienQuyensudungCollection FetchByQuery(Query qry)
        {
            QheNhanvienQuyensudungCollection coll = new QheNhanvienQuyensudungCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdNhanvien)
        {
            return (QheNhanvienQuyensudung.Delete(IdNhanvien) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdNhanvien)
        {
            return (QheNhanvienQuyensudung.Destroy(IdNhanvien) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(short IdNhanvien,string Ma,string Loai)
        {
            Query qry = new Query(QheNhanvienQuyensudung.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("IdNhanvien", IdNhanvien).AND("Ma", Ma).AND("Loai", Loai);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(short IdNhanvien,string Ma,string Loai)
	    {
		    QheNhanvienQuyensudung item = new QheNhanvienQuyensudung();
		    
            item.IdNhanvien = IdNhanvien;
            
            item.Ma = Ma;
            
            item.Loai = Loai;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(short IdNhanvien,string Ma,string Loai)
	    {
		    QheNhanvienQuyensudung item = new QheNhanvienQuyensudung();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdNhanvien = IdNhanvien;
				
			item.Ma = Ma;
				
			item.Loai = Loai;
				
	        item.Save(UserName);
	    }
    }
}