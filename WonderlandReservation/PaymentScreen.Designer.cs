namespace WonderlandReservation
{
    partial class PaymentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passesButton = new System.Windows.Forms.Button();
            this.diningButton = new System.Windows.Forms.Button();
            this.parkingButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.ticketButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.priceOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passesButton
            // 
            this.passesButton.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passesButton.Location = new System.Drawing.Point(169, 21);
            this.passesButton.Name = "passesButton";
            this.passesButton.Size = new System.Drawing.Size(145, 36);
            this.passesButton.TabIndex = 20;
            this.passesButton.Text = "Passes";
            this.passesButton.UseVisualStyleBackColor = true;
            this.passesButton.Click += new System.EventHandler(this.passesButton_Click);
            // 
            // diningButton
            // 
            this.diningButton.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diningButton.Location = new System.Drawing.Point(320, 21);
            this.diningButton.Name = "diningButton";
            this.diningButton.Size = new System.Drawing.Size(145, 36);
            this.diningButton.TabIndex = 19;
            this.diningButton.Text = "Dining";
            this.diningButton.UseVisualStyleBackColor = true;
            this.diningButton.Click += new System.EventHandler(this.diningButton_Click);
            // 
            // parkingButton
            // 
            this.parkingButton.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingButton.Location = new System.Drawing.Point(471, 21);
            this.parkingButton.Name = "parkingButton";
            this.parkingButton.Size = new System.Drawing.Size(145, 36);
            this.parkingButton.TabIndex = 18;
            this.parkingButton.Text = "Parking";
            this.parkingButton.UseVisualStyleBackColor = true;
            this.parkingButton.Click += new System.EventHandler(this.parkingButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.Location = new System.Drawing.Point(622, 21);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(145, 36);
            this.paymentButton.TabIndex = 17;
            this.paymentButton.Text = "Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // ticketButton
            // 
            this.ticketButton.BackColor = System.Drawing.Color.Transparent;
            this.ticketButton.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketButton.Location = new System.Drawing.Point(18, 21);
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.Size = new System.Drawing.Size(145, 36);
            this.ticketButton.TabIndex = 16;
            this.ticketButton.Text = "Tickets";
            this.ticketButton.UseVisualStyleBackColor = false;
            this.ticketButton.Click += new System.EventHandler(this.ticketButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.MintCream;
            this.outputLabel.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(15, 131);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(360, 354);
            this.outputLabel.TabIndex = 21;
            this.outputLabel.Text = "label1";
            // 
            // priceOutput
            // 
            this.priceOutput.BackColor = System.Drawing.Color.MintCream;
            this.priceOutput.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutput.Location = new System.Drawing.Point(407, 131);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(360, 129);
            this.priceOutput.TabIndex = 22;
            this.priceOutput.Text = "price";
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.priceOutput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.passesButton);
            this.Controls.Add(this.diningButton);
            this.Controls.Add(this.parkingButton);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.ticketButton);
            this.Name = "PaymentScreen";
            this.Size = new System.Drawing.Size(790, 680);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passesButton;
        private System.Windows.Forms.Button diningButton;
        private System.Windows.Forms.Button parkingButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button ticketButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label priceOutput;
    }
}
