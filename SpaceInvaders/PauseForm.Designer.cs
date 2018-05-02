namespace SpaceInvaders
{
    partial class PauseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PauseForm));
            this.labelMsgPause = new System.Windows.Forms.Label();
            this.buttonPauseResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMsgPause
            // 
            this.labelMsgPause.AutoSize = true;
            this.labelMsgPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMsgPause.Location = new System.Drawing.Point(17, 41);
            this.labelMsgPause.Name = "labelMsgPause";
            this.labelMsgPause.Size = new System.Drawing.Size(352, 20);
            this.labelMsgPause.TabIndex = 0;
            this.labelMsgPause.Text = "The game is paused, press \'Resume\' to continue";
            // 
            // buttonPauseResume
            // 
            this.buttonPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPauseResume.Location = new System.Drawing.Point(152, 91);
            this.buttonPauseResume.Name = "buttonPauseResume";
            this.buttonPauseResume.Size = new System.Drawing.Size(90, 34);
            this.buttonPauseResume.TabIndex = 1;
            this.buttonPauseResume.Text = "Resume";
            this.buttonPauseResume.UseVisualStyleBackColor = true;
            this.buttonPauseResume.Click += new System.EventHandler(this.buttonPauseResume_Click);
            // 
            // PauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 152);
            this.Controls.Add(this.buttonPauseResume);
            this.Controls.Add(this.labelMsgPause);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PauseForm";
            this.Text = "Pause";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMsgPause;
        private System.Windows.Forms.Button buttonPauseResume;
    }
}