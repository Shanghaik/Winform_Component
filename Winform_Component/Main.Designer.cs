namespace Winform_Component
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Show = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_next = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.lb_page = new System.Windows.Forms.Label();
            this.tlpn_data = new System.Windows.Forms.TableLayoutPanel();
            this.timer_Time = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Show.Location = new System.Drawing.Point(6, 3);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(185, 61);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Sản phẩm";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_next);
            this.panel1.Controls.Add(this.lb_back);
            this.panel1.Controls.Add(this.lb_page);
            this.panel1.Controls.Add(this.tlpn_data);
            this.panel1.Location = new System.Drawing.Point(204, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 564);
            this.panel1.TabIndex = 2;
            // 
            // lb_next
            // 
            this.lb_next.AutoSize = true;
            this.lb_next.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_next.Location = new System.Drawing.Point(436, 533);
            this.lb_next.Name = "lb_next";
            this.lb_next.Size = new System.Drawing.Size(48, 25);
            this.lb_next.TabIndex = 3;
            this.lb_next.Text = ">>>";
            this.lb_next.Click += new System.EventHandler(this.lb_next_Click);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_back.Location = new System.Drawing.Point(323, 533);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(48, 25);
            this.lb_back.TabIndex = 2;
            this.lb_back.Text = "<<<";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // lb_page
            // 
            this.lb_page.AutoSize = true;
            this.lb_page.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lb_page.Location = new System.Drawing.Point(389, 533);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(21, 25);
            this.lb_page.TabIndex = 1;
            this.lb_page.Text = "1";
       
            // 
            // tlpn_data
            // 
            this.tlpn_data.ColumnCount = 2;
            this.tlpn_data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpn_data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpn_data.Location = new System.Drawing.Point(3, 4);
            this.tlpn_data.Name = "tlpn_data";
            this.tlpn_data.RowCount = 2;
            this.tlpn_data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpn_data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpn_data.Size = new System.Drawing.Size(794, 526);
            this.tlpn_data.TabIndex = 0;
            // 
            // timer_Time
            // 
            this.timer_Time.Tick += new System.EventHandler(this.timer_Time_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(70, 545);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(18, 20);
            this.lb_time.TabIndex = 3;
            this.lb_time.Text = "...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 577);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Show);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Show;
        private Panel panel1;
        private TableLayoutPanel tlpn_data;
        private Label lb_next;
        private Label lb_back;
        private Label lb_page;
        private System.Windows.Forms.Timer timer_Time;
        private Label lb_time;
    }
}