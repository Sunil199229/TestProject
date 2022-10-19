using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace dynamicField.FormWihtMasterPage
{
    public partial class apicall : System.Web.UI.Page
    {
        InvoiceJson ObjSaleModel = new InvoiceJson();
        SqlCommand cmd;
        DataSet ds;
        SqlConnection con;
        SqlConnection conCollection;
        SqlDataAdapter sda;
        Response1 res1 = new Response1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DataTable dtItemSchema()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("SlNo", typeof(string));
            dt.Columns.Add("PrdDesc", typeof(string));
            dt.Columns.Add("IsServc", typeof(string));
            dt.Columns.Add("HsnCd", typeof(string));
            dt.Columns.Add("Barcde", typeof(string));
            dt.Columns.Add("Qty", typeof(string));
            dt.Columns.Add("FreeQty", typeof(string));
            dt.Columns.Add("Unit", typeof(string));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("TotAmt", typeof(decimal));
            dt.Columns.Add("Discount", typeof(decimal));
            dt.Columns.Add("PreTaxVal", typeof(decimal));
            dt.Columns.Add("AssAmt", typeof(decimal));
            dt.Columns.Add("GstRt", typeof(decimal));
            dt.Columns.Add("IgstAmt", typeof(decimal));
            dt.Columns.Add("CgstAmt", typeof(decimal));
            dt.Columns.Add("SgstAmt", typeof(decimal));
            dt.Columns.Add("CesRt", typeof(decimal));
            dt.Columns.Add("CesAmt", typeof(decimal));
            dt.Columns.Add("CesNonAdvlAmt", typeof(decimal));
            dt.Columns.Add("StateCesRt", typeof(decimal));
            dt.Columns.Add("StateCesAmt", typeof(decimal));
            dt.Columns.Add("StateCesNonAdvlAmt", typeof(decimal));
            dt.Columns.Add("OthChrg", typeof(decimal));
            dt.Columns.Add("TotItemVal", typeof(decimal));
            dt.Columns.Add("OrdLineRef", typeof(string));
            dt.Columns.Add("OrgCntry", typeof(string));
            dt.Columns.Add("PrdSlNo", typeof(string));
            return dt;
        }
        protected void btnJsonConvert_Click(object sender, EventArgs e)
        {

            Response resp = new Response();
            PL_GenInvoice plinvoice = new PL_GenInvoice();
            DocDtls DocDtlsobj = new DocDtls();
            TranDtls TranDtlsobj = new TranDtls();
            SellerDtls SellerDtlsobj = new SellerDtls();
            BuyerDtls BuyerDtlsobj = new BuyerDtls();
            ItemList ItemListobj = new ItemList();
            ValDtls ValDtlsobj = new ValDtls();
            PayDtls PayDtlsobj = new PayDtls();
            EwbDtls EwbDtlsobj = new EwbDtls();
            List<ItemList> lstItemList = new List<ItemList>();

            DataTable dt = new DataTable();
            try
            {
                //con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
                //cmd = new SqlCommand("SPRPTSalesCallWindoeservice", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@ind", 1);
                //cmd.Parameters.AddWithValue("@OrgID", 1);
                //cmd.Parameters.AddWithValue("@BrID", 1);
                //cmd.Parameters.AddWithValue("@yrcode", 22);
                //cmd.Parameters.AddWithValue("@Doctype", 6);
                //cmd.Parameters.AddWithValue("@invoiceno", 0);
                //cmd.Parameters.AddWithValue("@cashsalesind", 0);
                //cmd.Parameters.AddWithValue("@VNo", 0);
                //cmd.Parameters.AddWithValue("@invoiceDate", "2021/05/01");
                //cmd.Parameters.AddWithValue("@invoiceDateFrom", "2021/04/01");
                //cmd.Parameters.AddWithValue("@invoiceDateto", "2021/12/31");
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                //cmd.Connection = con;
                //sda = new SqlDataAdapter(cmd);
                //sda.Fill(dt);
                //if (dt.Rows.Count > 0)
                {
                    //string str = JsonConvert.SerializeObject(dt);
                    plinvoice.Version = "1.01";
                    plinvoice.UserCode = 1001;//Convert.ToInt16(ConfigurationManager.AppSettings["EinvUserCode"]);
                    plinvoice.Password = "12345"; //ConfigurationManager.AppSettings["EinvPass"].ToString();
                    {
                        TranDtlsobj.TaxSch = "GST";//dt.Rows[0][""].ToString();
                        TranDtlsobj.SupTyp = "B2B";//dt.Rows[0][""].ToString();
                        TranDtlsobj.RegRev = "Y";//dt.Rows[0][""].ToString();
                        TranDtlsobj.EcmGstin = null;//ds.Tables[0].Rows[0]["EcmGstin"].ToString();
                        TranDtlsobj.IgstOnIntra = "N";//dt.Rows[0][""].ToString();
                    }
                    plinvoice.TranDtls = TranDtlsobj;
                    {
                        DateTime DOB = Convert.ToDateTime("01/01/2022");//Convert.ToDateTime(dt.Rows[0]["VoucharDate"])
                        DocDtlsobj.Typ = "INV";//dt.Rows[0][0].ToString();
                        DocDtlsobj.No = "1001"; //dt.Rows[0]["VoucharNo"].ToString()
                        DocDtlsobj.Dt = "01/01/2022"; //DOB.ToString("dd/MM/yyyy").Replace("-", "/")
                    }
                    plinvoice.DocDtls = DocDtlsobj;
                    {
                        SellerDtlsobj.Gstin = "24AAKCM3927B1ZQ";
                        SellerDtlsobj.LglNm = "NICcompanypvtltd";
                        SellerDtlsobj.TrdNm = "NICIndustries";
                        SellerDtlsobj.Addr1 = "5thblock,kuvempulayout";
                        SellerDtlsobj.Addr2 = "kuvempulayout";
                        SellerDtlsobj.Loc = "GANDHINAGAR";
                        SellerDtlsobj.Pin = 383315;
                        SellerDtlsobj.Stcd = "24";
                        SellerDtlsobj.Ph = "9000000000";
                        SellerDtlsobj.Em = "abc@gmail.com";



                        //     SellerDtlsobj.Gstin = dt.Rows[0]["CompanyGSTIN"].ToString();
                        //     SellerDtlsobj.LglNm = dt.Rows[0]["CompanyName"].ToString();
                        //     SellerDtlsobj.TrdNm = "null";//dt.Rows[0]["CompanyName"].ToString();
                        //     SellerDtlsobj.Addr1 = dt.Rows[0]["branchadd"].ToString();
                        //     SellerDtlsobj.Addr2 = "null";// dt.Rows[0][""].ToString();
                        //     SellerDtlsobj.Loc = dt.Rows[0]["branchcity"].ToString();
                        //     SellerDtlsobj.Pin = 452001; // Convert.ToInt32(dt.Rows[0][0].ToString());
                        //     SellerDtlsobj.Stcd = dt.Rows[0]["SalesToGSTIN"].ToString().Remove(2);
                        //     SellerDtlsobj.Ph = "900000000";  //dt.Rows[0][0].ToString();
                        //     SellerDtlsobj.Em = "abc@gmail.com";  // dt.Rows[0][""].ToString();
                    }
                    plinvoice.SellerDtls = SellerDtlsobj;
                    {
                        BuyerDtlsobj.Gstin = "29AWGPV7107B1Z1";
                        BuyerDtlsobj.LglNm = "XYZcompanypvtltd";
                        BuyerDtlsobj.TrdNm = "XYZIndustries";
                        BuyerDtlsobj.Addr1 = "7thblock,kuvempulayout";
                        BuyerDtlsobj.Addr2 = "kuvempulayout";
                        BuyerDtlsobj.Pos = "12";
                        BuyerDtlsobj.Loc = "GANDHINAGAR";
                        BuyerDtlsobj.Pin = 562160;
                        BuyerDtlsobj.Stcd = "29";
                        BuyerDtlsobj.Ph = "91111111111";
                        BuyerDtlsobj.Em = "xyz@yahoo.com";



                        //var stateCd = dt.Rows[0]["SalesToGSTIN"].ToString().Remove(2);
                        //BuyerDtlsobj.Gstin = dt.Rows[0]["SalesToGSTIN"].ToString();
                        //BuyerDtlsobj.LglNm = dt.Rows[0]["SalestoName"].ToString();
                        //BuyerDtlsobj.TrdNm = "null";//dt.Rows[0]["SalestoName"].ToString();
                        //BuyerDtlsobj.Addr1 = dt.Rows[0]["SalestoADDRESS"].ToString();
                        //BuyerDtlsobj.Addr2 = "null";// dt.Rows[0][""].ToString();
                        //BuyerDtlsobj.Pos = "12";//dt.Rows[0]["SalestocITY"].ToString();
                        //BuyerDtlsobj.Loc = dt.Rows[0]["SalestocITY"].ToString();
                        //BuyerDtlsobj.Pin = 452001;// Convert.ToInt32(dt.Rows[0]["SalestoPIN"].ToString());
                        //BuyerDtlsobj.Stcd = stateCd;
                        //BuyerDtlsobj.Ph = "9111111111"; //dt.Rows[0]["Ph"].ToString() == "" ? null : dsdetail.Tables[3].Rows[0]["Ph"].ToString();
                        //BuyerDtlsobj.Em = "Abc@gmail.com"; //dt.Rows[0]["Em"].ToString() == "" ? null : dsdetail.Tables[3].Rows[0]["Em"].ToString();
                    }
                    plinvoice.BuyerDtls = BuyerDtlsobj;
                    DataTable dtItem = dtItemSchema();
                    DataRow dr = dtItem.NewRow();

                    dr["SlNo"] = "1";
                    dr["PrdDesc"] = "Rice";
                    dr["IsServc"] = "N";
                    dr["HsnCd"] = "841510";
                    dr["Barcde"] = "123456";
                    dr["Qty"] = 100.345;
                    dr["FreeQty"] = 10;
                    dr["Unit"] = "BAG";
                    dr["UnitPrice"] = 99.545;
                    dr["TotAmt"] = 9988.84;
                    dr["Discount"] = 10;
                    dr["PreTaxVal"] = 1;
                    dr["AssAmt"] = 9978.84;
                    dr["GstRt"] = 12.0;
                    dr["IgstAmt"] = 1197.46;
                    dr["CgstAmt"] = 0;
                    dr["SgstAmt"] = 0;
                    dr["CesRt"] = 5;
                    dr["CesAmt"] = 498.94;
                    dr["CesNonAdvlAmt"] = 10;
                    dr["StateCesRt"] = 12;
                    dr["StateCesAmt"] = 1197.46;
                    dr["StateCesNonAdvlAmt"] = 5;
                    dr["OthChrg"] = 10;
                    dr["TotItemVal"] = 12897.7;
                    dr["OrdLineRef"] = "3256";
                    dr["OrgCntry"] = "AG";
                    dr["PrdSlNo"] = "12345";
                    dtItem.Rows.Add(dr);





                    //   int SrNO = 1;
                    //   for (int i = 0; i < dt.Rows.Count; i++)
                    //   {
                    //       DataRow dr = dtItem.NewRow();
                    //       dr["SlNo"] = SrNO;
                    //       dr["PrdDesc"] = dt.Rows[0]["ItemDescription"].ToString();
                    //       if (dt.Rows[0]["GoodsServiceInd"].ToString() == "1")
                    //       {
                    //           ItemListobj.IsServc = "Y";
                    //           dr["IsServc"] = "Y";
                    //       }
                    //       else
                    //       {
                    //           ItemListobj.IsServc = "N";
                    //           dr["IsServc"] = "N";
                    //       }
                    //       dr["HsnCd"] =   dt.Rows[0]["HSNSACNO"].ToString();
                    //       dr["Barcde"] = "null";// dt.Rows[0][""].ToString();
                    //       dr["Qty"] =     dt.Rows[0]["ItemQty"].ToString();
                    //       dr["FreeQty"] = dt.Rows[0]["FreeQty"].ToString();
                    //       dr["Unit"] =    "null";   //dt.Rows[0]["ItemUnitID"].ToString();
                    //       dr["UnitPrice"]= dt.Rows[0]["ItemRate"].ToString();
                    //       dr["TotAmt"] =    dt.Rows[0]["TaxableAmount"].ToString();
                    //       dr["Discount"] =  dt.Rows[0]["ItemDiscountValue"].ToString();
                    //       dr["PreTaxVal"] = dt.Rows[0]["ItemDiscountType"].ToString();
                    //       dr["AssAmt"] =    dt.Rows[0]["TaxableAmount"].ToString();
                    //       int TotalGst = 0;
                    //       int IgstVal = Convert.ToInt32(dt.Rows[0]["IGSTTaxRate"]);
                    //       if (IgstVal > 0)
                    //       {
                    //           dr["GstRt"] = Convert.ToInt32(dt.Rows[0]["IGSTTaxRate"].ToString());
                    //
                    //       }
                    //       else
                    //       {
                    //           TotalGst = Convert.ToInt32(dt.Rows[0]["SGSTTaxRate"]) + Convert.ToInt32(dt.Rows[0]["CGSTTaxRate"]);
                    //           dr["GstRt"] = TotalGst;
                    //       }
                    //
                    //    
                    //       if (TotalGst==0)
                    //       dr["IgstAmt"] =dt.Rows[0]["IGSTTaxAmount"].ToString();
                    //       else { 
                    //       dr["CgstAmt"] =dt.Rows[0]["CGSTTaxAmount"].ToString();
                    //       dr["SgstAmt"] =dt.Rows[0]["SGSTTaxAmount"].ToString();
                    //       }
                    //       dr["CesRt"] =   0 ;             
                    //       dr["CesAmt"] =   0  ;           
                    //       dr["CesNonAdvlAmt"] =0 ;        
                    //       dr["StateCesRt"] = 0  ;         
                    //       dr["StateCesAmt"] =  0  ;       
                    //       dr["StateCesNonAdvlAmt"] = 0 ;  
                    //       dr["OthChrg"] = 0;              
                    //       dr["TotItemVal"] = Convert.ToInt32(dt.Rows[0]["TaxableAmount"]) + Convert.ToInt32(dt.Rows[0]["SGSTTaxAmount"]) + Convert.ToInt32(dt.Rows[0]["CGSTTaxAmount"]);
                    //       dr["OrdLineRef"] = "0";    
                    //       dr["OrgCntry"] = "null";   
                    //       dr["PrdSlNo"] = 0;         
                    //       dtItem.Rows.Add(dr);
                    //       SrNO++;
                    //   }
                    if (dtItem.Rows.Count > 0)
                        plinvoice.ItemList = dtItem;
                    else
                        plinvoice.ItemList = dtItemSchema();
                    {
                        ValDtlsobj.AssVal = Convert.ToDecimal(9978.84);
                        ValDtlsobj.CgstVal = 0;
                        ValDtlsobj.SgstVal = 0;
                        ValDtlsobj.IgstVal = Convert.ToDecimal(1197.46);
                        ValDtlsobj.CesVal = Convert.ToDecimal(508.94);
                        ValDtlsobj.StCesVal = Convert.ToDecimal(1202.46);
                        ValDtlsobj.Discount = 10;
                        ValDtlsobj.OthChrg = 20;
                        ValDtlsobj.RndOffAmt = Convert.ToDecimal(0.3);
                        ValDtlsobj.TotInvVal = 12908;
                        ValDtlsobj.TotInvValFc = Convert.ToDecimal(12897.7);

                        //    ValDtlsobj.AssVal = 0;//Convert.ToDecimal(dt.Rows[0]["ItemAmount"].ToString());
                        //    ValDtlsobj.CgstVal = 0;// Convert.ToDecimal(dt.Rows[0][0].ToString());
                        //    ValDtlsobj.SgstVal = 0;// Convert.ToDecimal(dt.Rows[0][0].ToString());
                        //    ValDtlsobj.IgstVal = 0;// Convert.ToDecimal(dt.Rows[0]["IGSTTaxAmount"].ToString());
                        //    ValDtlsobj.CesVal = 0;  // Convert.ToDecimal(dt.Rows[0][0].ToString());
                        //    ValDtlsobj.StCesVal = 0;// Convert.ToDecimal(dt.Rows[0]["CESSTaxAmount"].ToString());
                        //    ValDtlsobj.Discount = 0;// Convert.ToDecimal(dt.Rows[0]["ItemDiscountAmount"].ToString());
                        //    ValDtlsobj.OthChrg = 0;// Convert.ToDecimal(dt.Rows[0][0].ToString());
                        //    ValDtlsobj.RndOffAmt = 0;// Convert.ToDecimal(dt.Rows[0]["RoudedOffAmount"].ToString());
                        //    ValDtlsobj.TotInvVal = Convert.ToDecimal(dt.Rows[0]["TaxableAmount"].ToString());
                        //    ValDtlsobj.TotInvValFc = 0;// Convert.ToDecimal(dt.Rows[0][0].ToString());
                    }
                    plinvoice.ValDtls = ValDtlsobj;
                    {
                        PayDtlsobj.Nm = "ABCDE";
                        PayDtlsobj.AccDet = "5697389713210";
                        PayDtlsobj.Mode = "Cash";
                        PayDtlsobj.FinInsBr = "SBIN11000";
                        PayDtlsobj.PayTerm = "100";
                        PayDtlsobj.PayInstr = "Gift";
                        PayDtlsobj.CrTrn = "test";
                        PayDtlsobj.DirDr = "test";
                        PayDtlsobj.CrDay = 100;
                        PayDtlsobj.PaidAmt = 10000;
                        PayDtlsobj.PaymtDue = 5000;


                        // PayDtlsobj.Nm = "null";      
                        // PayDtlsobj.AccDet = "null";  
                        // PayDtlsobj.Mode = "null";    
                        // PayDtlsobj.FinInsBr = "null";
                        // PayDtlsobj.PayTerm = "null"; 
                        // PayDtlsobj.PayInstr = "null";
                        // PayDtlsobj.CrTrn = "null";   
                        // PayDtlsobj.DirDr = "null";   
                        // PayDtlsobj.CrDay = 0;      
                        // PayDtlsobj.PaidAmt = 0;     
                        // PayDtlsobj.PaymtDue = 0;    

                    }
                    plinvoice.PayDtls = PayDtlsobj;
                    {
                        EwbDtlsobj.TransId = "12AWGPV7107B1Z1";
                        EwbDtlsobj.TransName = "XYZEXPORTS";
                        EwbDtlsobj.Distance = 0;
                        EwbDtlsobj.TransDocNo = "DOC01";
                        EwbDtlsobj.TransDocDt = "01/02/2021";
                        EwbDtlsobj.VehNo = "ka123456";
                        EwbDtlsobj.VehType = "R";
                        EwbDtlsobj.TransMode = "1";



                        //EwbDtlsobj.TransId = "null";    
                        //EwbDtlsobj.TransName = "null";  
                        //EwbDtlsobj.Distance = 0;        
                        //EwbDtlsobj.TransDocNo = "null"; 
                        //EwbDtlsobj.TransDocDt = "null"; 
                        //EwbDtlsobj.VehNo = "null";      
                        //EwbDtlsobj.VehType = "null";    
                        //EwbDtlsobj.TransMode = "null";  
                    }
                    plinvoice.EwbDtls = EwbDtlsobj;
                    string jbody = JsonConvert.SerializeObject(plinvoice);
                    string url = "http://oswalapp.centralindia.cloudapp.azure.com/APIEinvoice_UAT/api/GenEInvoice/GenerateInvoice";
                    res1 = CallPOSTAPI(url, jbody);
                    if (res1 != null)
                    {

                    }

                    else
                    {
                        return;
                    }
                }
            }


            catch (Exception ex)
            {
                return;
            }
        }
        internal Response1 CallPOSTAPI(string url, string jsonObj)
        {
            // Response res = new Response();
            try
            {
                jsonObj = "{\"Version\":\"1.01\",\"UserCode\":1001,\"Password\":\"12345\",\"TranDtls\":{\"TaxSch\":\"GST\",\"SupTyp\":\"B2B\",\"RegRev\":\"Y\",\"EcmGstin\":null,\"IgstOnIntra\":\"N\"},\"DocDtls\":{\"Typ\":\"INV\",\"No\":\"DOC/1696\",\"Dt\":\"17/03/2022\"},\"SellerDtls\":{\"Gstin\":\"24AAKCM3927B1ZQ\",\"LglNm\":\"NICcompanypvtltd\",\"TrdNm\":\"NICIndustries\",\"Addr1\":\"5thblock,kuvempulayout\",\"Addr2\":\"kuvempulayout\",\"Loc\":\"GANDHINAGAR\",\"Pin\":383315,\"Stcd\":\"24\",\"Ph\":\"9000000000\",\"Em\":\"abc@gmail.com\"},\"BuyerDtls\":{\"Gstin\":\"29AWGPV7107B1Z1\",\"LglNm\":\"XYZcompanypvtltd\",\"TrdNm\":\"XYZIndustries\",\"Pos\":\"12\",\"Addr1\":\"7thblock,kuvempulayout\",\"Addr2\":\"kuvempulayout\",\"Loc\":\"GANDHINAGAR\",\"Pin\":562160,\"Stcd\":\"29\",\"Ph\":\"91111111111\",\"Em\":\"xyz@yahoo.com\"},\"ItemList\":[{\"SlNo\":\"1\",\"PrdDesc\":\"Rice\",\"IsServc\":\"N\",\"HsnCd\":\"841510\",\"Barcde\":\"123456\",\"Qty\":100.345,\"FreeQty\":10,\"Unit\":\"BAG\",\"UnitPrice\":99.545,\"TotAmt\":9988.84,\"Discount\":10,\"PreTaxVal\":1,\"AssAmt\":9978.84,\"GstRt\":12.0,\"IgstAmt\":1197.46,\"CgstAmt\":0,\"SgstAmt\":0,\"CesRt\":5,\"CesAmt\":498.94,\"CesNonAdvlAmt\":10,\"StateCesRt\":12,\"StateCesAmt\":1197.46,\"StateCesNonAdvlAmt\":5,\"OthChrg\":10,\"TotItemVal\":12897.7,\"OrdLineRef\":\"3256\",\"OrgCntry\":\"AG\",\"PrdSlNo\":\"12345\"}],\"ValDtls\":{\"AssVal\":9978.84,\"CgstVal\":0,\"SgstVal\":0,\"IgstVal\":1197.46,\"CesVal\":508.94,\"StCesVal\":1202.46,\"Discount\":10,\"OthChrg\":20,\"RndOffAmt\":0.3,\"TotInvVal\":12908,\"TotInvValFc\":12897.7},\"PayDtls\":{},\"EwbDtls\":{}}";
                var content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
                HttpClient HClient = new HttpClient();
                HClient.BaseAddress = new Uri(url.ToString());
                HClient.DefaultRequestHeaders.Accept.Clear();
                //HClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                HClient.Timeout = TimeSpan.FromMinutes(10);
                //var uri = jsonObj;
                //var response = HClient.PostAsJsonAsync(url, jsonObj).Result;
                var response = HClient.PostAsync(url, content).Result;

                var resData = response.Content.ReadAsStringAsync().Result.ToString();
                res1 = JsonConvert.DeserializeObject<Response1>(resData);
                return res1;
            }
            catch (Exception ex)
            {
                res1.StatusCode = 0;
                res1.Msg = ex.Message.ToString();
                res1.data = null;
            }
            return res1;
        }


        //internal Response1 CallPOSTAPI(string url, string jsonObj)
        //{
        //    Response1 res = new Response1();
        //    try
        //    {
        //        //jsonObj = "{\"Version\":\"1.01\",\"UserCode\":1001,\"Password\":\"12345\",\"TranDtls\":{\"TaxSch\":\"GST\",\"SupTyp\":\"B2B\",\"RegRev\":\"Y\",\"EcmGstin\":null,\"IgstOnIntra\":\"N\"},\"DocDtls\":{\"Typ\":\"INV\",\"No\":\"DOC/1696\",\"Dt\":\"17/03/2022\"},\"SellerDtls\":{\"Gstin\":\"24AAKCM3927B1ZQ\",\"LglNm\":\"NICcompanypvtltd\",\"TrdNm\":\"NICIndustries\",\"Addr1\":\"5thblock,kuvempulayout\",\"Addr2\":\"kuvempulayout\",\"Loc\":\"GANDHINAGAR\",\"Pin\":383315,\"Stcd\":\"24\",\"Ph\":\"9000000000\",\"Em\":\"abc@gmail.com\"},\"BuyerDtls\":{\"Gstin\":\"29AWGPV7107B1Z1\",\"LglNm\":\"XYZcompanypvtltd\",\"TrdNm\":\"XYZIndustries\",\"Pos\":\"12\",\"Addr1\":\"7thblock,kuvempulayout\",\"Addr2\":\"kuvempulayout\",\"Loc\":\"GANDHINAGAR\",\"Pin\":562160,\"Stcd\":\"29\",\"Ph\":\"91111111111\",\"Em\":\"xyz@yahoo.com\"},\"ItemList\":[{\"SlNo\":\"1\",\"PrdDesc\":\"Rice\",\"IsServc\":\"N\",\"HsnCd\":\"841510\",\"Barcde\":\"123456\",\"Qty\":100.345,\"FreeQty\":10,\"Unit\":\"BAG\",\"UnitPrice\":99.545,\"TotAmt\":9988.84,\"Discount\":10,\"PreTaxVal\":1,\"AssAmt\":9978.84,\"GstRt\":12.0,\"IgstAmt\":1197.46,\"CgstAmt\":0,\"SgstAmt\":0,\"CesRt\":5,\"CesAmt\":498.94,\"CesNonAdvlAmt\":10,\"StateCesRt\":12,\"StateCesAmt\":1197.46,\"StateCesNonAdvlAmt\":5,\"OthChrg\":10,\"TotItemVal\":12897.7,\"OrdLineRef\":\"3256\",\"OrgCntry\":\"AG\",\"PrdSlNo\":\"12345\"}],\"ValDtls\":{\"AssVal\":9978.84,\"CgstVal\":0,\"SgstVal\":0,\"IgstVal\":1197.46,\"CesVal\":508.94,\"StCesVal\":1202.46,\"Discount\":10,\"OthChrg\":20,\"RndOffAmt\":0.3,\"TotInvVal\":12908,\"TotInvValFc\":12897.7},\"PayDtls\":{},\"EwbDtls\":{}}";
        //        var client = new RestClient(url);
        //        var request = new RestRequest(Method.POST);
        //        request.AddHeader("Content-Type", "application/json");
        //        request.AddParameter("application/json", jsonObj, ParameterType.RequestBody);
        //        IRestResponse response = client.Execute(request);
        //        if (System.Net.HttpStatusCode.OK == response.StatusCode)
        //        {
        //            res = JsonConvert.DeserializeObject<Response1>(response.Content);
        //        }
        //        else
        //        {
        //            res = JsonConvert.DeserializeObject<Response1>(response.Content);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        res.StatusCode = 0;
        //        res.Msg = ex.Message.ToString();
        //        res.data = null;
        //    }
        //    return res;
        //}

    }
}