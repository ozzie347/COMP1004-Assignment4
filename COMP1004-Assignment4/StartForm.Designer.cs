namespace COMP1004_Assignment4
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.newOrderButton = new System.Windows.Forms.Button();
            this.savedOrderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(81, 211);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(220, 40);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "Start a New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // savedOrderButton
            // 
            this.savedOrderButton.Location = new System.Drawing.Point(81, 254);
            this.savedOrderButton.Name = "savedOrderButton";
            this.savedOrderButton.Size = new System.Drawing.Size(220, 40);
            this.savedOrderButton.TabIndex = 1;
            this.savedOrderButton.Text = "Open a Saved Order";
            this.savedOrderButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(81, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(220, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP1004_Assignment4.Properties.Resources.comps;
            this.pictureBox1.Location = new System.Drawing.Point(81, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.savedOrderButton);
            this.Controls.Add(this.newOrderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button savedOrderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

