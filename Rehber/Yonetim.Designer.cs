using System.Drawing;
using System.Windows.Forms;

namespace Rehber
{
    partial class Yonetim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adTB = new System.Windows.Forms.TextBox();
            this.soyadTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telTB = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OpenSymbol", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OpenSymbol", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // adTB
            // 
            this.adTB.Font = new System.Drawing.Font("OpenSymbol", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adTB.Location = new System.Drawing.Point(169, 36);
            this.adTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adTB.Name = "adTB";
            this.adTB.Size = new System.Drawing.Size(257, 47);
            this.adTB.TabIndex = 2;
            this.adTB.TextChanged += new System.EventHandler(this.adTB_TextChanged);
            // 
            // soyadTB
            // 
            this.soyadTB.Font = new System.Drawing.Font("OpenSymbol", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadTB.Location = new System.Drawing.Point(169, 94);
            this.soyadTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyadTB.Name = "soyadTB";
            this.soyadTB.Size = new System.Drawing.Size(257, 47);
            this.soyadTB.TabIndex = 3;
            this.soyadTB.TextChanged += new System.EventHandler(this.soyadTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OpenSymbol", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "TelNo:";
            // 
            // telTB
            // 
            this.telTB.Font = new System.Drawing.Font("OpenSymbol", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telTB.Location = new System.Drawing.Point(169, 158);
            this.telTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telTB.Name = "telTB";
            this.telTB.Size = new System.Drawing.Size(257, 47);
            this.telTB.TabIndex = 5;
            this.telTB.TextChanged += new System.EventHandler(this.telTB_TextChanged);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("OpenSymbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleBtn.Location = new System.Drawing.Point(121, 234);
            this.ekleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(264, 96);
            this.ekleBtn.TabIndex = 6;
            this.ekleBtn.Text = "➕ Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Font = new System.Drawing.Font("OpenSymbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silBtn.Location = new System.Drawing.Point(121, 352);
            this.silBtn.Margin = new System.Windows.Forms.Padding(4);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(264, 96);
            this.silBtn.TabIndex = 7;
            this.silBtn.Text = "❌ Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Font = new System.Drawing.Font("OpenSymbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleBtn.Location = new System.Drawing.Point(121, 469);
            this.guncelleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(264, 96);
            this.guncelleBtn.TabIndex = 8;
            this.guncelleBtn.Text = "🔄 Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("OpenSymbol", 12.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(435, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(791, 647);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1241, 702);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.telTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadTB);
            this.Controls.Add(this.adTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Yonetim";
            this.Text = "Yönetim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adTB;
        private System.Windows.Forms.TextBox soyadTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telTB;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}