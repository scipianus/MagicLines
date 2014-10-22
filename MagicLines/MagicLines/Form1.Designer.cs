namespace MagicLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelJoc = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxScor = new System.Windows.Forms.TextBox();
            this.labelScor = new System.Windows.Forms.Label();
            this.buttonHighScores = new System.Windows.Forms.Button();
            this.checkBoxSunet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panelJoc
            // 
            this.panelJoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelJoc.BackgroundImage")));
            this.panelJoc.Location = new System.Drawing.Point(12, 10);
            this.panelJoc.Name = "panelJoc";
            this.panelJoc.Size = new System.Drawing.Size(368, 370);
            this.panelJoc.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(398, 10);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(61, 40);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Joc nou";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(398, 294);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(61, 40);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(398, 340);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(61, 40);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxScor
            // 
            this.textBoxScor.Enabled = false;
            this.textBoxScor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScor.Location = new System.Drawing.Point(395, 115);
            this.textBoxScor.Name = "textBoxScor";
            this.textBoxScor.Size = new System.Drawing.Size(61, 20);
            this.textBoxScor.TabIndex = 4;
            this.textBoxScor.Text = "0";
            // 
            // labelScor
            // 
            this.labelScor.AutoSize = true;
            this.labelScor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScor.Location = new System.Drawing.Point(410, 99);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(33, 13);
            this.labelScor.TabIndex = 5;
            this.labelScor.Text = "Scor";
            // 
            // buttonHighScores
            // 
            this.buttonHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHighScores.Location = new System.Drawing.Point(395, 154);
            this.buttonHighScores.Name = "buttonHighScores";
            this.buttonHighScores.Size = new System.Drawing.Size(61, 40);
            this.buttonHighScores.TabIndex = 6;
            this.buttonHighScores.Text = "High Scores";
            this.buttonHighScores.UseVisualStyleBackColor = true;
            this.buttonHighScores.Click += new System.EventHandler(this.buttonHighScores_Click);
            // 
            // checkBoxSunet
            // 
            this.checkBoxSunet.AutoSize = true;
            this.checkBoxSunet.Checked = true;
            this.checkBoxSunet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSunet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSunet.Location = new System.Drawing.Point(398, 271);
            this.checkBoxSunet.Name = "checkBoxSunet";
            this.checkBoxSunet.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSunet.TabIndex = 7;
            this.checkBoxSunet.Text = "Sounds";
            this.checkBoxSunet.UseVisualStyleBackColor = true;
            this.checkBoxSunet.CheckedChanged += new System.EventHandler(this.checkBoxSunet_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(471, 391);
            this.Controls.Add(this.checkBoxSunet);
            this.Controls.Add(this.buttonHighScores);
            this.Controls.Add(this.labelScor);
            this.Controls.Add(this.textBoxScor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelJoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Lines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJoc;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxScor;
        private System.Windows.Forms.Label labelScor;
        private System.Windows.Forms.Button buttonHighScores;
        private System.Windows.Forms.CheckBox checkBoxSunet;
    }
}

