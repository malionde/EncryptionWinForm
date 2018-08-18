namespace _27_06_Encryption
{
    partial class Encryption
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
            this.txt_words = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_Enc = new System.Windows.Forms.Button();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lbl_FillBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_words
            // 
            this.txt_words.Location = new System.Drawing.Point(133, 39);
            this.txt_words.Name = "txt_words";
            this.txt_words.Size = new System.Drawing.Size(345, 20);
            this.txt_words.TabIndex = 0;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_result.Location = new System.Drawing.Point(202, 183);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(112, 16);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "Encrypted Text";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Enc
            // 
            this.btn_Enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Enc.Location = new System.Drawing.Point(29, 118);
            this.btn_Enc.Name = "btn_Enc";
            this.btn_Enc.Size = new System.Drawing.Size(211, 23);
            this.btn_Enc.TabIndex = 2;
            this.btn_Enc.Text = "Encryption";
            this.btn_Enc.UseVisualStyleBackColor = true;
            this.btn_Enc.Click += new System.EventHandler(this.btn_Enc_Click);
            // 
            // btn_Dec
            // 
            this.btn_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Dec.Location = new System.Drawing.Point(267, 118);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(211, 23);
            this.btn_Dec.TabIndex = 2;
            this.btn_Dec.Text = "Decryption";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.btn_Dec_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(29, 211);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(449, 20);
            this.txt_Result.TabIndex = 0;
            // 
            // lbl_FillBox
            // 
            this.lbl_FillBox.AutoSize = true;
            this.lbl_FillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FillBox.Location = new System.Drawing.Point(26, 42);
            this.lbl_FillBox.Name = "lbl_FillBox";
            this.lbl_FillBox.Size = new System.Drawing.Size(101, 13);
            this.lbl_FillBox.TabIndex = 3;
            this.lbl_FillBox.Text = "Fill the box       :";
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 263);
            this.Controls.Add(this.lbl_FillBox);
            this.Controls.Add(this.btn_Dec);
            this.Controls.Add(this.btn_Enc);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_words);
            this.Name = "Encryption";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_words;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_Enc;
        private System.Windows.Forms.Button btn_Dec;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_FillBox;
    }
}

