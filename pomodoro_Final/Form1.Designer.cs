namespace pomodoro_Final
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.Hrst = new System.Windows.Forms.Button();
            this.tagTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtResult.Location = new System.Drawing.Point(30, 29);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(209, 55);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "00:00";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(30, 107);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(94, 49);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(130, 107);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(109, 49);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Pause";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click_1);
            // 
            // Hrst
            // 
            this.Hrst.Location = new System.Drawing.Point(69, 187);
            this.Hrst.Name = "Hrst";
            this.Hrst.Size = new System.Drawing.Size(126, 23);
            this.Hrst.TabIndex = 4;
            this.Hrst.Text = "Hard Reset";
            this.Hrst.UseVisualStyleBackColor = true;
            this.Hrst.Click += new System.EventHandler(this.Hrst_Click);
            // 
            // tagTxtBox
            // 
            this.tagTxtBox.Location = new System.Drawing.Point(80, 272);
            this.tagTxtBox.Name = "tagTxtBox";
            this.tagTxtBox.Size = new System.Drawing.Size(100, 22);
            this.tagTxtBox.TabIndex = 5;
            this.tagTxtBox.TextChanged += new System.EventHandler(this.tagTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Votre tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vos dernier tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // tagBox
            // 
            this.tagBox.FormattingEnabled = true;
            this.tagBox.ItemHeight = 16;
            this.tagBox.Location = new System.Drawing.Point(30, 350);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(209, 116);
            this.tagBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 476);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tagTxtBox);
            this.Controls.Add(this.Hrst);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button Hrst;
        private System.Windows.Forms.TextBox tagTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox tagBox;
    }
}
