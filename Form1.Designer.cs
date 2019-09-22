namespace Truck
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openETS2RadioListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openATSRadioListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reflesh_button = new System.Windows.Forms.Button();
            this.Genre_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Radio_button = new System.Windows.Forms.Button();
            this.Play_Radio_button = new System.Windows.Forms.Button();
            this.Move_button = new System.Windows.Forms.Button();
            this.Delete_Radio_button = new System.Windows.Forms.Button();
            this.Update_Radio_button = new System.Windows.Forms.Button();
            this.Fav_checkBox = new System.Windows.Forms.CheckBox();
            this.Link_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Language_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bitrate_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.radiosToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openETS2RadioListToolStripMenuItem,
            this.openATSRadioListToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open....";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openETS2RadioListToolStripMenuItem
            // 
            this.openETS2RadioListToolStripMenuItem.Name = "openETS2RadioListToolStripMenuItem";
            this.openETS2RadioListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openETS2RadioListToolStripMenuItem.Text = "Open ETS2 Radio List";
            this.openETS2RadioListToolStripMenuItem.Click += new System.EventHandler(this.openETS2RadioListToolStripMenuItem_Click);
            // 
            // openATSRadioListToolStripMenuItem
            // 
            this.openATSRadioListToolStripMenuItem.Name = "openATSRadioListToolStripMenuItem";
            this.openATSRadioListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openATSRadioListToolStripMenuItem.Text = "Open ATS Radio List";
            this.openATSRadioListToolStripMenuItem.Click += new System.EventHandler(this.openATSRadioListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAsToolStripMenuItem.Text = "Save as....";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // radiosToolStripMenuItem
            // 
            this.radiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.resetChangesToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.radiosToolStripMenuItem.Enabled = false;
            this.radiosToolStripMenuItem.Name = "radiosToolStripMenuItem";
            this.radiosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.radiosToolStripMenuItem.Text = "Radios";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // resetChangesToolStripMenuItem
            // 
            this.resetChangesToolStripMenuItem.Name = "resetChangesToolStripMenuItem";
            this.resetChangesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.resetChangesToolStripMenuItem.Text = "Reset Changes";
            this.resetChangesToolStripMenuItem.Click += new System.EventHandler(this.resetChangesToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index_column,
            this.Description_column,
            this.Link_column});
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(679, 266);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Index_column
            // 
            this.Index_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Index_column.HeaderText = "Index";
            this.Index_column.Name = "Index_column";
            this.Index_column.ReadOnly = true;
            this.Index_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index_column.Width = 42;
            // 
            // Description_column
            // 
            this.Description_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_column.FillWeight = 50F;
            this.Description_column.HeaderText = "Description";
            this.Description_column.Name = "Description_column";
            this.Description_column.ReadOnly = true;
            this.Description_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Link_column
            // 
            this.Link_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Link_column.FillWeight = 50F;
            this.Link_column.HeaderText = "Link";
            this.Link_column.Name = "Link_column";
            this.Link_column.ReadOnly = true;
            this.Link_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Reflesh_button);
            this.groupBox1.Controls.Add(this.Genre_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Add_Radio_button);
            this.groupBox1.Controls.Add(this.Play_Radio_button);
            this.groupBox1.Controls.Add(this.Move_button);
            this.groupBox1.Controls.Add(this.Delete_Radio_button);
            this.groupBox1.Controls.Add(this.Update_Radio_button);
            this.groupBox1.Controls.Add(this.Fav_checkBox);
            this.groupBox1.Controls.Add(this.Link_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Language_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Bitrate_textBox);
            this.groupBox1.Controls.Add(this.Name_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 302);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(679, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio Information";
            // 
            // Reflesh_button
            // 
            this.Reflesh_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reflesh_button.Location = new System.Drawing.Point(398, 74);
            this.Reflesh_button.Name = "Reflesh_button";
            this.Reflesh_button.Size = new System.Drawing.Size(109, 23);
            this.Reflesh_button.TabIndex = 16;
            this.Reflesh_button.Text = "Reflesh Radio List";
            this.Reflesh_button.UseVisualStyleBackColor = true;
            this.Reflesh_button.Click += new System.EventHandler(this.Reflesh_button_Click);
            this.Reflesh_button.MouseHover += new System.EventHandler(this.Reflesh_button_MouseHover);
            // 
            // Genre_textBox
            // 
            this.Genre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Genre_textBox.Location = new System.Drawing.Point(515, 45);
            this.Genre_textBox.Name = "Genre_textBox";
            this.Genre_textBox.Size = new System.Drawing.Size(158, 23);
            this.Genre_textBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Genre";
            // 
            // Add_Radio_button
            // 
            this.Add_Radio_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_Radio_button.Location = new System.Drawing.Point(513, 74);
            this.Add_Radio_button.Name = "Add_Radio_button";
            this.Add_Radio_button.Size = new System.Drawing.Size(79, 23);
            this.Add_Radio_button.TabIndex = 13;
            this.Add_Radio_button.Text = "Add Radio";
            this.Add_Radio_button.UseVisualStyleBackColor = true;
            this.Add_Radio_button.Click += new System.EventHandler(this.Add_Radio_button_Click);
            this.Add_Radio_button.MouseHover += new System.EventHandler(this.Add_Radio_button_MouseHover);
            // 
            // Play_Radio_button
            // 
            this.Play_Radio_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Play_Radio_button.Location = new System.Drawing.Point(598, 74);
            this.Play_Radio_button.Name = "Play_Radio_button";
            this.Play_Radio_button.Size = new System.Drawing.Size(75, 23);
            this.Play_Radio_button.TabIndex = 12;
            this.Play_Radio_button.Text = "Play Radio";
            this.Play_Radio_button.UseVisualStyleBackColor = true;
            this.Play_Radio_button.Click += new System.EventHandler(this.Play_Radio_button_Click);
            // 
            // Move_button
            // 
            this.Move_button.Location = new System.Drawing.Point(194, 74);
            this.Move_button.Name = "Move_button";
            this.Move_button.Size = new System.Drawing.Size(115, 23);
            this.Move_button.TabIndex = 11;
            this.Move_button.Text = "Move Radio To....";
            this.Move_button.UseVisualStyleBackColor = true;
            this.Move_button.Click += new System.EventHandler(this.Move_button_Click);
            // 
            // Delete_Radio_button
            // 
            this.Delete_Radio_button.Location = new System.Drawing.Point(100, 74);
            this.Delete_Radio_button.Name = "Delete_Radio_button";
            this.Delete_Radio_button.Size = new System.Drawing.Size(88, 23);
            this.Delete_Radio_button.TabIndex = 10;
            this.Delete_Radio_button.Text = "Delete Radio";
            this.Delete_Radio_button.UseVisualStyleBackColor = true;
            this.Delete_Radio_button.Click += new System.EventHandler(this.Delete_Radio_button_Click);
            // 
            // Update_Radio_button
            // 
            this.Update_Radio_button.Location = new System.Drawing.Point(6, 74);
            this.Update_Radio_button.Name = "Update_Radio_button";
            this.Update_Radio_button.Size = new System.Drawing.Size(88, 23);
            this.Update_Radio_button.TabIndex = 9;
            this.Update_Radio_button.Text = "Update Radio";
            this.Update_Radio_button.UseVisualStyleBackColor = true;
            this.Update_Radio_button.Click += new System.EventHandler(this.Update_Radio_button_Click);
            // 
            // Fav_checkBox
            // 
            this.Fav_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Fav_checkBox.AutoSize = true;
            this.Fav_checkBox.Location = new System.Drawing.Point(565, 19);
            this.Fav_checkBox.Name = "Fav_checkBox";
            this.Fav_checkBox.Size = new System.Drawing.Size(108, 19);
            this.Fav_checkBox.TabIndex = 8;
            this.Fav_checkBox.Text = "Mark Favourate";
            this.Fav_checkBox.UseVisualStyleBackColor = true;
            // 
            // Link_textBox
            // 
            this.Link_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Link_textBox.Location = new System.Drawing.Point(52, 45);
            this.Link_textBox.Name = "Link_textBox";
            this.Link_textBox.Size = new System.Drawing.Size(418, 23);
            this.Link_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link";
            // 
            // Language_textBox
            // 
            this.Language_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Language_textBox.Location = new System.Drawing.Point(489, 17);
            this.Language_textBox.Name = "Language_textBox";
            this.Language_textBox.Size = new System.Drawing.Size(56, 23);
            this.Language_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Language and Region";
            // 
            // Bitrate_textBox
            // 
            this.Bitrate_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bitrate_textBox.Location = new System.Drawing.Point(299, 17);
            this.Bitrate_textBox.Name = "Bitrate_textBox";
            this.Bitrate_textBox.Size = new System.Drawing.Size(56, 23);
            this.Bitrate_textBox.TabIndex = 3;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_textBox.Location = new System.Drawing.Point(52, 17);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(194, 23);
            this.Name_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(719, 457);
            this.Name = "Form1";
            this.Text = "Radio Editor for ATS & ETS2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openETS2RadioListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openATSRadioListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link_column;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Fav_checkBox;
        private System.Windows.Forms.TextBox Link_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Language_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bitrate_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Genre_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_Radio_button;
        private System.Windows.Forms.Button Play_Radio_button;
        private System.Windows.Forms.Button Move_button;
        private System.Windows.Forms.Button Delete_Radio_button;
        private System.Windows.Forms.Button Update_Radio_button;
        private System.Windows.Forms.Button Reflesh_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
    }
}

