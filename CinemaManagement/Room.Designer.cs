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
            this.pnlImg = new System.Windows.Forms.Panel();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.pnlSeat = new System.Windows.Forms.Panel();
            this.pnlRoom.SuspendLayout();
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
            this.pnlRoom.Controls.Add(this.pnlSeat);
            this.pnlRoom.Controls.Add(this.pnlName);
            this.pnlRoom.Location = new System.Drawing.Point(601, 63);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(1274, 757);
            this.pnlRoom.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Location = new System.Drawing.Point(155, 852);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1720, 100);
            this.pnlControl.TabIndex = 2;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlName.Location = new System.Drawing.Point(293, 42);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(688, 76);
            this.pnlName.TabIndex = 0;
            // 
            // pnlSeat
            // 
            this.pnlSeat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSeat.Location = new System.Drawing.Point(174, 164);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(923, 547);
            this.pnlSeat.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Panel pnlSeat;
    }
}