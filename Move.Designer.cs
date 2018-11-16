namespace Truck
{
    partial class Move
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
            this.Move_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Move_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Move_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Move_button
            // 
            this.Move_button.Location = new System.Drawing.Point(257, 10);
            this.Move_button.Name = "Move_button";
            this.Move_button.Size = new System.Drawing.Size(75, 23);
            this.Move_button.TabIndex = 1;
            this.Move_button.Text = "Move";
            this.Move_button.UseVisualStyleBackColor = true;
            this.Move_button.Click += new System.EventHandler(this.Move_button_Click);
            // 
            // Move_numericUpDown
            // 
            this.Move_numericUpDown.Location = new System.Drawing.Point(12, 10);
            this.Move_numericUpDown.Name = "Move_numericUpDown";
            this.Move_numericUpDown.Size = new System.Drawing.Size(239, 23);
            this.Move_numericUpDown.TabIndex = 2;
            // 
            // Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 45);
            this.Controls.Add(this.Move_numericUpDown);
            this.Controls.Add(this.Move_button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Move";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Move Radio To Index....";
            ((System.ComponentModel.ISupportInitialize)(this.Move_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Move_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown Move_numericUpDown;
    }
}