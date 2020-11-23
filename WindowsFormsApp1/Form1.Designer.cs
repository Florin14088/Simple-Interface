
namespace WindowsFormsApp1
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
            this.btn_doStuff = new System.Windows.Forms.Button();
            this.TextBox_Results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_doStuff
            // 
            this.btn_doStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doStuff.Location = new System.Drawing.Point(127, 24);
            this.btn_doStuff.Name = "btn_doStuff";
            this.btn_doStuff.Size = new System.Drawing.Size(237, 117);
            this.btn_doStuff.TabIndex = 0;
            this.btn_doStuff.Text = "Start Me";
            this.btn_doStuff.UseVisualStyleBackColor = true;
            this.btn_doStuff.Click += new System.EventHandler(this.btn_doStuff_Click);
            // 
            // TextBox_Results
            // 
            this.TextBox_Results.Location = new System.Drawing.Point(12, 219);
            this.TextBox_Results.Multiline = true;
            this.TextBox_Results.Name = "TextBox_Results";
            this.TextBox_Results.ReadOnly = true;
            this.TextBox_Results.Size = new System.Drawing.Size(499, 204);
            this.TextBox_Results.TabIndex = 1;
            this.TextBox_Results.TextChanged += new System.EventHandler(this.TextBox_Results_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.TextBox_Results);
            this.Controls.Add(this.btn_doStuff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doStuff;
        private System.Windows.Forms.TextBox TextBox_Results;
    }
}

