
namespace validationForm
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMsgName = new System.Windows.Forms.Label();
            this.labelMsgEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.AccessibleName = "txtName";
            this.textName.Location = new System.Drawing.Point(127, 161);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(373, 31);
            this.textName.TabIndex = 0;
            // 
            // textEmail
            // 
            this.textEmail.AccessibleName = "txtEmail";
            this.textEmail.Location = new System.Drawing.Point(127, 305);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(373, 31);
            this.textEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(475, 172);
            this.button1.TabIndex = 4;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMsgName
            // 
            this.labelMsgName.AccessibleName = "lableMSG";
            this.labelMsgName.AutoSize = true;
            this.labelMsgName.Location = new System.Drawing.Point(716, 167);
            this.labelMsgName.Name = "labelMsgName";
            this.labelMsgName.Size = new System.Drawing.Size(30, 25);
            this.labelMsgName.TabIndex = 5;
            this.labelMsgName.Text = "...";
            // 
            // labelMsgEmail
            // 
            this.labelMsgEmail.AccessibleName = "lableMSG";
            this.labelMsgEmail.AutoSize = true;
            this.labelMsgEmail.Location = new System.Drawing.Point(716, 305);
            this.labelMsgEmail.Name = "labelMsgEmail";
            this.labelMsgEmail.Size = new System.Drawing.Size(30, 25);
            this.labelMsgEmail.TabIndex = 6;
            this.labelMsgEmail.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 939);
            this.Controls.Add(this.labelMsgEmail);
            this.Controls.Add(this.labelMsgName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "Regex Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMsgName;
        private System.Windows.Forms.Label labelMsgEmail;
    }
}

