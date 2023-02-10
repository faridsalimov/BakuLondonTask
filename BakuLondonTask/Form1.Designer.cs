namespace BakuLondonTask
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
            this.button1 = new System.Windows.Forms.Button();
            this.londonButton = new System.Windows.Forms.Button();
            this.hourLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Baku";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakuButton_MouseClick);
            // 
            // londonButton
            // 
            this.londonButton.BackColor = System.Drawing.Color.SkyBlue;
            this.londonButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.londonButton.Location = new System.Drawing.Point(588, 368);
            this.londonButton.Name = "londonButton";
            this.londonButton.Size = new System.Drawing.Size(200, 70);
            this.londonButton.TabIndex = 1;
            this.londonButton.Text = "London";
            this.londonButton.UseVisualStyleBackColor = false;
            this.londonButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonButton_MouseClick);
            // 
            // hourLabel
            // 
            this.hourLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hourLabel.Location = new System.Drawing.Point(333, 9);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(138, 56);
            this.hourLabel.TabIndex = 2;
            this.hourLabel.Text = "00:00:00";
            this.hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.londonButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button londonButton;
        private Label hourLabel;
    }
}