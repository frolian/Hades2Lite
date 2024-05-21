namespace Hades2Lite
{
    partial class ServicesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.button_stop_service = new System.Windows.Forms.Button();
            this.button_start_service = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.textBox_status_filter = new System.Windows.Forms.TextBox();
            this.groupBox_szukaj = new System.Windows.Forms.GroupBox();
            this.textBox_displayName_filter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_servicename_filter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_services = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_services = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_start = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panelbottom.SuspendLayout();
            this.groupBox_szukaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_services)).BeginInit();
            this.contextMenuStrip_services.SuspendLayout();
            this.panelcenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.Location = new System.Drawing.Point(638, 18);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(145, 40);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Zamknij";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_restart.Location = new System.Drawing.Point(321, 34);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(150, 40);
            this.btn_restart.TabIndex = 3;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // button_stop_service
            // 
            this.button_stop_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_stop_service.Location = new System.Drawing.Point(168, 34);
            this.button_stop_service.Name = "button_stop_service";
            this.button_stop_service.Size = new System.Drawing.Size(150, 40);
            this.button_stop_service.TabIndex = 2;
            this.button_stop_service.Text = "Stop";
            this.button_stop_service.UseVisualStyleBackColor = true;
            // 
            // button_start_service
            // 
            this.button_start_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start_service.Location = new System.Drawing.Point(13, 34);
            this.button_start_service.Name = "button_start_service";
            this.button_start_service.Size = new System.Drawing.Size(150, 40);
            this.button_start_service.TabIndex = 1;
            this.button_start_service.Text = "Start";
            this.button_start_service.UseVisualStyleBackColor = true;
            this.button_start_service.Click += new System.EventHandler(this.button_start_service_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_restart);
            this.groupBox1.Controls.Add(this.button_stop_service);
            this.groupBox1.Controls.Add(this.button_start_service);
            this.groupBox1.Location = new System.Drawing.Point(309, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(480, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacje na usługach";
            // 
            // panelbottom
            // 
            this.panelbottom.Controls.Add(this.button_close);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(5, 371);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(790, 74);
            this.panelbottom.TabIndex = 2;
            // 
            // textBox_status_filter
            // 
            this.textBox_status_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_status_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_status_filter.Location = new System.Drawing.Point(106, 38);
            this.textBox_status_filter.Name = "textBox_status_filter";
            this.textBox_status_filter.Size = new System.Drawing.Size(165, 21);
            this.textBox_status_filter.TabIndex = 7;
            // 
            // groupBox_szukaj
            // 
            this.groupBox_szukaj.Controls.Add(this.textBox_status_filter);
            this.groupBox_szukaj.Controls.Add(this.textBox_displayName_filter);
            this.groupBox_szukaj.Controls.Add(this.label3);
            this.groupBox_szukaj.Controls.Add(this.label2);
            this.groupBox_szukaj.Controls.Add(this.textBox_servicename_filter);
            this.groupBox_szukaj.Controls.Add(this.label1);
            this.groupBox_szukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_szukaj.Location = new System.Drawing.Point(1, 7);
            this.groupBox_szukaj.Name = "groupBox_szukaj";
            this.groupBox_szukaj.Size = new System.Drawing.Size(291, 94);
            this.groupBox_szukaj.TabIndex = 6;
            this.groupBox_szukaj.TabStop = false;
            this.groupBox_szukaj.Text = "Szukaj";
            // 
            // textBox_displayName_filter
            // 
            this.textBox_displayName_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_displayName_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_displayName_filter.Location = new System.Drawing.Point(106, 62);
            this.textBox_displayName_filter.Name = "textBox_displayName_filter";
            this.textBox_displayName_filter.Size = new System.Drawing.Size(165, 21);
            this.textBox_displayName_filter.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(32, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis usługi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(68, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_servicename_filter
            // 
            this.textBox_servicename_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_servicename_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_servicename_filter.Location = new System.Drawing.Point(106, 14);
            this.textBox_servicename_filter.Name = "textBox_servicename_filter";
            this.textBox_servicename_filter.Size = new System.Drawing.Size(165, 21);
            this.textBox_servicename_filter.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa usługi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView_services
            // 
            this.dataGridView_services.AllowUserToAddRows = false;
            this.dataGridView_services.AllowUserToDeleteRows = false;
            this.dataGridView_services.AllowUserToOrderColumns = true;
            this.dataGridView_services.AllowUserToResizeRows = false;
            this.dataGridView_services.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridView_services.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_services.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_services.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_services.ColumnHeadersHeight = 25;
            this.dataGridView_services.ContextMenuStrip = this.contextMenuStrip_services;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_services.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_services.EnableHeadersVisualStyles = false;
            this.dataGridView_services.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_services.MultiSelect = false;
            this.dataGridView_services.Name = "dataGridView_services";
            this.dataGridView_services.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_services.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_services.RowHeadersVisible = false;
            this.dataGridView_services.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_services.RowTemplate.ContextMenuStrip = this.contextMenuStrip_services;
            this.dataGridView_services.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_services.Size = new System.Drawing.Size(788, 255);
            this.dataGridView_services.TabIndex = 3;
            // 
            // contextMenuStrip_services
            // 
            this.contextMenuStrip_services.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_start,
            this.toolStripMenuItem_stop,
            this.toolStripMenuItem_restart});
            this.contextMenuStrip_services.Name = "contextMenuStrip_services";
            this.contextMenuStrip_services.Size = new System.Drawing.Size(111, 70);
            // 
            // toolStripMenuItem_start
            // 
            this.toolStripMenuItem_start.Name = "toolStripMenuItem_start";
            this.toolStripMenuItem_start.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem_start.Text = "Start";
            // 
            // toolStripMenuItem_stop
            // 
            this.toolStripMenuItem_stop.Name = "toolStripMenuItem_stop";
            this.toolStripMenuItem_stop.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem_stop.Text = "Stop";
            // 
            // toolStripMenuItem_restart
            // 
            this.toolStripMenuItem_restart.Name = "toolStripMenuItem_restart";
            this.toolStripMenuItem_restart.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem_restart.Text = "Restrat";
            // 
            // panelcenter
            // 
            this.panelcenter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelcenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcenter.Controls.Add(this.dataGridView_services);
            this.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcenter.Location = new System.Drawing.Point(5, 114);
            this.panelcenter.Margin = new System.Windows.Forms.Padding(5);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(790, 257);
            this.panelcenter.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panelcenter);
            this.panel1.Controls.Add(this.paneltop);
            this.panel1.Controls.Add(this.panelbottom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.groupBox_szukaj);
            this.paneltop.Controls.Add(this.groupBox1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(5, 5);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(790, 109);
            this.paneltop.TabIndex = 3;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ServicesForm";
            this.Text = "ServicesForm";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panelbottom.ResumeLayout(false);
            this.groupBox_szukaj.ResumeLayout(false);
            this.groupBox_szukaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_services)).EndInit();
            this.contextMenuStrip_services.ResumeLayout(false);
            this.panelcenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button button_stop_service;
        private System.Windows.Forms.Button button_start_service;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.TextBox textBox_status_filter;
        private System.Windows.Forms.GroupBox groupBox_szukaj;
        private System.Windows.Forms.TextBox textBox_displayName_filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_servicename_filter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView_services;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_services;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_start;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_stop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_restart;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneltop;
    }
}