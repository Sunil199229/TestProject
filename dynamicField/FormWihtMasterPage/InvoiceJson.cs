using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace dynamicField.FormWihtMasterPage
{
    public class InvoiceJson
    {

    }

    public class PL_GenInvoice
    {
        //Required(ErrorMessage = "Version is required")]
        public string Version { get; set; }
        //[Required(ErrorMessage = "TranDtls is required")]
        public int UserCode { get; set; }
        //[Required(ErrorMessage = "Password id required")]
        public string Password { get; set; }
        public TranDtls TranDtls { get; set; }
        //[Required(ErrorMessage = "DocDtls id required")]
        public DocDtls DocDtls { get; set; }
        //[Required(ErrorMessage = "SellerDtls id required")]
        public SellerDtls SellerDtls { get; set; }
        //[Required(ErrorMessage = "BuyerDtls id required")]
        public BuyerDtls BuyerDtls { get; set; }
        //[Required(ErrorMessage = "ItemList id required")]
        public DataTable ItemList { get; set; }
        //[Required(ErrorMessage = "ValDtls id required")]
        public ValDtls ValDtls { get; set; }
        //[Required(ErrorMessage = "PayDtls id required")]
        public PayDtls PayDtls { get; set; }
        //[Required(ErrorMessage = "EwbDtls id required")]
        public EwbDtls EwbDtls { get; set; }
        //[Required(ErrorMessage = "UserCode id required")]



    }
    public class IRNReqParams
    {
        //  [Required(ErrorMessage = "Version is required")]
        public string Version { get; set; }
        // [Required(ErrorMessage = "TranDtls is required")]
        public TranDtls TranDtls { get; set; }
        //  [Required(ErrorMessage = "DocDtls id required")]
        public DocDtls DocDtls { get; set; }
        // [Required(ErrorMessage = "SellerDtls id required")]
        public SellerDtls SellerDtls { get; set; }
        // [Required(ErrorMessage = "BuyerDtls id required")]
        public BuyerDtls BuyerDtls { get; set; }
        //  [Required(ErrorMessage = "ItemList id required")]
        public List<ItemList> ItemList { get; set; }
        //   [Required(ErrorMessage = "ValDtls id required")]
        public ValDtls ValDtls { get; set; }
        //[Required(ErrorMessage = "PayDtls id required")]
        public PayDtls PayDtls { get; set; }
        //  [Required(ErrorMessage = "EwbDtls id required")]
        public EwbDtls EwbDtls { get; set; }
        //  [Required(ErrorMessage = "UserCode id required")]
        public int UserCode { get; set; }
        //  [Required(ErrorMessage = "Password id required")]
        public string Password { get; set; }
    }
    public class TranDtls
    {
        //  [Required(ErrorMessage = "TaxSch id required")]
        public string TaxSch { get; set; }
        //     [Required(ErrorMessage = "SupTyp id required")]
        public string SupTyp { get; set; }
        public string RegRev { get; set; }
        public string EcmGstin { get; set; }
        public string IgstOnIntra { get; set; }

    }
    public class DocDtls
    {
        // [Required(ErrorMessage ="Typ is required")]
        public string Typ { get; set; }
        //   [Required(ErrorMessage = "No is required")]
        public string No { get; set; }
        //  [Required(ErrorMessage = "Dt is required")]
        public string Dt { get; set; }

    }
    public class SellerDtls
    {
        //  [Required(ErrorMessage = "Gstin is required")]
        public string Gstin { get; set; }
        //  [Required(ErrorMessage = "LglNm is required")]
        public string LglNm { get; set; }
        public string TrdNm { get; set; }
        //  [Required(ErrorMessage = "Addr1 is required")]
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        //  [Required(ErrorMessage = "Loc is required")]
        public string Loc { get; set; }
        //  [Required(ErrorMessage = "Pin is required")]
        public int Pin { get; set; }
        // [Required(ErrorMessage = "Stcd is required")]
        public string Stcd { get; set; }
        public string Ph { get; set; }
        public string Em { get; set; }
    }
    public class BuyerDtls
    {
        //  [Required(ErrorMessage = "Gstin is required")]
        public string Gstin { get; set; }
        //  [Required(ErrorMessage = "LglNm is required")]
        public string LglNm { get; set; }
        public string TrdNm { get; set; }
        //   [Required(ErrorMessage = "Pos is required")]
        public string Pos { get; set; }
        //  [Required(ErrorMessage = "Addr1 is required")]
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        //   [Required(ErrorMessage = "Loc is required")]
        public string Loc { get; set; }
        //[Required(ErrorMessage = "Pin is required")]
        public int Pin { get; set; }
        // [Required(ErrorMessage = "Stcd is required")]
        public string Stcd { get; set; }
        public string Ph { get; set; }
        public string Em { get; set; }
    }
    public class ItemList
    {
        //  [Required(ErrorMessage = "SlNo is required")]
        public string SlNo { get; set; }
        public string PrdDesc { get; set; }
        //[Required(ErrorMessage = "IsServc is required")]
        public string IsServc { get; set; }
        //  [Required(ErrorMessage = "HsnCd is required")]
        public string HsnCd { get; set; }
        public string Barcde { get; set; }
        public decimal Qty { get; set; }
        public int FreeQty { get; set; }
        public string Unit { get; set; }
        //  [Required(ErrorMessage = "UnitPrice is required")]
        public decimal UnitPrice { get; set; }
        //  [Required(ErrorMessage = "TotAmt is required")]
        public decimal TotAmt { get; set; }
        public decimal Discount { get; set; }
        public decimal PreTaxVal { get; set; }
        //  [Required(ErrorMessage = "AssAmt is required")]
        public decimal AssAmt { get; set; }
        //   [Required(ErrorMessage = "GstRt is required")]
        public decimal GstRt { get; set; }
        public decimal IgstAmt { get; set; }
        public decimal CgstAmt { get; set; }
        public decimal SgstAmt { get; set; }
        public decimal CesRt { get; set; }
        public decimal CesAmt { get; set; }
        public decimal CesNonAdvlAmt { get; set; }
        public decimal StateCesRt { get; set; }
        public decimal StateCesAmt { get; set; }
        public decimal StateCesNonAdvlAmt { get; set; }
        public decimal OthChrg { get; set; }
        // [Required(ErrorMessage = "TotItemVal is required")]
        public decimal TotItemVal { get; set; }
        public string OrdLineRef { get; set; }
        public string OrgCntry { get; set; }
        public string PrdSlNo { get; set; }
    }
    public class ValDtls
    {

        public decimal AssVal { get; set; }
        public decimal CgstVal { get; set; }
        public decimal SgstVal { get; set; }
        public decimal IgstVal { get; set; }
        public decimal CesVal { get; set; }
        public decimal StCesVal { get; set; }
        public decimal Discount { get; set; }
        public decimal OthChrg { get; set; }
        public decimal RndOffAmt { get; set; }
        public decimal TotInvVal { get; set; }
        public decimal TotInvValFc { get; set; }
    }
    public class PayDtls
    {
        public string Nm { get; set; }
        public string AccDet { get; set; }
        public string Mode { get; set; }
        public string FinInsBr { get; set; }
        public string PayTerm { get; set; }
        public string PayInstr { get; set; }
        public string CrTrn { get; set; }
        public string DirDr { get; set; }
        public decimal CrDay { get; set; }
        public decimal PaidAmt { get; set; }
        public decimal PaymtDue { get; set; }
    }
    public class EwbDtls
    {
        public string TransId { get; set; }
        public string TransName { get; set; }
        public int Distance { get; set; }
        public string TransDocNo { get; set; }
        public string TransDocDt { get; set; }
        public string VehNo { get; set; }
        public string VehType { get; set; }
        public string TransMode { get; set; }
    }
    public class Response1
    {
        public int StatusCode { get; set; }
        public string Msg { get; set; }
        public object data { get; set; }
    }

}