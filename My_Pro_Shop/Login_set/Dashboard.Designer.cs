namespace My_Pro_Shop.Login_set
{
    partial class Dashboard
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
            this.panel_Main_Dash = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonButton_billing = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton_worker = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton_loan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton_add_pro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main_Dash
            // 
            this.panel_Main_Dash.BackColor = System.Drawing.Color.Snow;
            this.panel_Main_Dash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_Dash.Location = new System.Drawing.Point(0, 147);
            this.panel_Main_Dash.Name = "panel_Main_Dash";
            this.panel_Main_Dash.Size = new System.Drawing.Size(1383, 582);
            this.panel_Main_Dash.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creating by Hamooth @2024";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1383, 85);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton_billing, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton_worker, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton_loan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton_add_pro, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1383, 85);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // kryptonButton_billing
            // 
            this.kryptonButton_billing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton_billing.Location = new System.Drawing.Point(3, 3);
            this.kryptonButton_billing.Name = "kryptonButton_billing";
            this.kryptonButton_billing.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton_billing.Size = new System.Drawing.Size(339, 79);
            this.kryptonButton_billing.StateCommon.Back.Color1 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_billing.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_billing.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton_billing.TabIndex = 0;
            this.kryptonButton_billing.Values.Image = global::My_Pro_Shop.Properties.Resources.cashier;
            this.kryptonButton_billing.Values.Text = "BILLING";
            // 
            // kryptonButton_worker
            // 
            this.kryptonButton_worker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton_worker.Location = new System.Drawing.Point(693, 3);
            this.kryptonButton_worker.Name = "kryptonButton_worker";
            this.kryptonButton_worker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton_worker.Size = new System.Drawing.Size(339, 79);
            this.kryptonButton_worker.StateCommon.Back.Color1 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_worker.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_worker.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton_worker.TabIndex = 3;
            this.kryptonButton_worker.Values.Image = global::My_Pro_Shop.Properties.Resources.working_man;
            this.kryptonButton_worker.Values.Text = "WORKER";
            // 
            // kryptonButton_loan
            // 
            this.kryptonButton_loan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton_loan.Location = new System.Drawing.Point(348, 3);
            this.kryptonButton_loan.Name = "kryptonButton_loan";
            this.kryptonButton_loan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton_loan.Size = new System.Drawing.Size(339, 79);
            this.kryptonButton_loan.StateCommon.Back.Color1 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_loan.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_loan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton_loan.TabIndex = 1;
            this.kryptonButton_loan.Values.Image = global::My_Pro_Shop.Properties.Resources.loan;
            this.kryptonButton_loan.Values.Text = "LOAN";
            // 
            // kryptonButton_add_pro
            // 
            this.kryptonButton_add_pro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton_add_pro.Location = new System.Drawing.Point(1038, 3);
            this.kryptonButton_add_pro.Name = "kryptonButton_add_pro";
            this.kryptonButton_add_pro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton_add_pro.Size = new System.Drawing.Size(342, 79);
            this.kryptonButton_add_pro.StateCommon.Back.Color1 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_add_pro.StateCommon.Back.Color2 = System.Drawing.Color.BurlyWood;
            this.kryptonButton_add_pro.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Rockwell", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton_add_pro.TabIndex = 2;
            this.kryptonButton_add_pro.Values.Image = global::My_Pro_Shop.Properties.Resources.add_to_cart;
            this.kryptonButton_add_pro.Values.Text = "ADD PRO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(1310, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(579, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCustom1;
            this.kryptonPanel1.Size = new System.Drawing.Size(1383, 62);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.label2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 729);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCustom2;
            this.kryptonPanel2.Size = new System.Drawing.Size(1383, 29);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPanel2.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 758);
            this.Controls.Add(this.panel_Main_Dash);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_Dash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton_worker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton_add_pro;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton_loan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton_billing;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}