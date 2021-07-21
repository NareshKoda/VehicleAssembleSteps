namespace VehicleAssembleSteps.Views
{
    partial class AllLineDetails
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
            this.components = new System.ComponentModel.Container();
            this.gbAllLineDetails = new System.Windows.Forms.GroupBox();
            this.grdvAllLineDetails = new System.Windows.Forms.DataGridView();
            this.repositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbAllLineDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvAllLineDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAllLineDetails
            // 
            this.gbAllLineDetails.Controls.Add(this.grdvAllLineDetails);
            this.gbAllLineDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAllLineDetails.Location = new System.Drawing.Point(0, 0);
            this.gbAllLineDetails.Name = "gbAllLineDetails";
            this.gbAllLineDetails.Size = new System.Drawing.Size(800, 450);
            this.gbAllLineDetails.TabIndex = 0;
            this.gbAllLineDetails.TabStop = false;
            this.gbAllLineDetails.Text = "All Line Details";
            // 
            // grdvAllLineDetails
            // 
            this.grdvAllLineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvAllLineDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvAllLineDetails.Location = new System.Drawing.Point(3, 16);
            this.grdvAllLineDetails.Name = "grdvAllLineDetails";
            this.grdvAllLineDetails.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.grdvAllLineDetails.Size = new System.Drawing.Size(794, 431);
            this.grdvAllLineDetails.TabIndex = 0;
            // 
            // repositoryBindingSource
            // 
            this.repositoryBindingSource.DataSource = typeof(VehicleAssembleSteps.Repository);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(VehicleAssembleSteps.MainForm);
            // 
            // AllLineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAllLineDetails);
            this.Name = "AllLineDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Line Details";
            this.Load += new System.EventHandler(this.AllLineDetails_Load);
            this.gbAllLineDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvAllLineDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbAllLineDetails;
        private System.Windows.Forms.DataGridView grdvAllLineDetails;
        private System.Windows.Forms.BindingSource repositoryBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}