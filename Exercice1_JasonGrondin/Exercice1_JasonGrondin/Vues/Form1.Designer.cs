namespace Exercice1_JasonGrondin
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
            this.btnBrasser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultatDe = new System.Windows.Forms.TextBox();
            this.txtTypeDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrasser
            // 
            this.btnBrasser.Location = new System.Drawing.Point(269, 240);
            this.btnBrasser.Name = "btnBrasser";
            this.btnBrasser.Size = new System.Drawing.Size(228, 101);
            this.btnBrasser.TabIndex = 0;
            this.btnBrasser.Text = "Brasser";
            this.btnBrasser.UseVisualStyleBackColor = true;
            this.btnBrasser.Click += new System.EventHandler(this.btnBrasser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultat du dé";
            // 
            // txtResultatDe
            // 
            this.txtResultatDe.Location = new System.Drawing.Point(269, 166);
            this.txtResultatDe.Name = "txtResultatDe";
            this.txtResultatDe.ReadOnly = true;
            this.txtResultatDe.Size = new System.Drawing.Size(228, 27);
            this.txtResultatDe.TabIndex = 2;
            // 
            // txtTypeDe
            // 
            this.txtTypeDe.Location = new System.Drawing.Point(269, 120);
            this.txtTypeDe.Name = "txtTypeDe";
            this.txtTypeDe.ReadOnly = true;
            this.txtTypeDe.Size = new System.Drawing.Size(228, 27);
            this.txtTypeDe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type de dé";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTypeDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultatDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrasser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBrasser;
        private Label label1;
        private TextBox txtResultatDe;
        private TextBox txtTypeDe;
        private Label label2;
    }
}