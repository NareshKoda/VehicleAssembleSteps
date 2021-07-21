namespace VehicleAssembleSteps
{
    partial class MainForm
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
            this.lblVechicleProjCode = new System.Windows.Forms.Label();
            this.txtVehicleProjCode = new System.Windows.Forms.TextBox();
            this.rbDomestic = new System.Windows.Forms.RadioButton();
            this.rbExport = new System.Windows.Forms.RadioButton();
            this.lblTirePressure = new System.Windows.Forms.Label();
            this.txtTirePressure = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.rbAMT = new System.Windows.Forms.RadioButton();
            this.rbIMT = new System.Windows.Forms.RadioButton();
            this.rbAT = new System.Windows.Forms.RadioButton();
            this.rbMT = new System.Windows.Forms.RadioButton();
            this.lblAssemblyProcess = new System.Windows.Forms.Label();
            this.rtxtAssemblyProcess = new System.Windows.Forms.RichTextBox();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTransmissionType = new System.Windows.Forms.Label();
            this.lblVariant = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxWest = new System.Windows.Forms.CheckBox();
            this.chkBoxSouth = new System.Windows.Forms.CheckBox();
            this.chkBoxMWest = new System.Windows.Forms.CheckBox();
            this.chkBoxNorth = new System.Windows.Forms.CheckBox();
            this.gbTransmissionType = new System.Windows.Forms.GroupBox();
            this.gbVariant = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.btnDisplaAllLines = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbTransmissionType.SuspendLayout();
            this.gbVariant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVechicleProjCode
            // 
            this.lblVechicleProjCode.AutoSize = true;
            this.lblVechicleProjCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVechicleProjCode.Location = new System.Drawing.Point(16, 34);
            this.lblVechicleProjCode.Name = "lblVechicleProjCode";
            this.lblVechicleProjCode.Size = new System.Drawing.Size(126, 13);
            this.lblVechicleProjCode.TabIndex = 0;
            this.lblVechicleProjCode.Text = "Vehicle Project Code";
            // 
            // txtVehicleProjCode
            // 
            this.txtVehicleProjCode.Location = new System.Drawing.Point(157, 31);
            this.txtVehicleProjCode.MaxLength = 100;
            this.txtVehicleProjCode.Name = "txtVehicleProjCode";
            this.txtVehicleProjCode.Size = new System.Drawing.Size(139, 20);
            this.txtVehicleProjCode.TabIndex = 1;
            this.txtVehicleProjCode.Leave += new System.EventHandler(this.txtVehicleProjCode_Leave);
            // 
            // rbDomestic
            // 
            this.rbDomestic.AccessibleName = "tst";
            this.rbDomestic.AutoSize = true;
            this.rbDomestic.Location = new System.Drawing.Point(6, 14);
            this.rbDomestic.Name = "rbDomestic";
            this.rbDomestic.Size = new System.Drawing.Size(69, 17);
            this.rbDomestic.TabIndex = 3;
            this.rbDomestic.TabStop = true;
            this.rbDomestic.Text = "Domestic";
            this.rbDomestic.UseVisualStyleBackColor = true;
            // 
            // rbExport
            // 
            this.rbExport.AccessibleName = "tst";
            this.rbExport.AutoSize = true;
            this.rbExport.Location = new System.Drawing.Point(129, 14);
            this.rbExport.Name = "rbExport";
            this.rbExport.Size = new System.Drawing.Size(55, 17);
            this.rbExport.TabIndex = 4;
            this.rbExport.TabStop = true;
            this.rbExport.Text = "Export";
            this.rbExport.UseVisualStyleBackColor = true;
            // 
            // lblTirePressure
            // 
            this.lblTirePressure.AutoSize = true;
            this.lblTirePressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTirePressure.Location = new System.Drawing.Point(60, 103);
            this.lblTirePressure.Name = "lblTirePressure";
            this.lblTirePressure.Size = new System.Drawing.Size(82, 13);
            this.lblTirePressure.TabIndex = 5;
            this.lblTirePressure.Text = "Tire Pressure";
            // 
            // txtTirePressure
            // 
            this.txtTirePressure.Location = new System.Drawing.Point(157, 100);
            this.txtTirePressure.MaxLength = 50;
            this.txtTirePressure.Name = "txtTirePressure";
            this.txtTirePressure.Size = new System.Drawing.Size(139, 20);
            this.txtTirePressure.TabIndex = 5;
            this.txtTirePressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTirePressure_KeyPress);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(95, 145);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(47, 13);
            this.lblRegion.TabIndex = 7;
            this.lblRegion.Text = "Region";
            // 
            // rbAMT
            // 
            this.rbAMT.AutoSize = true;
            this.rbAMT.Location = new System.Drawing.Point(6, 27);
            this.rbAMT.Name = "rbAMT";
            this.rbAMT.Size = new System.Drawing.Size(48, 17);
            this.rbAMT.TabIndex = 12;
            this.rbAMT.TabStop = true;
            this.rbAMT.Text = "AMT";
            this.rbAMT.UseVisualStyleBackColor = true;
            // 
            // rbIMT
            // 
            this.rbIMT.AutoSize = true;
            this.rbIMT.Location = new System.Drawing.Point(291, 27);
            this.rbIMT.Name = "rbIMT";
            this.rbIMT.Size = new System.Drawing.Size(44, 17);
            this.rbIMT.TabIndex = 15;
            this.rbIMT.TabStop = true;
            this.rbIMT.Text = "IMT";
            this.rbIMT.UseVisualStyleBackColor = true;
            // 
            // rbAT
            // 
            this.rbAT.AutoSize = true;
            this.rbAT.Location = new System.Drawing.Point(200, 27);
            this.rbAT.Name = "rbAT";
            this.rbAT.Size = new System.Drawing.Size(39, 17);
            this.rbAT.TabIndex = 14;
            this.rbAT.TabStop = true;
            this.rbAT.Text = "AT";
            this.rbAT.UseVisualStyleBackColor = true;
            // 
            // rbMT
            // 
            this.rbMT.AutoSize = true;
            this.rbMT.Location = new System.Drawing.Point(109, 27);
            this.rbMT.Name = "rbMT";
            this.rbMT.Size = new System.Drawing.Size(41, 17);
            this.rbMT.TabIndex = 13;
            this.rbMT.TabStop = true;
            this.rbMT.Text = "MT";
            this.rbMT.UseVisualStyleBackColor = true;
            // 
            // lblAssemblyProcess
            // 
            this.lblAssemblyProcess.AutoSize = true;
            this.lblAssemblyProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyProcess.Location = new System.Drawing.Point(34, 257);
            this.lblAssemblyProcess.Name = "lblAssemblyProcess";
            this.lblAssemblyProcess.Size = new System.Drawing.Size(108, 13);
            this.lblAssemblyProcess.TabIndex = 14;
            this.lblAssemblyProcess.Text = "Assembly Process";
            // 
            // rtxtAssemblyProcess
            // 
            this.rtxtAssemblyProcess.Location = new System.Drawing.Point(157, 241);
            this.rtxtAssemblyProcess.MaxLength = 300;
            this.rtxtAssemblyProcess.Name = "rtxtAssemblyProcess";
            this.rtxtAssemblyProcess.Size = new System.Drawing.Size(295, 77);
            this.rtxtAssemblyProcess.TabIndex = 16;
            this.rtxtAssemblyProcess.Text = "";
            this.rtxtAssemblyProcess.Leave += new System.EventHandler(this.rtxtAssemblyProcess_Leave);
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorCode.Location = new System.Drawing.Point(73, 336);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(69, 13);
            this.lblColorCode.TabIndex = 16;
            this.lblColorCode.Text = "Color Code";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(266, 370);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 33);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTransmissionType);
            this.groupBox1.Controls.Add(this.lblVariant);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gbTransmissionType);
            this.groupBox1.Controls.Add(this.gbVariant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAsterisk);
            this.groupBox1.Controls.Add(this.lblVechicleProjCode);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtVehicleProjCode);
            this.groupBox1.Controls.Add(this.lblColorCode);
            this.groupBox1.Controls.Add(this.rtxtAssemblyProcess);
            this.groupBox1.Controls.Add(this.lblAssemblyProcess);
            this.groupBox1.Controls.Add(this.lblTirePressure);
            this.groupBox1.Controls.Add(this.txtTirePressure);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 428);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Vehicle Assemble Details";
            // 
            // lblTransmissionType
            // 
            this.lblTransmissionType.AutoSize = true;
            this.lblTransmissionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmissionType.Location = new System.Drawing.Point(34, 200);
            this.lblTransmissionType.Name = "lblTransmissionType";
            this.lblTransmissionType.Size = new System.Drawing.Size(108, 13);
            this.lblTransmissionType.TabIndex = 25;
            this.lblTransmissionType.Text = "TransmissionType";
            // 
            // lblVariant
            // 
            this.lblVariant.AutoSize = true;
            this.lblVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariant.Location = new System.Drawing.Point(95, 71);
            this.lblVariant.Name = "lblVariant";
            this.lblVariant.Size = new System.Drawing.Size(47, 13);
            this.lblVariant.TabIndex = 24;
            this.lblVariant.Text = "Variant";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(157, 333);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(204, 21);
            this.cmbColor.TabIndex = 17;
            this.cmbColor.SelectedValueChanged += new System.EventHandler(this.cmbColor_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBoxWest);
            this.groupBox2.Controls.Add(this.chkBoxSouth);
            this.groupBox2.Controls.Add(this.chkBoxMWest);
            this.groupBox2.Controls.Add(this.chkBoxNorth);
            this.groupBox2.Location = new System.Drawing.Point(157, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 41);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // chkBoxWest
            // 
            this.chkBoxWest.AutoSize = true;
            this.chkBoxWest.Location = new System.Drawing.Point(220, 18);
            this.chkBoxWest.Name = "chkBoxWest";
            this.chkBoxWest.Size = new System.Drawing.Size(51, 17);
            this.chkBoxWest.TabIndex = 10;
            this.chkBoxWest.Text = "West";
            this.chkBoxWest.UseVisualStyleBackColor = true;
            this.chkBoxWest.CheckedChanged += new System.EventHandler(this.chkBoxWest_CheckedChanged);
            // 
            // chkBoxSouth
            // 
            this.chkBoxSouth.AutoSize = true;
            this.chkBoxSouth.Location = new System.Drawing.Point(160, 19);
            this.chkBoxSouth.Name = "chkBoxSouth";
            this.chkBoxSouth.Size = new System.Drawing.Size(54, 17);
            this.chkBoxSouth.TabIndex = 9;
            this.chkBoxSouth.Text = "South";
            this.chkBoxSouth.UseVisualStyleBackColor = true;
            this.chkBoxSouth.CheckedChanged += new System.EventHandler(this.chkBoxSouth_CheckedChanged);
            // 
            // chkBoxMWest
            // 
            this.chkBoxMWest.AutoSize = true;
            this.chkBoxMWest.Location = new System.Drawing.Point(83, 18);
            this.chkBoxMWest.Name = "chkBoxMWest";
            this.chkBoxMWest.Size = new System.Drawing.Size(71, 17);
            this.chkBoxMWest.TabIndex = 8;
            this.chkBoxMWest.Text = "Mid West";
            this.chkBoxMWest.UseVisualStyleBackColor = true;
            this.chkBoxMWest.CheckedChanged += new System.EventHandler(this.chkBoxMWest_CheckedChanged);
            // 
            // chkBoxNorth
            // 
            this.chkBoxNorth.AutoSize = true;
            this.chkBoxNorth.Location = new System.Drawing.Point(6, 19);
            this.chkBoxNorth.Name = "chkBoxNorth";
            this.chkBoxNorth.Size = new System.Drawing.Size(76, 17);
            this.chkBoxNorth.TabIndex = 7;
            this.chkBoxNorth.Text = "North East";
            this.chkBoxNorth.UseVisualStyleBackColor = true;
            this.chkBoxNorth.CheckedChanged += new System.EventHandler(this.chkBoxNorth_CheckedChanged);
            // 
            // gbTransmissionType
            // 
            this.gbTransmissionType.Controls.Add(this.rbAMT);
            this.gbTransmissionType.Controls.Add(this.rbIMT);
            this.gbTransmissionType.Controls.Add(this.rbAT);
            this.gbTransmissionType.Controls.Add(this.rbMT);
            this.gbTransmissionType.Location = new System.Drawing.Point(157, 173);
            this.gbTransmissionType.Name = "gbTransmissionType";
            this.gbTransmissionType.Size = new System.Drawing.Size(352, 50);
            this.gbTransmissionType.TabIndex = 11;
            this.gbTransmissionType.TabStop = false;
            // 
            // gbVariant
            // 
            this.gbVariant.Controls.Add(this.rbDomestic);
            this.gbVariant.Controls.Add(this.rbExport);
            this.gbVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVariant.Location = new System.Drawing.Point(157, 57);
            this.gbVariant.Name = "gbVariant";
            this.gbVariant.Size = new System.Drawing.Size(204, 37);
            this.gbVariant.TabIndex = 2;
            this.gbVariant.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(389, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "* Required Fields";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(137, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(137, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // lblAsterisk
            // 
            this.lblAsterisk.AutoSize = true;
            this.lblAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk.Location = new System.Drawing.Point(137, 32);
            this.lblAsterisk.Name = "lblAsterisk";
            this.lblAsterisk.Size = new System.Drawing.Size(14, 17);
            this.lblAsterisk.TabIndex = 18;
            this.lblAsterisk.Text = "*";
            // 
            // btnDisplaAllLines
            // 
            this.btnDisplaAllLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaAllLines.Location = new System.Drawing.Point(382, 9);
            this.btnDisplaAllLines.Name = "btnDisplaAllLines";
            this.btnDisplaAllLines.Size = new System.Drawing.Size(164, 36);
            this.btnDisplaAllLines.TabIndex = 18;
            this.btnDisplaAllLines.Text = "Display All Line Details";
            this.btnDisplaAllLines.UseVisualStyleBackColor = true;
            this.btnDisplaAllLines.Click += new System.EventHandler(this.btnDisplaAllLines_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 491);
            this.Controls.Add(this.btnDisplaAllLines);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Assemble Steps";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbTransmissionType.ResumeLayout(false);
            this.gbTransmissionType.PerformLayout();
            this.gbVariant.ResumeLayout(false);
            this.gbVariant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblVechicleProjCode;
        private System.Windows.Forms.TextBox txtVehicleProjCode;
        private System.Windows.Forms.RadioButton rbDomestic;
        private System.Windows.Forms.RadioButton rbExport;
        private System.Windows.Forms.Label lblTirePressure;
        private System.Windows.Forms.TextBox txtTirePressure;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.RadioButton rbAMT;
        private System.Windows.Forms.RadioButton rbIMT;
        private System.Windows.Forms.RadioButton rbAT;
        private System.Windows.Forms.RadioButton rbMT;
        private System.Windows.Forms.Label lblAssemblyProcess;
        private System.Windows.Forms.RichTextBox rtxtAssemblyProcess;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisplaAllLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAsterisk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbVariant;
        private System.Windows.Forms.GroupBox gbTransmissionType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBoxWest;
        private System.Windows.Forms.CheckBox chkBoxSouth;
        private System.Windows.Forms.CheckBox chkBoxMWest;
        private System.Windows.Forms.CheckBox chkBoxNorth;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblVariant;
        private System.Windows.Forms.Label lblTransmissionType;
    }
}

