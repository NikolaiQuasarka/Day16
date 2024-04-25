namespace Task1
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label1 = new Label();
            buttonOrder = new Button();
            radioButtonEn = new RadioButton();
            radioButtonRus = new RadioButton();
            textBoxName = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(461, 332);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Фильм";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Язык звуковой дорожки";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Язык субтитров";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonOrder);
            groupBox1.Controls.Add(radioButtonEn);
            groupBox1.Controls.Add(radioButtonRus);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(507, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 314);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Заказать фильм";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 52);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "Название:";
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(102, 260);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(94, 29);
            buttonOrder.TabIndex = 3;
            buttonOrder.Text = "Заказать";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // radioButtonEn
            // 
            radioButtonEn.AutoSize = true;
            radioButtonEn.Location = new Point(67, 173);
            radioButtonEn.Name = "radioButtonEn";
            radioButtonEn.Size = new Size(180, 24);
            radioButtonEn.TabIndex = 2;
            radioButtonEn.TabStop = true;
            radioButtonEn.Text = "Английские субтитры";
            radioButtonEn.UseVisualStyleBackColor = true;
            radioButtonEn.CheckedChanged += radioButtonEn_CheckedChanged;
            // 
            // radioButtonRus
            // 
            radioButtonRus.AutoSize = true;
            radioButtonRus.Location = new Point(67, 125);
            radioButtonRus.Name = "radioButtonRus";
            radioButtonRus.Size = new Size(151, 24);
            radioButtonRus.TabIndex = 1;
            radioButtonRus.TabStop = true;
            radioButtonRus.Text = "Русские субтитры\r\n";
            radioButtonRus.UseVisualStyleBackColor = true;
            radioButtonRus.CheckedChanged += radioButtonRus_CheckedChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(102, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 358);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фильмы";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 379);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private Button buttonOrder;
        private RadioButton radioButtonEn;
        private RadioButton radioButtonRus;
        private TextBox textBoxName;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
