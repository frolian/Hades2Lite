namespace Hades2Lite
{
    partial class ComputersListsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputersListsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.listyPC_dataGridView = new System.Windows.Forms.DataGridView();
            this.ListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lista_dataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listyPC_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 57);
            this.panel1.TabIndex = 6;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.Location = new System.Drawing.Point(724, 5);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(165, 40);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Zamknij";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // listyPC_dataGridView
            // 
            this.listyPC_dataGridView.AllowUserToAddRows = false;
            this.listyPC_dataGridView.AllowUserToDeleteRows = false;
            this.listyPC_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listyPC_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listyPC_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listyPC_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListNameColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listyPC_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.listyPC_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listyPC_dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.listyPC_dataGridView.Location = new System.Drawing.Point(20, 33);
            this.listyPC_dataGridView.Name = "listyPC_dataGridView";
            this.listyPC_dataGridView.ReadOnly = true;
            this.listyPC_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listyPC_dataGridView.RowHeadersVisible = false;
            this.listyPC_dataGridView.RowHeadersWidth = 20;
            this.listyPC_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listyPC_dataGridView.Size = new System.Drawing.Size(217, 233);
            this.listyPC_dataGridView.TabIndex = 1;
            // 
            // ListNameColumn
            // 
            this.ListNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ListNameColumn.HeaderText = "Nazwa listy komputerów";
            this.ListNameColumn.MaxInputLength = 30;
            this.ListNameColumn.Name = "ListNameColumn";
            this.ListNameColumn.ReadOnly = true;
            this.ListNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ListNameColumn.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lista_dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(320, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(583, 286);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zawartość listy komputerów";
            // 
            // lista_dataGridView
            // 
            this.lista_dataGridView.AllowUserToResizeRows = false;
            this.lista_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lista_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lista_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lista_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.lista_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista_dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.lista_dataGridView.Location = new System.Drawing.Point(20, 33);
            this.lista_dataGridView.Name = "lista_dataGridView";
            this.lista_dataGridView.Size = new System.Drawing.Size(543, 233);
            this.lista_dataGridView.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(221, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 42);
            this.button3.TabIndex = 7;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(54, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Usuń listę";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(54, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Utwórz nową listę";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listyPC_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(6, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(257, 286);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listy komputerów";
            // 
            // ComputersListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComputersListsForm";
            this.Text = "ComputersListsForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listyPC_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lista_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridView listyPC_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListNameColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView lista_dataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}