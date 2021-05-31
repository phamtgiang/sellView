using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SellView
{
    public partial class Form1 : Form
    {
        //₫ịnh nghĩa các thuộc tính dữ liệu cần dùng
        private String ConnectionString;
        private DataViewManager dsView;
        private DataSet ds;
        private OleDbConnection cn;

        public Form1()
        {
            InitializeComponent();
            //xây dựng chuỗi ₫ặc tả database cần truy xuất
            ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =d:\\NorthWind.mdb; ";
            //tạo ₫ối tượng Connection ₫ến database
            cn = new OleDbConnection(ConnectionString);
            //tạo ₫ối tượng DataSet
            ds = new DataSet("CustOrders");
            //tạo ₫ối tượng DataApdater quản lý danh sách các khách hàng
            OleDbDataAdapter da1 = new OleDbDataAdapter
             ("SELECT * FROM Customers", cn);
            //ánh xạ Tablename "Table" tới bảng dữ liệu "Customers"
            da1.TableMappings.Add("Table", "Customers");
            //chứa bảng Customers vào Dataset
            da1.Fill(ds);
            //tạo ₫ối tượng DataApdater quản lý danh sách các ₫ơn ₫ặt hàng
            OleDbDataAdapter da2 = new OleDbDataAdapter
            ("SELECT * FROM Orders", cn);
            //ánh xạ Tablename "Table" tới bảng dữ liệu "Orders"
            da2.TableMappings.Add("Table", "Orders");
            // chứa bảng Orders vào Dataset
            da2.Fill(ds);
            //tạo ₫ối tượng DataApdater quản lý danh sách các mặt hàng
            OleDbDataAdapter da3 = new OleDbDataAdapter
            ("SELECT * FROM [Order Details]", cn);
            //ánh xạ Tablename "Table" tới bảng dữ liệu "Orders"
            da3.TableMappings.Add("Table", "OrderDetails");
            // chứa bảng [Orders Details] vào Dataset
            da3.Fill(ds);
            //thiết lập quan hệ "RelCustOrd" giữa bảng Customers và Orders
            System.Data.DataRelation relCustOrd;
            System.Data.DataColumn colMaster1;
            System.Data.DataColumn colDetail1;
            colMaster1 = ds.Tables["Customers"].Columns["CustomerID"];
            colDetail1 = ds.Tables["Orders"].Columns["CustomerID"];
            relCustOrd = new System.Data.DataRelation
            ("RelCustOrd", colMaster1, colDetail1);
            //"add" quan hệ vừa tạo vào dataSet
            ds.Relations.Add(relCustOrd);
            //thiết lập quan hệ "relOrdDet" giữa bảng Orders & [Order Details]
            System.Data.DataRelation relOrdDet;
            System.Data.DataColumn colMaster2;
            System.Data.DataColumn colDetail2;
            colMaster2 = ds.Tables["Orders"].Columns["OrderID"];
            colDetail2 = ds.Tables["OrderDetails"].Columns["OrderID"];
            relOrdDet = new DataRelation("RelOrdDet", colMaster2, colDetail2);
            //"add" quan hệ vừa tạo vào dataSet
            ds.Relations.Add(relOrdDet);
            //Xác ₫ịnh DataViewManager của DataSet.
            dsView = ds.DefaultViewManager;
            //thiết lập Databinding giữa database với 2 DataGridView
            grdOrders.DataSource = dsView;
            grdOrders.DataMember = "Customers.RelCustOrd";
            grdOrderDetails.DataSource = dsView;
            grdOrderDetails.DataMember = "Customers.RelCustOrd.RelOrdDet";
            //thiết lập Databinding giữa database với ComboBox
            cbCust.DataSource = dsView;
            cbCust.DisplayMember = "Customers.CompanyName";
            cbCust.ValueMember = "Customers.CustomerID";
            //thiết lập Databinding giữa database với 3 Textbox
            txtContact.DataBindings.Add("Text", dsView, "Customers.ContactName");
            txtPhoneNo.DataBindings.Add("Text", dsView, "Customers.Phone");
            txtFaxNo.DataBindings.Add("Text", dsView, "Customers.Fax");

        }

        private void btnToi_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[dsView, "Customers"];
            //nếu không phải khách hàng cuối thì tiến tới 1 khách hàng
            if (cm.Position < cm.Count - 1) cm.Position++;
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            //nếu không phải khách hàng ₫ầu tiên thì lùi 1 khách hàng
            if (this.BindingContext[dsView, "Customers"].Position > 0)
                this.BindingContext[dsView, "Customers"].Position--;
        }

    }
}
