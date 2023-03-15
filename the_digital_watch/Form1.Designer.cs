namespace the_digital_watch
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labSeconds = new System.Windows.Forms.Label();
            this.labMinutes = new System.Windows.Forms.Label();
            this.labHours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.butPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labSeconds
            // 
            this.labSeconds.AutoSize = true;
            this.labSeconds.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSeconds.Location = new System.Drawing.Point(488, 136);
            this.labSeconds.Name = "labSeconds";
            this.labSeconds.Size = new System.Drawing.Size(26, 29);
            this.labSeconds.TabIndex = 0;
            this.labSeconds.Text = "0";
            // 
            // labMinutes
            // 
            this.labMinutes.AutoSize = true;
            this.labMinutes.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMinutes.Location = new System.Drawing.Point(372, 136);
            this.labMinutes.Name = "labMinutes";
            this.labMinutes.Size = new System.Drawing.Size(26, 29);
            this.labMinutes.TabIndex = 1;
            this.labMinutes.Text = "0";
            // 
            // labHours
            // 
            this.labHours.AutoSize = true;
            this.labHours.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHours.Location = new System.Drawing.Point(256, 136);
            this.labHours.Name = "labHours";
            this.labHours.Size = new System.Drawing.Size(26, 29);
            this.labHours.TabIndex = 2;
            this.labHours.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(262, 249);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 5;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // butPause
            // 
            this.butPause.Location = new System.Drawing.Point(439, 249);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(75, 23);
            this.butPause.TabIndex = 6;
            this.butPause.Text = "Pause";
            this.butPause.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butPause);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labHours);
            this.Controls.Add(this.labMinutes);
            this.Controls.Add(this.labSeconds);
            this.Name = "Form1";
            this.Text = "The digital Watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSeconds;
        private System.Windows.Forms.Label labMinutes;
        private System.Windows.Forms.Label labHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butPause;
    }
}

