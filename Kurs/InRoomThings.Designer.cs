﻿namespace Kurs
{
    partial class InRoomThings
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
            this.button_add_thing = new System.Windows.Forms.Button();
            this.button_transfer_thing = new System.Windows.Forms.Button();
            this.textBox_nameOfthing = new System.Windows.Forms.TextBox();
            this.costOFthing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_add_thing
            // 
            this.button_add_thing.Location = new System.Drawing.Point(91, 461);
            this.button_add_thing.Name = "button_add_thing";
            this.button_add_thing.Size = new System.Drawing.Size(75, 23);
            this.button_add_thing.TabIndex = 1;
            this.button_add_thing.Text = "Добавить";
            this.button_add_thing.UseVisualStyleBackColor = true;
            // 
            // button_transfer_thing
            // 
            this.button_transfer_thing.Location = new System.Drawing.Point(434, 383);
            this.button_transfer_thing.Name = "button_transfer_thing";
            this.button_transfer_thing.Size = new System.Drawing.Size(75, 23);
            this.button_transfer_thing.TabIndex = 2;
            this.button_transfer_thing.Text = "Перевести";
            this.button_transfer_thing.UseVisualStyleBackColor = true;
            // 
            // textBox_nameOfthing
            // 
            this.textBox_nameOfthing.Location = new System.Drawing.Point(12, 435);
            this.textBox_nameOfthing.Name = "textBox_nameOfthing";
            this.textBox_nameOfthing.Size = new System.Drawing.Size(112, 20);
            this.textBox_nameOfthing.TabIndex = 3;
            // 
            // costOFthing
            // 
            this.costOFthing.Location = new System.Drawing.Point(148, 435);
            this.costOFthing.Name = "costOFthing";
            this.costOFthing.Size = new System.Drawing.Size(112, 20);
            this.costOFthing.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Добавление вещей в резерв";
            // 
            // InRoomThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costOFthing);
            this.Controls.Add(this.textBox_nameOfthing);
            this.Controls.Add(this.button_transfer_thing);
            this.Controls.Add(this.button_add_thing);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InRoomThings";
            this.Text = "InRoomThings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add_thing;
        private System.Windows.Forms.Button button_transfer_thing;
        private System.Windows.Forms.TextBox textBox_nameOfthing;
        private System.Windows.Forms.TextBox costOFthing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}