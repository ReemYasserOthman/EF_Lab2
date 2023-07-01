using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Lab2
{
    public partial class DisconnectedMode : Form
    {

        SqlConnection connection;
        DataTable dataTable;
        public DisconnectedMode()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

        }

        private void Disconnectid_Load(object sender, EventArgs e)
        {
            #region Topic Data
            // Define Command
            SqlDataAdapter adapter1 = new SqlDataAdapter("select * from Topic", connection);

            // Define DataTable
            dataTable = new DataTable();

            // Load Data
            adapter1.Fill(dataTable);
            dataTable.Columns[0].AllowDBNull = false;
            dataTable.Columns[0].Unique = true;

            cb_Topic.DataSource = dataTable;
            cb_Topic.DisplayMember= "Top_Name";
            cb_Topic.ValueMember= "Top_Id";
            #endregion


            #region Course Data
            // Define Command
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Course", connection);

            // Define DataTable
            dataTable = new DataTable();

            // Load Data
            adapter.Fill(dataTable);
            dataTable.Columns[0].AllowDBNull = false;
            dataTable.Columns[0].Unique = true;

            dgv_Courses.DataSource = dataTable;
            dgv_Courses.Columns[0].ReadOnly = true;
            #endregion
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = nup_Id.Value;
            dataRow[1] = text_name.Text;
            dataRow[2] = nup_Duration.Value;
            dataRow[3] = cb_Topic.SelectedValue;

            dataTable.Rows.Add(dataRow);

            MessageBox.Show("Data have been added.");

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id = (int)nup_Id.Value;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted && (int)row["Crs_Id"] == id)
                {
                    row["Crs_Name"] = text_name.Text;
                    row["Crs_Duration"] = nup_Duration.Value;
                    row["Top_Id"] = cb_Topic.SelectedValue;                    

                }
            }

            MessageBox.Show("Data Updated Successfully");
        }

        private void dgv_Courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nup_Id.Value = (int)dgv_Courses.SelectedRows[0].Cells[0].Value;
            text_name.Text = dgv_Courses.SelectedRows[0].Cells[1].Value.ToString();
            nup_Duration.Value = (int)dgv_Courses.SelectedRows[0].Cells[2].Value;
            cb_Topic.SelectedValue = (int)dgv_Courses.SelectedRows[0].Cells[3].Value;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = (int)nup_Id.Value;            
            
            foreach (DataRow row in dataTable.Rows)
            {
                if ((int)row["Crs_Id"] == id) row.Delete();
            }

            MessageBox.Show("Data deleted Successfully");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Define command

            // update
            SqlCommand updateCommand = new SqlCommand("update Course set Crs_Name=@name,Crs_Duration=@duration,Top_Id=@topic where Crs_Id = @id", connection);
            updateCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "Crs_Name");
            updateCommand.Parameters.Add("topic", SqlDbType.Int, 4, "Top_Id");
            updateCommand.Parameters.Add("duration", SqlDbType.Int, 4, "Crs_Duration");
            updateCommand.Parameters.Add("id", SqlDbType.Int, 4, "Crs_Id");

            // insert          
            SqlCommand insertCommand = new SqlCommand("insert into Course values(@id,@name,@duration,@topic)", connection);
            insertCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "Crs_Name");
            insertCommand.Parameters.Add("id", SqlDbType.Int, 4, "Crs_Id");
            insertCommand.Parameters.Add("topic", SqlDbType.Int, 4, "Top_Id");
            insertCommand.Parameters.Add("duration", SqlDbType.Int, 4, "Crs_Duration");

            // delete
            SqlCommand deleteCommand = new SqlCommand("delete from Course where Crs_Id=@id", connection);            
            deleteCommand.Parameters.Add("id", SqlDbType.Int, 4, "Crs_Id");

            // Define DataAdaptor + link commands
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;
            adapter.InsertCommand = insertCommand;

            adapter.Update(dataTable);
        }

        
    }
}
