
namespace Gibbs_Assignment10
{
    partial class AddPassenger
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
            this.rdoInternational = new System.Windows.Forms.RadioButton();
            this.rdoDomestic = new System.Windows.Forms.RadioButton();
            this.grpPassengerType = new System.Windows.Forms.GroupBox();
            this.cboDestinations = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.grpPassengerType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoInternational
            // 
            this.rdoInternational.AutoSize = true;
            this.rdoInternational.Checked = true;
            this.rdoInternational.Location = new System.Drawing.Point(6, 64);
            this.rdoInternational.Name = "rdoInternational";
            this.rdoInternational.Size = new System.Drawing.Size(237, 41);
            this.rdoInternational.TabIndex = 0;
            this.rdoInternational.TabStop = true;
            this.rdoInternational.Text = "International";
            this.rdoInternational.UseVisualStyleBackColor = true;
            this.rdoInternational.CheckedChanged += new System.EventHandler(this.rdoInternational_CheckedChanged);
            // 
            // rdoDomestic
            // 
            this.rdoDomestic.AutoSize = true;
            this.rdoDomestic.Location = new System.Drawing.Point(6, 111);
            this.rdoDomestic.Name = "rdoDomestic";
            this.rdoDomestic.Size = new System.Drawing.Size(194, 41);
            this.rdoDomestic.TabIndex = 1;
            this.rdoDomestic.Text = "Domestic";
            this.rdoDomestic.UseVisualStyleBackColor = true;
            this.rdoDomestic.CheckedChanged += new System.EventHandler(this.rdoDomestic_CheckedChanged);
            // 
            // grpPassengerType
            // 
            this.grpPassengerType.Controls.Add(this.rdoInternational);
            this.grpPassengerType.Controls.Add(this.rdoDomestic);
            this.grpPassengerType.Location = new System.Drawing.Point(12, 12);
            this.grpPassengerType.Name = "grpPassengerType";
            this.grpPassengerType.Size = new System.Drawing.Size(446, 197);
            this.grpPassengerType.TabIndex = 2;
            this.grpPassengerType.TabStop = false;
            this.grpPassengerType.Text = "Select Travel Type";
            // 
            // cboDestinations
            // 
            this.cboDestinations.FormattingEnabled = true;
            this.cboDestinations.Location = new System.Drawing.Point(6, 43);
            this.cboDestinations.Name = "cboDestinations";
            this.cboDestinations.Size = new System.Drawing.Size(1053, 45);
            this.cboDestinations.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDestinations);
            this.groupBox1.Location = new System.Drawing.Point(18, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 213);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Destination";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(504, 486);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(241, 75);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(241, 75);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Passenger Name:";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(504, 165);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(374, 44);
            this.txtPassengerName.TabIndex = 8;
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 596);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPassengerType);
            this.Name = "AddPassenger";
            this.Text = "Add Passenger";
            this.Load += new System.EventHandler(this.AddPassenger_Load);
            this.grpPassengerType.ResumeLayout(false);
            this.grpPassengerType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoInternational;
        private System.Windows.Forms.RadioButton rdoDomestic;
        private System.Windows.Forms.GroupBox grpPassengerType;
        private System.Windows.Forms.ComboBox cboDestinations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassengerName;
    }
}