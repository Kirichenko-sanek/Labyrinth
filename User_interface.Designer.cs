namespace Labyrinth
{
    partial class User_interface
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
            this.Load_labyrinth_button = new System.Windows.Forms.Button();
            this.Labyrinth_dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.in_textBox = new System.Windows.Forms.TextBox();
            this.out_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Avto_button = new System.Windows.Forms.Button();
            this.Hand_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Labyrinth_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_labyrinth_button
            // 
            this.Load_labyrinth_button.Location = new System.Drawing.Point(11, 34);
            this.Load_labyrinth_button.Name = "Load_labyrinth_button";
            this.Load_labyrinth_button.Size = new System.Drawing.Size(179, 30);
            this.Load_labyrinth_button.TabIndex = 0;
            this.Load_labyrinth_button.Text = "Выбрать лабиринт";
            this.Load_labyrinth_button.UseVisualStyleBackColor = true;
            this.Load_labyrinth_button.Click += new System.EventHandler(this.Load_labyrinth_button_Click);
            // 
            // Labyrinth_dataGridView
            // 
            this.Labyrinth_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Labyrinth_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Labyrinth_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Labyrinth_dataGridView.ColumnHeadersVisible = false;
            this.Labyrinth_dataGridView.Location = new System.Drawing.Point(217, 12);
            this.Labyrinth_dataGridView.Name = "Labyrinth_dataGridView";
            this.Labyrinth_dataGridView.RowHeadersVisible = false;
            this.Labyrinth_dataGridView.RowHeadersWidth = 20;
            this.Labyrinth_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Labyrinth_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Labyrinth_dataGridView.Size = new System.Drawing.Size(463, 340);
            this.Labyrinth_dataGridView.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // in_textBox
            // 
            this.in_textBox.BackColor = System.Drawing.Color.Yellow;
            this.in_textBox.Location = new System.Drawing.Point(19, 60);
            this.in_textBox.Name = "in_textBox";
            this.in_textBox.Size = new System.Drawing.Size(54, 20);
            this.in_textBox.TabIndex = 2;
            this.in_textBox.Text = "0";
            // 
            // out_textBox
            // 
            this.out_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.out_textBox.Location = new System.Drawing.Point(102, 60);
            this.out_textBox.Name = "out_textBox";
            this.out_textBox.Size = new System.Drawing.Size(54, 20);
            this.out_textBox.TabIndex = 3;
            this.out_textBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.in_textBox);
            this.groupBox1.Controls.Add(this.out_textBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите номер входа и выхода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "№ Выхода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "№ Входа";
            // 
            // Avto_button
            // 
            this.Avto_button.Location = new System.Drawing.Point(11, 228);
            this.Avto_button.Name = "Avto_button";
            this.Avto_button.Size = new System.Drawing.Size(179, 23);
            this.Avto_button.TabIndex = 5;
            this.Avto_button.Text = "Автоматический режим";
            this.Avto_button.UseVisualStyleBackColor = true;
            this.Avto_button.Click += new System.EventHandler(this.Avto_button_Click);
            // 
            // Hand_button
            // 
            this.Hand_button.Location = new System.Drawing.Point(11, 277);
            this.Hand_button.Name = "Hand_button";
            this.Hand_button.Size = new System.Drawing.Size(179, 23);
            this.Hand_button.TabIndex = 6;
            this.Hand_button.Text = "Ручной режим";
            this.Hand_button.UseVisualStyleBackColor = true;
            this.Hand_button.Click += new System.EventHandler(this.Hand_button_Click);
            // 
            // User_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(692, 364);
            this.Controls.Add(this.Hand_button);
            this.Controls.Add(this.Avto_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Labyrinth_dataGridView);
            this.Controls.Add(this.Load_labyrinth_button);
            this.Name = "User_interface";
            this.Text = "Прохождение лабиринта";
            ((System.ComponentModel.ISupportInitialize)(this.Labyrinth_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_labyrinth_button;
        public System.Windows.Forms.DataGridView Labyrinth_dataGridView;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox in_textBox;
        private System.Windows.Forms.TextBox out_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Avto_button;
        private System.Windows.Forms.Button Hand_button;
    }
}

