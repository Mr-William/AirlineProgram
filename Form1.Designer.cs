
namespace Gibbs_Assignment10
{
    partial class Form1
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
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnInternationalFlights = new System.Windows.Forms.Button();
            this.btnDomestic = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnListPassengers = new System.Windows.Forms.Button();
            this.lstFlightCode = new System.Windows.Forms.ListView();
            this.lblCurrentlyListing = new System.Windows.Forms.Label();
            this.lblViewing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDeparture = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDestinations = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPassengers = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lstPassport = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMeals = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(86, 84);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(275, 93);
            this.btnListAll.TabIndex = 0;
            this.btnListAll.Text = "List All Flights";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnInternationalFlights
            // 
            this.btnInternationalFlights.Location = new System.Drawing.Point(86, 205);
            this.btnInternationalFlights.Name = "btnInternationalFlights";
            this.btnInternationalFlights.Size = new System.Drawing.Size(275, 93);
            this.btnInternationalFlights.TabIndex = 1;
            this.btnInternationalFlights.Text = "International Flights";
            this.btnInternationalFlights.UseVisualStyleBackColor = true;
            this.btnInternationalFlights.Click += new System.EventHandler(this.btnInternationalFlights_Click);
            // 
            // btnDomestic
            // 
            this.btnDomestic.Location = new System.Drawing.Point(86, 316);
            this.btnDomestic.Name = "btnDomestic";
            this.btnDomestic.Size = new System.Drawing.Size(275, 93);
            this.btnDomestic.TabIndex = 2;
            this.btnDomestic.Text = "Domestic Flights";
            this.btnDomestic.UseVisualStyleBackColor = true;
            this.btnDomestic.Click += new System.EventHandler(this.btnDomestic_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(86, 425);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(275, 135);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.Text = "Make a Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnListPassengers
            // 
            this.btnListPassengers.Location = new System.Drawing.Point(86, 587);
            this.btnListPassengers.Name = "btnListPassengers";
            this.btnListPassengers.Size = new System.Drawing.Size(275, 161);
            this.btnListPassengers.TabIndex = 4;
            this.btnListPassengers.Text = "List Passengers";
            this.btnListPassengers.UseVisualStyleBackColor = true;
            this.btnListPassengers.Click += new System.EventHandler(this.btnListPassengers_Click);
            // 
            // lstFlightCode
            // 
            this.lstFlightCode.HideSelection = false;
            this.lstFlightCode.Location = new System.Drawing.Point(504, 205);
            this.lstFlightCode.Name = "lstFlightCode";
            this.lstFlightCode.Size = new System.Drawing.Size(213, 569);
            this.lstFlightCode.TabIndex = 5;
            this.lstFlightCode.UseCompatibleStateImageBehavior = false;
            this.lstFlightCode.View = System.Windows.Forms.View.List;
            // 
            // lblCurrentlyListing
            // 
            this.lblCurrentlyListing.AutoSize = true;
            this.lblCurrentlyListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentlyListing.Location = new System.Drawing.Point(497, 84);
            this.lblCurrentlyListing.Name = "lblCurrentlyListing";
            this.lblCurrentlyListing.Size = new System.Drawing.Size(275, 37);
            this.lblCurrentlyListing.TabIndex = 6;
            this.lblCurrentlyListing.Text = "Currently Listing:";
            // 
            // lblViewing
            // 
            this.lblViewing.AutoSize = true;
            this.lblViewing.Location = new System.Drawing.Point(778, 47);
            this.lblViewing.Name = "lblViewing";
            this.lblViewing.Size = new System.Drawing.Size(579, 74);
            this.lblViewing.TabIndex = 7;
            this.lblViewing.Text = "\r\nMake a Selection on the Left to begin....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Flight Code:";
            // 
            // lstDeparture
            // 
            this.lstDeparture.HideSelection = false;
            this.lstDeparture.Location = new System.Drawing.Point(756, 205);
            this.lstDeparture.Name = "lstDeparture";
            this.lstDeparture.Size = new System.Drawing.Size(545, 569);
            this.lstDeparture.TabIndex = 9;
            this.lstDeparture.UseCompatibleStateImageBehavior = false;
            this.lstDeparture.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(749, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departure Date:";
            // 
            // lstDestinations
            // 
            this.lstDestinations.HideSelection = false;
            this.lstDestinations.Location = new System.Drawing.Point(1335, 205);
            this.lstDestinations.Name = "lstDestinations";
            this.lstDestinations.Size = new System.Drawing.Size(846, 569);
            this.lstDestinations.TabIndex = 11;
            this.lstDestinations.UseCompatibleStateImageBehavior = false;
            this.lstDestinations.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1321, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Destination:";
            // 
            // lstPassengers
            // 
            this.lstPassengers.HideSelection = false;
            this.lstPassengers.Location = new System.Drawing.Point(2765, 205);
            this.lstPassengers.Name = "lstPassengers";
            this.lstPassengers.Size = new System.Drawing.Size(585, 569);
            this.lstPassengers.TabIndex = 13;
            this.lstPassengers.UseCompatibleStateImageBehavior = false;
            this.lstPassengers.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2758, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "Passengers:";
            // 
            // lstPassport
            // 
            this.lstPassport.HideSelection = false;
            this.lstPassport.Location = new System.Drawing.Point(2209, 205);
            this.lstPassport.Name = "lstPassport";
            this.lstPassport.Size = new System.Drawing.Size(237, 569);
            this.lstPassport.TabIndex = 15;
            this.lstPassport.UseCompatibleStateImageBehavior = false;
            this.lstPassport.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2202, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "Passport Req\'d:";
            // 
            // lstMeals
            // 
            this.lstMeals.HideSelection = false;
            this.lstMeals.Location = new System.Drawing.Point(2484, 205);
            this.lstMeals.Name = "lstMeals";
            this.lstMeals.Size = new System.Drawing.Size(237, 569);
            this.lstMeals.TabIndex = 17;
            this.lstMeals.UseCompatibleStateImageBehavior = false;
            this.lstMeals.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2477, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Meal Provided:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3362, 1652);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstMeals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstPassport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPassengers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstDestinations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDeparture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblViewing);
            this.Controls.Add(this.lblCurrentlyListing);
            this.Controls.Add(this.lstFlightCode);
            this.Controls.Add(this.btnListPassengers);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnDomestic);
            this.Controls.Add(this.btnInternationalFlights);
            this.Controls.Add(this.btnListAll);
            this.Name = "Form1";
            this.Text = "Airline Flights";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnInternationalFlights;
        private System.Windows.Forms.Button btnDomestic;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnListPassengers;
        private System.Windows.Forms.ListView lstFlightCode;
        private System.Windows.Forms.Label lblCurrentlyListing;
        private System.Windows.Forms.Label lblViewing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstDeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstDestinations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstPassengers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstPassport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstMeals;
        private System.Windows.Forms.Label label6;
    }
}

