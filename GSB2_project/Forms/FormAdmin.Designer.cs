namespace GSB2_project.Forms
{
    partial class FormAdmin
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
            tabAdmin = new TabControl();
            UserMedecin = new TabPage();
            btnViewMedecin = new Button();
            btnDeleteMedecin = new Button();
            btnEditMedecin = new Button();
            btnAddMedecin = new Button();
            dataGridView1 = new DataGridView();
            Patients = new TabPage();
            dataGridView2 = new DataGridView();
            Médicaments = new TabPage();
            dataGridView3 = new DataGridView();
            btnViewPatients = new Button();
            btnDeletePatients = new Button();
            btnUpdatePatients = new Button();
            btnAddPatients = new Button();
            btnViewMedicine = new Button();
            btnDeleteMedicine = new Button();
            btnUpdateMedicine = new Button();
            btnAddMedicine = new Button();
            tabAdmin.SuspendLayout();
            UserMedecin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Médicaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(UserMedecin);
            tabAdmin.Controls.Add(Patients);
            tabAdmin.Controls.Add(Médicaments);
            tabAdmin.Dock = DockStyle.Fill;
            tabAdmin.Location = new Point(0, 0);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(800, 450);
            tabAdmin.TabIndex = 0;
            // 
            // UserMedecin
            // 
            UserMedecin.Controls.Add(btnViewMedecin);
            UserMedecin.Controls.Add(btnDeleteMedecin);
            UserMedecin.Controls.Add(btnEditMedecin);
            UserMedecin.Controls.Add(btnAddMedecin);
            UserMedecin.Controls.Add(dataGridView1);
            UserMedecin.Location = new Point(4, 29);
            UserMedecin.Name = "UserMedecin";
            UserMedecin.Padding = new Padding(3);
            UserMedecin.Size = new Size(792, 417);
            UserMedecin.TabIndex = 0;
            UserMedecin.Text = "UserMedecin";
            UserMedecin.UseVisualStyleBackColor = true;
            // 
            // btnViewMedecin
            // 
            btnViewMedecin.Location = new Point(376, 215);
            btnViewMedecin.Name = "btnViewMedecin";
            btnViewMedecin.Size = new Size(94, 29);
            btnViewMedecin.TabIndex = 4;
            btnViewMedecin.Text = "Consulter";
            btnViewMedecin.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMedecin
            // 
            btnDeleteMedecin.Location = new Point(264, 215);
            btnDeleteMedecin.Name = "btnDeleteMedecin";
            btnDeleteMedecin.Size = new Size(94, 29);
            btnDeleteMedecin.TabIndex = 3;
            btnDeleteMedecin.Text = "Supprimer";
            btnDeleteMedecin.UseVisualStyleBackColor = true;
            // 
            // btnEditMedecin
            // 
            btnEditMedecin.Location = new Point(139, 215);
            btnEditMedecin.Name = "btnEditMedecin";
            btnEditMedecin.Size = new Size(94, 29);
            btnEditMedecin.TabIndex = 2;
            btnEditMedecin.Text = "Modifier";
            btnEditMedecin.UseVisualStyleBackColor = true;
            // 
            // btnAddMedecin
            // 
            btnAddMedecin.Location = new Point(22, 215);
            btnAddMedecin.Name = "btnAddMedecin";
            btnAddMedecin.Size = new Size(94, 29);
            btnAddMedecin.TabIndex = 1;
            btnAddMedecin.Text = "Ajouter";
            btnAddMedecin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Patients
            // 
            Patients.Controls.Add(btnViewPatients);
            Patients.Controls.Add(btnDeletePatients);
            Patients.Controls.Add(btnUpdatePatients);
            Patients.Controls.Add(btnAddPatients);
            Patients.Controls.Add(dataGridView2);
            Patients.Location = new Point(4, 29);
            Patients.Name = "Patients";
            Patients.Padding = new Padding(3);
            Patients.Size = new Size(792, 417);
            Patients.TabIndex = 1;
            Patients.Text = "Patients";
            Patients.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Top;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(786, 188);
            dataGridView2.TabIndex = 0;
            // 
            // Médicaments
            // 
            Médicaments.Controls.Add(btnViewMedicine);
            Médicaments.Controls.Add(btnDeleteMedicine);
            Médicaments.Controls.Add(btnUpdateMedicine);
            Médicaments.Controls.Add(btnAddMedicine);
            Médicaments.Controls.Add(dataGridView3);
            Médicaments.Location = new Point(4, 29);
            Médicaments.Name = "Médicaments";
            Médicaments.Size = new Size(792, 417);
            Médicaments.TabIndex = 2;
            Médicaments.Text = "Médicaments";
            Médicaments.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Top;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(792, 188);
            dataGridView3.TabIndex = 0;
            // 
            // btnViewPatients
            // 
            btnViewPatients.Location = new Point(377, 213);
            btnViewPatients.Name = "btnViewPatients";
            btnViewPatients.Size = new Size(94, 29);
            btnViewPatients.TabIndex = 8;
            btnViewPatients.Text = "Consulter";
            btnViewPatients.UseVisualStyleBackColor = true;
            // 
            // btnDeletePatients
            // 
            btnDeletePatients.Location = new Point(265, 213);
            btnDeletePatients.Name = "btnDeletePatients";
            btnDeletePatients.Size = new Size(94, 29);
            btnDeletePatients.TabIndex = 7;
            btnDeletePatients.Text = "Supprimer";
            btnDeletePatients.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePatients
            // 
            btnUpdatePatients.Location = new Point(140, 213);
            btnUpdatePatients.Name = "btnUpdatePatients";
            btnUpdatePatients.Size = new Size(94, 29);
            btnUpdatePatients.TabIndex = 6;
            btnUpdatePatients.Text = "Modifier";
            btnUpdatePatients.UseVisualStyleBackColor = true;
            // 
            // btnAddPatients
            // 
            btnAddPatients.Location = new Point(23, 213);
            btnAddPatients.Name = "btnAddPatients";
            btnAddPatients.Size = new Size(94, 29);
            btnAddPatients.TabIndex = 5;
            btnAddPatients.Text = "Ajouter";
            btnAddPatients.UseVisualStyleBackColor = true;
            // 
            // btnViewMedicine
            // 
            btnViewMedicine.Location = new Point(375, 209);
            btnViewMedicine.Name = "btnViewMedicine";
            btnViewMedicine.Size = new Size(94, 29);
            btnViewMedicine.TabIndex = 12;
            btnViewMedicine.Text = "Consulter";
            btnViewMedicine.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMedicine
            // 
            btnDeleteMedicine.Location = new Point(263, 209);
            btnDeleteMedicine.Name = "btnDeleteMedicine";
            btnDeleteMedicine.Size = new Size(94, 29);
            btnDeleteMedicine.TabIndex = 11;
            btnDeleteMedicine.Text = "Supprimer";
            btnDeleteMedicine.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMedicine
            // 
            btnUpdateMedicine.Location = new Point(138, 209);
            btnUpdateMedicine.Name = "btnUpdateMedicine";
            btnUpdateMedicine.Size = new Size(94, 29);
            btnUpdateMedicine.TabIndex = 10;
            btnUpdateMedicine.Text = "Modifier";
            btnUpdateMedicine.UseVisualStyleBackColor = true;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new Point(21, 209);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(94, 29);
            btnAddMedicine.TabIndex = 9;
            btnAddMedicine.Text = "Ajouter";
            btnAddMedicine.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabAdmin);
            Name = "FormAdmin";
            Text = "FormAdmin";
            tabAdmin.ResumeLayout(false);
            UserMedecin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Médicaments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAdmin;
        private TabPage UserMedecin;
        private TabPage Patients;
        private TabPage Médicaments;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button btnViewMedecin;
        private Button btnDeleteMedecin;
        private Button btnEditMedecin;
        private Button btnAddMedecin;
        private Button btnViewPatients;
        private Button btnDeletePatients;
        private Button btnUpdatePatients;
        private Button btnAddPatients;
        private Button btnViewMedicine;
        private Button btnDeleteMedicine;
        private Button btnUpdateMedicine;
        private Button btnAddMedicine;
    }
}