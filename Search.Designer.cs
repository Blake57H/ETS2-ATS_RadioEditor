namespace Truck
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Name_radioButton = new System.Windows.Forms.RadioButton();
            this.Fav_radioButton = new System.Windows.Forms.RadioButton();
            this.Language_radioButton = new System.Windows.Forms.RadioButton();
            this.Link_radioButton = new System.Windows.Forms.RadioButton();
            this.Genre_radioButton = new System.Windows.Forms.RadioButton();
            this.Bitrate_radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(12, 15);
            this.Search_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(461, 23);
            this.Search_textBox.TabIndex = 0;
            this.Search_textBox.Text = "Enter your search here";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(12, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(538, 147);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Your search result will be displayed here";
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(476, 15);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Name_radioButton
            // 
            this.Name_radioButton.AutoSize = true;
            this.Name_radioButton.Location = new System.Drawing.Point(12, 45);
            this.Name_radioButton.Name = "Name_radioButton";
            this.Name_radioButton.Size = new System.Drawing.Size(71, 19);
            this.Name_radioButton.TabIndex = 3;
            this.Name_radioButton.TabStop = true;
            this.Name_radioButton.Text = "By name";
            this.Name_radioButton.UseVisualStyleBackColor = true;
            this.Name_radioButton.CheckedChanged += new System.EventHandler(this.Name_radioButton_CheckedChanged);
            // 
            // Fav_radioButton
            // 
            this.Fav_radioButton.AutoSize = true;
            this.Fav_radioButton.Location = new System.Drawing.Point(469, 45);
            this.Fav_radioButton.Name = "Fav_radioButton";
            this.Fav_radioButton.Size = new System.Drawing.Size(81, 19);
            this.Fav_radioButton.TabIndex = 4;
            this.Fav_radioButton.TabStop = true;
            this.Fav_radioButton.Text = "Favourited";
            this.Fav_radioButton.UseVisualStyleBackColor = true;
            this.Fav_radioButton.CheckedChanged += new System.EventHandler(this.Fav_radioButton_CheckedChanged);
            // 
            // Language_radioButton
            // 
            this.Language_radioButton.AutoSize = true;
            this.Language_radioButton.Location = new System.Drawing.Point(313, 45);
            this.Language_radioButton.Name = "Language_radioButton";
            this.Language_radioButton.Size = new System.Drawing.Size(150, 19);
            this.Language_radioButton.TabIndex = 5;
            this.Language_radioButton.TabStop = true;
            this.Language_radioButton.Text = "By language and region";
            this.Language_radioButton.UseVisualStyleBackColor = true;
            this.Language_radioButton.CheckedChanged += new System.EventHandler(this.Language_radioButton_CheckedChanged);
            // 
            // Link_radioButton
            // 
            this.Link_radioButton.AutoSize = true;
            this.Link_radioButton.Location = new System.Drawing.Point(89, 45);
            this.Link_radioButton.Name = "Link_radioButton";
            this.Link_radioButton.Size = new System.Drawing.Size(60, 19);
            this.Link_radioButton.TabIndex = 6;
            this.Link_radioButton.TabStop = true;
            this.Link_radioButton.Text = "By link";
            this.Link_radioButton.UseVisualStyleBackColor = true;
            this.Link_radioButton.CheckedChanged += new System.EventHandler(this.Link_radioButton_CheckedChanged);
            // 
            // Genre_radioButton
            // 
            this.Genre_radioButton.AutoSize = true;
            this.Genre_radioButton.Location = new System.Drawing.Point(155, 45);
            this.Genre_radioButton.Name = "Genre_radioButton";
            this.Genre_radioButton.Size = new System.Drawing.Size(71, 19);
            this.Genre_radioButton.TabIndex = 7;
            this.Genre_radioButton.TabStop = true;
            this.Genre_radioButton.Text = "By genre";
            this.Genre_radioButton.UseVisualStyleBackColor = true;
            this.Genre_radioButton.CheckedChanged += new System.EventHandler(this.Genre_radioButton_CheckedChanged);
            // 
            // Bitrate_radioButton
            // 
            this.Bitrate_radioButton.AutoSize = true;
            this.Bitrate_radioButton.Location = new System.Drawing.Point(232, 45);
            this.Bitrate_radioButton.Name = "Bitrate_radioButton";
            this.Bitrate_radioButton.Size = new System.Drawing.Size(75, 19);
            this.Bitrate_radioButton.TabIndex = 8;
            this.Bitrate_radioButton.TabStop = true;
            this.Bitrate_radioButton.Text = "By bitrate";
            this.Bitrate_radioButton.UseVisualStyleBackColor = true;
            this.Bitrate_radioButton.CheckedChanged += new System.EventHandler(this.Bitrate_radioButton_CheckedChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 231);
            this.Controls.Add(this.Bitrate_radioButton);
            this.Controls.Add(this.Genre_radioButton);
            this.Controls.Add(this.Link_radioButton);
            this.Controls.Add(this.Language_radioButton);
            this.Controls.Add(this.Fav_radioButton);
            this.Controls.Add(this.Name_radioButton);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Search_textBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.RadioButton Name_radioButton;
        private System.Windows.Forms.RadioButton Fav_radioButton;
        private System.Windows.Forms.RadioButton Language_radioButton;
        private System.Windows.Forms.RadioButton Link_radioButton;
        private System.Windows.Forms.RadioButton Genre_radioButton;
        private System.Windows.Forms.RadioButton Bitrate_radioButton;
    }
}