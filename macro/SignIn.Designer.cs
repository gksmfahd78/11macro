namespace macro
{
    partial class SignIn
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
            this.version = new System.Windows.Forms.Label();
            this.producer_label = new System.Windows.Forms.Label();
            this.auto_singin_check_box = new System.Windows.Forms.CheckBox();
            this.singin_btn = new System.Windows.Forms.Button();
            this.easy_singin_group_box = new System.Windows.Forms.GroupBox();
            this.pay_radio_btn = new System.Windows.Forms.RadioButton();
            this.kakao_radio_btn = new System.Windows.Forms.RadioButton();
            this.facebook_radio_btn = new System.Windows.Forms.RadioButton();
            this.t_radio_btn = new System.Windows.Forms.RadioButton();
            this.naver_radio_btn = new System.Windows.Forms.RadioButton();
            this.signin_group_box = new System.Windows.Forms.GroupBox();
            this.pw_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.pw_text_box = new System.Windows.Forms.TextBox();
            this.id_text_box = new System.Windows.Forms.TextBox();
            this.easy_singin_group_box.SuspendLayout();
            this.signin_group_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(13, 161);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(130, 12);
            this.version.TabIndex = 15;
            this.version.Text = "version : 0.0.1 BETA 1\r\n";
            // 
            // producer_label
            // 
            this.producer_label.AutoSize = true;
            this.producer_label.Location = new System.Drawing.Point(225, 162);
            this.producer_label.Name = "producer_label";
            this.producer_label.Size = new System.Drawing.Size(185, 12);
            this.producer_label.TabIndex = 14;
            this.producer_label.Text = "문의 : honestcoder@kakao.com";
            // 
            // auto_singin_check_box
            // 
            this.auto_singin_check_box.AutoSize = true;
            this.auto_singin_check_box.Location = new System.Drawing.Point(329, 80);
            this.auto_singin_check_box.Name = "auto_singin_check_box";
            this.auto_singin_check_box.Size = new System.Drawing.Size(84, 16);
            this.auto_singin_check_box.TabIndex = 13;
            this.auto_singin_check_box.Text = "자동로그인";
            this.auto_singin_check_box.UseVisualStyleBackColor = true;
            // 
            // singin_btn
            // 
            this.singin_btn.Location = new System.Drawing.Point(329, 18);
            this.singin_btn.Name = "singin_btn";
            this.singin_btn.Size = new System.Drawing.Size(84, 56);
            this.singin_btn.TabIndex = 12;
            this.singin_btn.Text = "로그인";
            this.singin_btn.UseVisualStyleBackColor = true;
            this.singin_btn.Click += new System.EventHandler(this.singin_btn_Click);
            // 
            // easy_singin_group_box
            // 
            this.easy_singin_group_box.Controls.Add(this.pay_radio_btn);
            this.easy_singin_group_box.Controls.Add(this.kakao_radio_btn);
            this.easy_singin_group_box.Controls.Add(this.facebook_radio_btn);
            this.easy_singin_group_box.Controls.Add(this.t_radio_btn);
            this.easy_singin_group_box.Controls.Add(this.naver_radio_btn);
            this.easy_singin_group_box.Location = new System.Drawing.Point(12, 102);
            this.easy_singin_group_box.Name = "easy_singin_group_box";
            this.easy_singin_group_box.Size = new System.Drawing.Size(398, 48);
            this.easy_singin_group_box.TabIndex = 11;
            this.easy_singin_group_box.TabStop = false;
            this.easy_singin_group_box.Text = "간편 로그인";
            // 
            // pay_radio_btn
            // 
            this.pay_radio_btn.AutoSize = true;
            this.pay_radio_btn.Enabled = false;
            this.pay_radio_btn.Location = new System.Drawing.Point(327, 20);
            this.pay_radio_btn.Name = "pay_radio_btn";
            this.pay_radio_btn.Size = new System.Drawing.Size(65, 16);
            this.pay_radio_btn.TabIndex = 5;
            this.pay_radio_btn.TabStop = true;
            this.pay_radio_btn.Text = "PAYCO";
            this.pay_radio_btn.UseVisualStyleBackColor = true;
            // 
            // kakao_radio_btn
            // 
            this.kakao_radio_btn.AutoSize = true;
            this.kakao_radio_btn.Enabled = false;
            this.kakao_radio_btn.Location = new System.Drawing.Point(15, 20);
            this.kakao_radio_btn.Name = "kakao_radio_btn";
            this.kakao_radio_btn.Size = new System.Drawing.Size(64, 16);
            this.kakao_radio_btn.TabIndex = 1;
            this.kakao_radio_btn.TabStop = true;
            this.kakao_radio_btn.Text = "KAKAO";
            this.kakao_radio_btn.UseVisualStyleBackColor = true;
            // 
            // facebook_radio_btn
            // 
            this.facebook_radio_btn.AutoSize = true;
            this.facebook_radio_btn.Enabled = false;
            this.facebook_radio_btn.Location = new System.Drawing.Point(223, 20);
            this.facebook_radio_btn.Name = "facebook_radio_btn";
            this.facebook_radio_btn.Size = new System.Drawing.Size(89, 16);
            this.facebook_radio_btn.TabIndex = 4;
            this.facebook_radio_btn.TabStop = true;
            this.facebook_radio_btn.Text = "FACEBOOK";
            this.facebook_radio_btn.UseVisualStyleBackColor = true;
            // 
            // t_radio_btn
            // 
            this.t_radio_btn.AutoSize = true;
            this.t_radio_btn.Location = new System.Drawing.Point(91, 20);
            this.t_radio_btn.Name = "t_radio_btn";
            this.t_radio_btn.Size = new System.Drawing.Size(31, 16);
            this.t_radio_btn.TabIndex = 2;
            this.t_radio_btn.TabStop = true;
            this.t_radio_btn.Text = "T";
            this.t_radio_btn.UseVisualStyleBackColor = true;
            // 
            // naver_radio_btn
            // 
            this.naver_radio_btn.AutoSize = true;
            this.naver_radio_btn.Enabled = false;
            this.naver_radio_btn.Location = new System.Drawing.Point(141, 20);
            this.naver_radio_btn.Name = "naver_radio_btn";
            this.naver_radio_btn.Size = new System.Drawing.Size(64, 16);
            this.naver_radio_btn.TabIndex = 3;
            this.naver_radio_btn.TabStop = true;
            this.naver_radio_btn.Text = "NAVER";
            this.naver_radio_btn.UseVisualStyleBackColor = true;
            // 
            // signin_group_box
            // 
            this.signin_group_box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signin_group_box.Controls.Add(this.pw_label);
            this.signin_group_box.Controls.Add(this.id_label);
            this.signin_group_box.Controls.Add(this.pw_text_box);
            this.signin_group_box.Controls.Add(this.id_text_box);
            this.signin_group_box.Location = new System.Drawing.Point(12, 12);
            this.signin_group_box.Name = "signin_group_box";
            this.signin_group_box.Size = new System.Drawing.Size(308, 84);
            this.signin_group_box.TabIndex = 10;
            this.signin_group_box.TabStop = false;
            this.signin_group_box.Text = "11번가 로그인";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(13, 50);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(22, 12);
            this.pw_label.TabIndex = 2;
            this.pw_label.Text = "pw";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(14, 23);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(15, 12);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "id";
            // 
            // pw_text_box
            // 
            this.pw_text_box.Location = new System.Drawing.Point(54, 47);
            this.pw_text_box.Name = "pw_text_box";
            this.pw_text_box.PasswordChar = '*';
            this.pw_text_box.Size = new System.Drawing.Size(236, 21);
            this.pw_text_box.TabIndex = 1;
            // 
            // id_text_box
            // 
            this.id_text_box.Location = new System.Drawing.Point(54, 20);
            this.id_text_box.Name = "id_text_box";
            this.id_text_box.Size = new System.Drawing.Size(236, 21);
            this.id_text_box.TabIndex = 0;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(424, 186);
            this.Controls.Add(this.version);
            this.Controls.Add(this.producer_label);
            this.Controls.Add(this.auto_singin_check_box);
            this.Controls.Add(this.singin_btn);
            this.Controls.Add(this.easy_singin_group_box);
            this.Controls.Add(this.signin_group_box);
            this.Name = "SignIn";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.easy_singin_group_box.ResumeLayout(false);
            this.easy_singin_group_box.PerformLayout();
            this.signin_group_box.ResumeLayout(false);
            this.signin_group_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label producer_label;
        private System.Windows.Forms.CheckBox auto_singin_check_box;
        private System.Windows.Forms.Button singin_btn;
        private System.Windows.Forms.GroupBox easy_singin_group_box;
        private System.Windows.Forms.RadioButton pay_radio_btn;
        private System.Windows.Forms.RadioButton kakao_radio_btn;
        private System.Windows.Forms.RadioButton facebook_radio_btn;
        private System.Windows.Forms.RadioButton t_radio_btn;
        private System.Windows.Forms.RadioButton naver_radio_btn;
        private System.Windows.Forms.GroupBox signin_group_box;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox pw_text_box;
        private System.Windows.Forms.TextBox id_text_box;
    }
}