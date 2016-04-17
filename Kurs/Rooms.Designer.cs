namespace Kurs
{
    partial class Rooms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_book = new System.Windows.Forms.Button();
            this.button_checkedin = new System.Windows.Forms.Button();
            this.button_checkedout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_book
            // 
            this.button_book.Location = new System.Drawing.Point(147, 368);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(104, 23);
            this.button_book.TabIndex = 1;
            this.button_book.Text = "Забронировать";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // button_checkedin
            // 
            this.button_checkedin.Location = new System.Drawing.Point(267, 368);
            this.button_checkedin.Name = "button_checkedin";
            this.button_checkedin.Size = new System.Drawing.Size(102, 23);
            this.button_checkedin.TabIndex = 2;
            this.button_checkedin.Text = "Сдать";
            this.button_checkedin.UseVisualStyleBackColor = true;
            // 
            // button_checkedout
            // 
            this.button_checkedout.Location = new System.Drawing.Point(388, 368);
            this.button_checkedout.Name = "button_checkedout";
            this.button_checkedout.Size = new System.Drawing.Size(102, 23);
            this.button_checkedout.TabIndex = 3;
            this.button_checkedout.Text = "Освободить";
            this.button_checkedout.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 472);
            this.Controls.Add(this.button_checkedout);
            this.Controls.Add(this.button_checkedin);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rooms";
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_checkedin;
        private System.Windows.Forms.Button button_checkedout;
    }
}