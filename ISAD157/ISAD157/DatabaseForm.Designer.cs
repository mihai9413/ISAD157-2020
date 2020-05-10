namespace ISAD157
{
    partial class DatabaseForm
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewWork = new System.Windows.Forms.DataGridView();
            this.dataGridViewUni = new System.Windows.Forms.DataGridView();
            this.dataGridViewMessage = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(15, 12);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(259, 370);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriends.Location = new System.Drawing.Point(297, 12);
            this.dataGridViewFriends.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.RowHeadersWidth = 51;
            this.dataGridViewFriends.RowTemplate.Height = 24;
            this.dataGridViewFriends.Size = new System.Drawing.Size(259, 371);
            this.dataGridViewFriends.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 187);
            this.button2.TabIndex = 6;
            this.button2.Text = "Populate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewWork
            // 
            this.dataGridViewWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWork.Location = new System.Drawing.Point(580, 13);
            this.dataGridViewWork.Name = "dataGridViewWork";
            this.dataGridViewWork.Size = new System.Drawing.Size(259, 370);
            this.dataGridViewWork.TabIndex = 7;
            // 
            // dataGridViewUni
            // 
            this.dataGridViewUni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUni.Location = new System.Drawing.Point(864, 12);
            this.dataGridViewUni.Name = "dataGridViewUni";
            this.dataGridViewUni.Size = new System.Drawing.Size(259, 370);
            this.dataGridViewUni.TabIndex = 8;
            // 
            // dataGridViewMessage
            // 
            this.dataGridViewMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessage.Location = new System.Drawing.Point(297, 413);
            this.dataGridViewMessage.Name = "dataGridViewMessage";
            this.dataGridViewMessage.Size = new System.Drawing.Size(542, 257);
            this.dataGridViewMessage.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Facebook Users";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Facebook Friends";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(522, 676);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Messages";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(963, 387);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Universities";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(650, 387);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Workplace";
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 791);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewMessage);
            this.Controls.Add(this.dataGridViewUni);
            this.Controls.Add(this.dataGridViewWork);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewFriends);
            this.Controls.Add(this.dataGridViewUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseForm";
            this.Text = "Database Form Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewWork;
        private System.Windows.Forms.DataGridView dataGridViewUni;
        private System.Windows.Forms.DataGridView dataGridViewMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

