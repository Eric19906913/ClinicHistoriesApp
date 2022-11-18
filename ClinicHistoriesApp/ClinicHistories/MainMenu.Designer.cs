namespace ClinicHistories
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnClinicHistories = new System.Windows.Forms.Button();
            this.btnAddHelathCare = new System.Windows.Forms.Button();
            this.btnAddConsultation = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sidePanel.Controls.Add(this.btnClinicHistories);
            this.sidePanel.Controls.Add(this.btnAddHelathCare);
            this.sidePanel.Controls.Add(this.btnAddConsultation);
            this.sidePanel.Controls.Add(this.btnAddPatient);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 517);
            this.sidePanel.TabIndex = 0;
            // 
            // btnClinicHistories
            // 
            this.btnClinicHistories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicHistories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClinicHistories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicHistories.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClinicHistories.Location = new System.Drawing.Point(0, 202);
            this.btnClinicHistories.Name = "btnClinicHistories";
            this.btnClinicHistories.Size = new System.Drawing.Size(200, 34);
            this.btnClinicHistories.TabIndex = 4;
            this.btnClinicHistories.Text = "Historias Clinicas";
            this.btnClinicHistories.UseVisualStyleBackColor = true;
            // 
            // btnAddHelathCare
            // 
            this.btnAddHelathCare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddHelathCare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddHelathCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHelathCare.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddHelathCare.Location = new System.Drawing.Point(0, 168);
            this.btnAddHelathCare.Name = "btnAddHelathCare";
            this.btnAddHelathCare.Size = new System.Drawing.Size(200, 34);
            this.btnAddHelathCare.TabIndex = 3;
            this.btnAddHelathCare.Text = "Obras Sociales";
            this.btnAddHelathCare.UseVisualStyleBackColor = true;
            // 
            // btnAddConsultation
            // 
            this.btnAddConsultation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddConsultation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddConsultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConsultation.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddConsultation.Location = new System.Drawing.Point(0, 134);
            this.btnAddConsultation.Name = "btnAddConsultation";
            this.btnAddConsultation.Size = new System.Drawing.Size(200, 34);
            this.btnAddConsultation.TabIndex = 2;
            this.btnAddConsultation.Text = "Consultas";
            this.btnAddConsultation.UseVisualStyleBackColor = true;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPatient.Location = new System.Drawing.Point(0, 100);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(200, 34);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Agregar paciente";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(648, 517);
            this.mainPanel.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 517);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "MainMenu";
            this.Text = "Hospital";
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Panel panel1;
        private Panel mainPanel;
        private Button btnClinicHistories;
        private Button btnAddHelathCare;
        private Button btnAddConsultation;
        private Button btnAddPatient;
    }
}