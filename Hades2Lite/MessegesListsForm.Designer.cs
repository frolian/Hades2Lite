namespace Hades2Lite
{
    partial class MessegesListsForm
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
            this.dataGridView_messages = new System.Windows.Forms.DataGridView();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_messages)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_messages
            // 
            this.dataGridView_messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_messages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Opis,
            this.Content});
            this.dataGridView_messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_messages.Location = new System.Drawing.Point(20, 33);
            this.dataGridView_messages.Name = "dataGridView_messages";
            this.dataGridView_messages.Size = new System.Drawing.Size(721, 364);
            this.dataGridView_messages.TabIndex = 3;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis komunikatu";
            this.Opis.Name = "Opis";
            this.Opis.Width = 200;
            // 
            // Content
            // 
            this.Content.HeaderText = "Treść komunikatu";
            this.Content.Name = "Content";
            this.Content.Width = 400;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_messages);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(761, 417);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista zdefiniowanych komunikatów";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 51);
            this.panel1.TabIndex = 7;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(564, 6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(176, 39);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Zamknij";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // MessegesListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MessegesListsForm";
            this.Text = "MessegesListsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_messages)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_messages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_close;
    }
}