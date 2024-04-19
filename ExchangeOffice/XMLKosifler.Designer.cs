using System.ComponentModel;
using System.Data.SqlClient;

namespace ExchangeOffice
{
    partial class XMLKosifler
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
        /// 
        private DatabaseManager dbManager;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLKosifler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEuroSelling = new System.Windows.Forms.Label();
            this.LblEuroBuying = new System.Windows.Forms.Label();
            this.LblDollarSelling = new System.Windows.Forms.Label();
            this.LblDollarBuying = new System.Windows.Forms.Label();
            this.BtnDBuy = new System.Windows.Forms.Button();
            this.BtnDSell = new System.Windows.Forms.Button();
            this.BtnEBuy = new System.Windows.Forms.Button();
            this.BtnESell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtReaminder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.BtnSell = new System.Windows.Forms.Button();
            this.TxtPiece = new System.Windows.Forms.TextBox();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(167, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar buying price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(167, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dollar selling price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(167, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Euro selling price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(167, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Euro buying price :";
            // 
            // LblEuroSelling
            // 
            this.LblEuroSelling.AutoSize = true;
            this.LblEuroSelling.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSelling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEuroSelling.Location = new System.Drawing.Point(387, 257);
            this.LblEuroSelling.Name = "LblEuroSelling";
            this.LblEuroSelling.Size = new System.Drawing.Size(21, 24);
            this.LblEuroSelling.TabIndex = 7;
            this.LblEuroSelling.Text = "0";
            // 
            // LblEuroBuying
            // 
            this.LblEuroBuying.AutoSize = true;
            this.LblEuroBuying.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroBuying.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEuroBuying.Location = new System.Drawing.Point(387, 209);
            this.LblEuroBuying.Name = "LblEuroBuying";
            this.LblEuroBuying.Size = new System.Drawing.Size(21, 24);
            this.LblEuroBuying.TabIndex = 6;
            this.LblEuroBuying.Text = "0";
            // 
            // LblDollarSelling
            // 
            this.LblDollarSelling.AutoSize = true;
            this.LblDollarSelling.BackColor = System.Drawing.Color.Transparent;
            this.LblDollarSelling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDollarSelling.Location = new System.Drawing.Point(387, 157);
            this.LblDollarSelling.Name = "LblDollarSelling";
            this.LblDollarSelling.Size = new System.Drawing.Size(21, 24);
            this.LblDollarSelling.TabIndex = 5;
            this.LblDollarSelling.Text = "0";
            // 
            // LblDollarBuying
            // 
            this.LblDollarBuying.AutoSize = true;
            this.LblDollarBuying.BackColor = System.Drawing.Color.Transparent;
            this.LblDollarBuying.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDollarBuying.Location = new System.Drawing.Point(387, 109);
            this.LblDollarBuying.Name = "LblDollarBuying";
            this.LblDollarBuying.Size = new System.Drawing.Size(21, 24);
            this.LblDollarBuying.TabIndex = 4;
            this.LblDollarBuying.Text = "0";
            // 
            // BtnDBuy
            // 
            this.BtnDBuy.Location = new System.Drawing.Point(492, 97);
            this.BtnDBuy.Name = "BtnDBuy";
            this.BtnDBuy.Size = new System.Drawing.Size(41, 36);
            this.BtnDBuy.TabIndex = 8;
            this.BtnDBuy.Text = "...";
            this.BtnDBuy.UseVisualStyleBackColor = true;
            this.BtnDBuy.Click += new System.EventHandler(this.BtnDBuy_Click);
            // 
            // BtnDSell
            // 
            this.BtnDSell.Location = new System.Drawing.Point(492, 145);
            this.BtnDSell.Name = "BtnDSell";
            this.BtnDSell.Size = new System.Drawing.Size(41, 36);
            this.BtnDSell.TabIndex = 9;
            this.BtnDSell.Text = "...";
            this.BtnDSell.UseVisualStyleBackColor = true;
            this.BtnDSell.Click += new System.EventHandler(this.BtnDSell_Click);
            // 
            // BtnEBuy
            // 
            this.BtnEBuy.Location = new System.Drawing.Point(492, 197);
            this.BtnEBuy.Name = "BtnEBuy";
            this.BtnEBuy.Size = new System.Drawing.Size(41, 36);
            this.BtnEBuy.TabIndex = 10;
            this.BtnEBuy.Text = "...";
            this.BtnEBuy.UseVisualStyleBackColor = true;
            this.BtnEBuy.Click += new System.EventHandler(this.BtnEBuy_Click);
            // 
            // BtnESell
            // 
            this.BtnESell.Location = new System.Drawing.Point(492, 245);
            this.BtnESell.Name = "BtnESell";
            this.BtnESell.Size = new System.Drawing.Size(41, 36);
            this.BtnESell.TabIndex = 11;
            this.BtnESell.Text = "...";
            this.BtnESell.UseVisualStyleBackColor = true;
            this.BtnESell.Click += new System.EventHandler(this.BtnESell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtReaminder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnBuy);
            this.groupBox1.Controls.Add(this.TxtAmount);
            this.groupBox1.Controls.Add(this.BtnSell);
            this.groupBox1.Controls.Add(this.TxtPiece);
            this.groupBox1.Controls.Add(this.TxtRate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(562, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 214);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // TxtReaminder
            // 
            this.TxtReaminder.Location = new System.Drawing.Point(167, 132);
            this.TxtReaminder.Name = "TxtReaminder";
            this.TxtReaminder.Size = new System.Drawing.Size(211, 30);
            this.TxtReaminder.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(45, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remainder :";
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBuy.Location = new System.Drawing.Point(167, 168);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(99, 31);
            this.BtnBuy.TabIndex = 8;
            this.BtnBuy.Text = "Buy";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(167, 96);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(211, 30);
            this.TxtAmount.TabIndex = 7;
            // 
            // BtnSell
            // 
            this.BtnSell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSell.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSell.Location = new System.Drawing.Point(269, 168);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(103, 31);
            this.BtnSell.TabIndex = 4;
            this.BtnSell.Text = "Sell";
            this.BtnSell.UseVisualStyleBackColor = false;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // TxtPiece
            // 
            this.TxtPiece.Location = new System.Drawing.Point(167, 60);
            this.TxtPiece.Name = "TxtPiece";
            this.TxtPiece.Size = new System.Drawing.Size(211, 30);
            this.TxtPiece.TabIndex = 6;
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(167, 24);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(211, 30);
            this.TxtRate.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(69, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Amount :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(92, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 24);
            this.label20.TabIndex = 1;
            this.label20.Text = "Piece :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "KosiflerExchange rate :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 123);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // XMLKosifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1061, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnESell);
            this.Controls.Add(this.BtnEBuy);
            this.Controls.Add(this.BtnDSell);
            this.Controls.Add(this.BtnDBuy);
            this.Controls.Add(this.LblEuroSelling);
            this.Controls.Add(this.LblEuroBuying);
            this.Controls.Add(this.LblDollarSelling);
            this.Controls.Add(this.LblDollarBuying);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "XMLKosifler";
            this.Text = "XMLKosifler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEuroSelling;
        private System.Windows.Forms.Label LblEuroBuying;
        private System.Windows.Forms.Label LblDollarSelling;
        private System.Windows.Forms.Label LblDollarBuying;
        private System.Windows.Forms.Button BtnDBuy;
        private System.Windows.Forms.Button BtnDSell;
        private System.Windows.Forms.Button BtnEBuy;
        private System.Windows.Forms.Button BtnESell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.TextBox TxtPiece;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.TextBox TxtReaminder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

