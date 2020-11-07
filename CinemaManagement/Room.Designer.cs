namespace CinemaManagement
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.pnlImg = new System.Windows.Forms.Panel();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lblScreen = new System.Windows.Forms.Label();
            this.pnlSeat = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtChoose = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlRoom.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.Location = new System.Drawing.Point(155, 141);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(410, 548);
            this.pnlImg.TabIndex = 0;
            // 
            // pnlRoom
            // 
            this.pnlRoom.Controls.Add(this.pnlName);
            this.pnlRoom.Controls.Add(this.pnlSeat);
            this.pnlRoom.Location = new System.Drawing.Point(601, 63);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(1274, 757);
            this.pnlRoom.TabIndex = 1;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlName.Controls.Add(this.lblScreen);
            this.pnlName.Location = new System.Drawing.Point(313, 40);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(658, 101);
            this.pnlName.TabIndex = 3;
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font(".VnArial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.Location = new System.Drawing.Point(223, 18);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(231, 73);
            this.lblScreen.TabIndex = 2;
            this.lblScreen.Text = "Screen";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeat
            // 
            this.pnlSeat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSeat.Location = new System.Drawing.Point(174, 164);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(923, 547);
            this.pnlSeat.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtChoose);
            this.pnlControl.Controls.Add(this.btnContinue);
            this.pnlControl.Controls.Add(this.btnBack);
            this.pnlControl.Location = new System.Drawing.Point(155, 852);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1720, 100);
            this.pnlControl.TabIndex = 2;
            // 
            // txtChoose
            // 
            this.txtChoose.Enabled = false;
            this.txtChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoose.Location = new System.Drawing.Point(409, 22);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(918, 61);
            this.txtChoose.TabIndex = 2;
            // 
            // btnContinue
            // 
            this.btnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinue.BackgroundImage")));
            this.btnContinue.Location = new System.Drawing.Point(1618, 3);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(99, 94);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::CinemaManagement.Properties.Resources.ContinuesImg;
            this.btnBack.Location = new System.Drawing.Point(3, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 94);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaManagement.Properties.Resources.bg_red;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlRoom);
            this.Controls.Add(this.pnlImg);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.pnlRoom.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlSeat;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.TextBox txtChoose;
    }
}