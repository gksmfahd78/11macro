namespace macro
{
    partial class Main
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
            this.macro_text_box = new System.Windows.Forms.RichTextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // macro_text_box
            // 
            this.macro_text_box.Location = new System.Drawing.Point(12, 12);
            this.macro_text_box.Name = "macro_text_box";
            this.macro_text_box.Size = new System.Drawing.Size(412, 201);
            this.macro_text_box.TabIndex = 0;
            this.macro_text_box.Text = "";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(431, 13);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "저장";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(431, 192);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "시작";
            this.start_btn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 227);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.macro_text_box);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox macro_text_box;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button start_btn;
    }
}