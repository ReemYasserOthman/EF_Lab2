using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Lab2
{
    public partial class Layred : Form
    {
        public Layred()
        {
            InitializeComponent();            

        }

        private void ConnictedMode_Load(object sender, EventArgs e)
        {
            dgv_Courses.DataSource = CourseBuisnessLayer.GetAll();
            cb_Topic.DataSource= TopicBuisnessLayer.GetAll();
            cb_Topic.DisplayMember = "Top_Name";
            cb_Topic.ValueMember = "Top_Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int result = CourseBuisnessLayer.Add((int)nup_Id.Value, text_name.Text,(int)nup_Duration.Value,(int)cb_Topic.SelectedValue);
            if (result > 0)
            {
                MessageBox.Show("Data have been added.");
                dgv_Courses.DataSource = DatabaseLayer.Select("Select * from Course");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int result = CourseBuisnessLayer.Edit((int)nup_Id.Value, text_name.Text, (int)nup_Duration.Value, (int)cb_Topic.SelectedValue);
            if (result > 0)
            {
                MessageBox.Show("Data Updated.");
                dgv_Courses.DataSource = DatabaseLayer.Select("Select * from Course");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int result = CourseBuisnessLayer.Delete((int)nup_Id.Value);
            if (result > 0)
            {
                MessageBox.Show("Data Deleted.");
                dgv_Courses.DataSource = DatabaseLayer.Select("Select * from Course");
            }
        }

        private void dgv_Courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nup_Id.Value = (int)dgv_Courses.SelectedRows[0].Cells[0].Value;
            text_name.Text = dgv_Courses.SelectedRows[0].Cells[1].Value.ToString();
            nup_Duration.Value = (int)dgv_Courses.SelectedRows[0].Cells[2].Value;
            cb_Topic.SelectedValue = (int)dgv_Courses.SelectedRows[0].Cells[3].Value;
        }
    }
}
