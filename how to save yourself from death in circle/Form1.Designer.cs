namespace how_to_save_yourself_from_death_in_circle
{
    partial class jesophus_problem
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.N_label = new System.Windows.Forms.Label();
            this.K_label = new System.Windows.Forms.Label();
            this.N_Box = new System.Windows.Forms.TextBox();
            this.K_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Josephus problem is theoritecal problem in which people are standing in a circle " +
    "waiting to be executed.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click here first!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // N_label
            // 
            this.N_label.AutoSize = true;
            this.N_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_label.Location = new System.Drawing.Point(61, 110);
            this.N_label.Name = "N_label";
            this.N_label.Size = new System.Drawing.Size(31, 20);
            this.N_label.TabIndex = 2;
            this.N_label.Text = "N :";
            // 
            // K_label
            // 
            this.K_label.AutoSize = true;
            this.K_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K_label.Location = new System.Drawing.Point(61, 152);
            this.K_label.Name = "K_label";
            this.K_label.Size = new System.Drawing.Size(30, 20);
            this.K_label.TabIndex = 3;
            this.K_label.Text = "K :";
            // 
            // N_Box
            // 
            this.N_Box.Location = new System.Drawing.Point(157, 110);
            this.N_Box.Name = "N_Box";
            this.N_Box.Size = new System.Drawing.Size(235, 20);
            this.N_Box.TabIndex = 4;
            // 
            // K_Box
            // 
            this.K_Box.Location = new System.Drawing.Point(157, 145);
            this.K_Box.Name = "K_Box";
            this.K_Box.Size = new System.Drawing.Size(235, 20);
            this.K_Box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result :";
            // 
            // RBox
            // 
            this.RBox.Location = new System.Drawing.Point(157, 227);
            this.RBox.Name = "RBox";
            this.RBox.Size = new System.Drawing.Size(235, 20);
            this.RBox.TabIndex = 7;
            this.RBox.TextChanged += new System.EventHandler(this.RBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Find winning place";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jesophus_problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(564, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.K_Box);
            this.Controls.Add(this.N_Box);
            this.Controls.Add(this.K_label);
            this.Controls.Add(this.N_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "jesophus_problem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jesophus Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label N_label;
        private System.Windows.Forms.Label K_label;
        private System.Windows.Forms.TextBox N_Box;
        private System.Windows.Forms.TextBox K_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RBox;
        private System.Windows.Forms.Button button2;
    }
}

