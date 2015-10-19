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
    /// Controller class for t_phieu_capphat_chitiet
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TPhieuCapphatChitietController
    {
        // Preload our schema..
        TPhieuCapphatChitiet thisSchemaLoad = new TPhieuCapphatChitiet();
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
        public TPhieuCapphatChitietCollection FetchAll()
        {
            TPhieuCapphatChitietCollection coll = new TPhieuCapphatChitietCollection();
            Query qry = new Query(TPhieuCapphatChitiet.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TPhieuCapphatChitietCollection FetchByID(object IdChitiet)
        {
            TPhieuCapphatChitietCollection coll = new TPhieuCapphatChitietCollection().Where("id_chitiet", IdChitiet).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TPhieuCapphatChitietCollection FetchByQuery(Query qry)
        {
            TPhieuCapphatChitietCollection coll = new TPhieuCapphatChitietCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdChitiet)
        {
            return (TPhieuCapphatChitiet.Delete(IdChitiet) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdChitiet)
        {
            return (TPhieuCapphatChitiet.Destroy(IdChitiet) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdCapphat,int IdDonthuoc,int IdChitietdonthuoc,DateTime? NgayKedon,long? IdBenhnhan,string MaLuotkham,short? DaLinh,int SoLuong,int? ThucLinh,int? SoLuongtralai,int IdThuoc,int IdKho,long? IdThuockho,long? IdPhieuxuatthuocBenhnhan,string NguoiSua,DateTime? NgaySua,long? IdPhieutralai,byte? TrangthaiTralai)
	    {
		    TPhieuCapphatChitiet item = new TPhieuCapphatChitiet();
		    
            item.IdCapphat = IdCapphat;
            
            item.IdDonthuoc = IdDonthuoc;
            
            item.IdChitietdonthuoc = IdChitietdonthuoc;
            
            item.NgayKedon = NgayKedon;
            
            item.IdBenhnhan = IdBenhnhan;
            
            item.MaLuotkham = MaLuotkham;
            
            item.DaLinh = DaLinh;
            
            item.SoLuong = SoLuong;
            
            item.ThucLinh = ThucLinh;
            
            item.SoLuongtralai = SoLuongtralai;
            
            item.IdThuoc = IdThuoc;
            
            item.IdKho = IdKho;
            
            item.IdThuockho = IdThuockho;
            
            item.IdPhieuxuatthuocBenhnhan = IdPhieuxuatthuocBenhnhan;
            
            item.NguoiSua = NguoiSua;
            
            item.NgaySua = NgaySua;
            
            item.IdPhieutralai = IdPhieutralai;
            
            item.TrangthaiTralai = TrangthaiTralai;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(long IdChitiet,int IdCapphat,int IdDonthuoc,int IdChitietdonthuoc,DateTime? NgayKedon,long? IdBenhnhan,string MaLuotkham,short? DaLinh,int SoLuong,int? ThucLinh,int? SoLuongtralai,int IdThuoc,int IdKho,long? IdThuockho,long? IdPhieuxuatthuocBenhnhan,string NguoiSua,DateTime? NgaySua,long? IdPhieutralai,byte? TrangthaiTralai)
	    {
		    TPhieuCapphatChitiet item = new TPhieuCapphatChitiet();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdChitiet = IdChitiet;
				
			item.IdCapphat = IdCapphat;
				
			item.IdDonthuoc = IdDonthuoc;
				
			item.IdChitietdonthuoc = IdChitietdonthuoc;
				
			item.NgayKedon = NgayKedon;
				
			item.IdBenhnhan = IdBenhnhan;
				
			item.MaLuotkham = MaLuotkham;
				
			item.DaLinh = DaLinh;
				
			item.SoLuong = SoLuong;
				
			item.ThucLinh = ThucLinh;
				
			item.SoLuongtralai = SoLuongtralai;
				
			item.IdThuoc = IdThuoc;
				
			item.IdKho = IdKho;
				
			item.IdThuockho = IdThuockho;
				
			item.IdPhieuxuatthuocBenhnhan = IdPhieuxuatthuocBenhnhan;
				
			item.NguoiSua = NguoiSua;
				
			item.NgaySua = NgaySua;
				
			item.IdPhieutralai = IdPhieutralai;
				
			item.TrangthaiTralai = TrangthaiTralai;
				
	        item.Save(UserName);
	    }
    }
}