using System.Windows.Forms;

namespace Minesweeper
{
    partial class Setup
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
            this.MinesTrack = new System.Windows.Forms.TrackBar();
            this.SizeXTrack = new System.Windows.Forms.TrackBar();
            this.SizeYTrack = new System.Windows.Forms.TrackBar();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MineLbl = new System.Windows.Forms.Label();
            this.SizeXLbl = new System.Windows.Forms.Label();
            this.SizeYLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinesTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeXTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeYTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // MinesTrack
            // 
            this.MinesTrack.Location = new System.Drawing.Point(12, 42);
            this.MinesTrack.Maximum = 100;
            this.MinesTrack.Name = "MinesTrack";
            this.MinesTrack.Size = new System.Drawing.Size(310, 45);
            this.MinesTrack.TabIndex = 0;
            this.MinesTrack.Value = 30;
            this.MinesTrack.Scroll += new System.EventHandler(this.MinesTrack_Scroll);
            // 
            // SizeXTrack
            // 
            this.SizeXTrack.Location = new System.Drawing.Point(12, 123);
            this.SizeXTrack.Maximum = 50;
            this.SizeXTrack.Name = "SizeXTrack";
            this.SizeXTrack.Size = new System.Drawing.Size(310, 45);
            this.SizeXTrack.TabIndex = 1;
            this.SizeXTrack.Value = 30;
            this.SizeXTrack.Scroll += new System.EventHandler(this.SizeXTrack_Scroll);
            // 
            // SizeYTrack
            // 
            this.SizeYTrack.Location = new System.Drawing.Point(12, 204);
            this.SizeYTrack.Maximum = 50;
            this.SizeYTrack.Name = "SizeYTrack";
            this.SizeYTrack.Size = new System.Drawing.Size(310, 45);
            this.SizeYTrack.TabIndex = 2;
            this.SizeYTrack.Value = 20;
            this.SizeYTrack.Scroll += new System.EventHandler(this.SizeYTrack_Scroll);
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(12, 264);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(310, 35);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mines, %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size Y";
            // 
            // MineLbl
            // 
            this.MineLbl.AutoSize = true;
            this.MineLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MineLbl.Location = new System.Drawing.Point(287, 9);
            this.MineLbl.Name = "MineLbl";
            this.MineLbl.Size = new System.Drawing.Size(35, 30);
            this.MineLbl.TabIndex = 4;
            this.MineLbl.Text = "30";
            // 
            // SizeXLbl
            // 
            this.SizeXLbl.AutoSize = true;
            this.SizeXLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeXLbl.Location = new System.Drawing.Point(287, 90);
            this.SizeXLbl.Name = "SizeXLbl";
            this.SizeXLbl.Size = new System.Drawing.Size(35, 30);
            this.SizeXLbl.TabIndex = 4;
            this.SizeXLbl.Text = "30";
            // 
            // SizeYLbl
            // 
            this.SizeYLbl.AutoSize = true;
            this.SizeYLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeYLbl.Location = new System.Drawing.Point(287, 171);
            this.SizeYLbl.Name = "SizeYLbl";
            this.SizeYLbl.Size = new System.Drawing.Size(35, 30);
            this.SizeYLbl.TabIndex = 4;
            this.SizeYLbl.Text = "20";
            // 
            // Setup
            // 
            this.AcceptButton = this.StartBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeYLbl);
            this.Controls.Add(this.SizeXLbl);
            this.Controls.Add(this.MineLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SizeYTrack);
            this.Controls.Add(this.SizeXTrack);
            this.Controls.Add(this.MinesTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.MinesTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeXTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeYTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar MinesTrack;
        private TrackBar SizeXTrack;
        private TrackBar SizeYTrack;
        private Button StartBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label MineLbl;
        private Label SizeXLbl;
        private Label SizeYLbl;
    }
}