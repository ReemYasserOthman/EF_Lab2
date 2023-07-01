namespace EF_Lab2
{
    partial class Layred
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.nup_Id = new System.Windows.Forms.NumericUpDown();
            this.dgv_Courses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.nup_Duration = new System.Windows.Forms.NumericUpDown();
            this.cb_Topic = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID:";
            // 
            // nup_Id
            // 
            this.nup_Id.Location = new System.Drawing.Point(45, 29);
            this.nup_Id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup_Id.Name = "nup_Id";
            this.nup_Id.Size = new System.Drawing.Size(120, 24);
            this.nup_Id.TabIndex = 35;
            // 
            // dgv_Courses
            // 
            this.dgv_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Courses.Location = new System.Drawing.Point(12, 181);
            this.dgv_Courses.Name = "dgv_Courses";
            this.dgv_Courses.RowHeadersWidth = 51;
            this.dgv_Courses.RowTemplate.Height = 26;
            this.dgv_Courses.Size = new System.Drawing.Size(792, 267);
            this.dgv_Courses.TabIndex = 33;
            this.dgv_Courses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Courses_RowHeaderMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Topic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Course Name:";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(284, 29);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 24);
            this.text_name.TabIndex = 29;
            // 
            // nup_Duration
            // 
            this.nup_Duration.Location = new System.Drawing.Point(462, 25);
            this.nup_Duration.Name = "nup_Duration";
            this.nup_Duration.Size = new System.Drawing.Size(120, 24);
            this.nup_Duration.TabIndex = 28;
            // 
            // cb_Topic
            // 
            this.cb_Topic.FormattingEnabled = true;
            this.cb_Topic.Location = new System.Drawing.Point(646, 22);
            this.cb_Topic.Name = "cb_Topic";
            this.cb_Topic.Size = new System.Drawing.Size(121, 24);
            this.cb_Topic.TabIndex = 27;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(402, 85);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 26;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(507, 85);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 25;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(615, 85);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Layred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nup_Id);
            this.Controls.Add(this.dgv_Courses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.nup_Duration);
            this.Controls.Add(this.cb_Topic);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_add);
            this.Name = "Layred";
            this.Text = "ConnictedMode";
            this.Load += new System.EventHandler(this.ConnictedMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nup_Id;
        private System.Windows.Forms.DataGridView dgv_Courses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.NumericUpDown nup_Duration;
        private System.Windows.Forms.ComboBox cb_Topic;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_add;
    }
}