﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
	public partial class Form1 : Form
	{
		private DataTable foodTable;
		public Form1()
		{
			InitializeComponent();
		}

		private void LoadCategory()
		{
			string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			// mở kết nối
			conn.Open();

			// lấy dữ liệu từ csdl đưa vào database
			adapter.Fill(dt);

			// lấy dữ liệu từ csdl đưa vào database
			conn.Close();
			conn.Dispose();

			// đưa dữ liệu vào combobox
			cbbCategory.DataSource = dt;

			// hiển thị tên nhóm sản phẩm
			cbbCategory.DisplayMember = "Name";

			//nhưng khi lấy giá trị thì lấy ID của nhóm
			cbbCategory.ValueMember = "ID";

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.LoadCategory();
		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbCategory.SelectedIndex == -1) return;
			string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

			// truyền tham số
			cmd.Parameters.Add("@categoryId", SqlDbType.Int);

			if (cbbCategory.SelectedValue is DataRowView)
			{
				DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
				cmd.Parameters["@categoryId"].Value = rowView["ID"];
			}
			else
			{
				cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
			}

			// tạo bộ điều phiếu dữ liệu
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			foodTable = new DataTable();

			// mở kết nối
			conn.Open();

			// lấy dữ liệu từ csdl đưa vào DataTable
			adapter.Fill(foodTable);

			// đóng kết nối và giải phóng bộ nhớ
			conn.Close();
			conn.Dispose();

			// đưa dữ liệu vào data gridview
			dgvFoodList.DataSource = foodTable;

			// tính số lương mẫu tin
			lblQuantity.Text = foodTable.Rows.Count.ToString();
			lblCatName.Text = cbbCategory.Text;
		}

		private void tsmCalculateQuantity_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=DESKTOP-O55J47Q;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

			// lấy thông tin sản phẩm được chọn
			if (dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				// truyền tham số
				cmd.Parameters.Add("@foodId", SqlDbType.Int);
				cmd.Parameters["@foodId"].Value = rowView["ID"];

				cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
				cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				// mở kết nối csdl
				conn.Open();

				// thực thi truy vấn và lấy dữ liệu từ tham số
				cmd.ExecuteNonQuery();

				var result = cmd.Parameters["@numSaleFood"].Value.ToString();
				MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + (result == "" ? "0" : result) + " " + rowView["Unit"]);

				// đóng kết nối csdl
				conn.Close();
			}
			cmd.Dispose();
			conn.Dispose();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			int index = cbbCategory.SelectedIndex;
			cbbCategory.SelectedIndex = -1;
			cbbCategory.SelectedIndex = index;
		}

		private void tsmAddFood_Click(object sender, EventArgs e)
		{
			foodInfoForm foodForm = new foodInfoForm();
			foodForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
			foodForm.Show(this);
		}

		private void tsmUpdateFood_Click(object sender, EventArgs e)
		{
			// lấy thông tin sản phẩn được chọn
			if (dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				foodInfoForm foodForm = new foodInfoForm();
				foodForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

				foodForm.Show(this);
				foodForm.DisplayFoodInfo(rowView);
			}
		}

		private void txtSearchByName_TextChanged(object sender, EventArgs e)
		{
			if (foodTable == null) return;

			// create fillter and sort expression
			string fillterExpression = "Name like '%" + txtSearchByName.Text + "%'";
			string sortExpression = "Price DESC";
			DataViewRowState rowStateFillter = DataViewRowState.OriginalRows;

			// create a data view object to view the data in foodTable data table
			// fillter by Name (contain 'ng') and sort descending by Price
			DataView foodView = new DataView(foodTable, fillterExpression, sortExpression, rowStateFillter);

			// assign foodTable as Data Source of data grid view
			dgvFoodList.DataSource = foodView;
		}

		private void btnBill_Click(object sender, EventArgs e)
		{
			OrdersForm ordersForm = new OrdersForm();
			ordersForm.Show(this);
		}

		private void btnAcc_Click(object sender, EventArgs e)
		{
			AccountForm acc = new AccountForm();
			acc.Show(this);
		}
	}
}
