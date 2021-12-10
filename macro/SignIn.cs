using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenCvSharp;

namespace macro
{
    public partial class SignIn : Form
    {
        private SignInData signinData = new SignInData();
        private bool radioCheckedChanged = false;
        private static string URL = "https://login.11st.co.kr/auth/login.tmall?returnURL=https%253A%252F%252Fm.11st.co.kr%252FMW%252FMyPage%252FmypageMain.tmall";

        protected ChromeDriverService driverService = null;
        protected ChromeOptions options = null;
        protected ChromeDriver driver = null;

        public SignIn()
        {
            InitializeComponent();
            radioSetting();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

            id_text_box.Text = Properties.Settings.Default.idBox;
            pw_text_box.Text = Properties.Settings.Default.pwBox;

            try
            {
                driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                options = new ChromeOptions();

                options.AddArgument("disable-gpu");
                options.AddArgument("disable-infobars");
                options.AddArgument("--disable-popup-blocking");
                options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
                options.EnableMobileEmulation("Nexus 5");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message : " + ex);
            }
        }

        private void radioSetting()
        {
            this.kakao_radio_btn.CheckedChanged += new EventHandler(radioBtnCheckedChanged);
            this.t_radio_btn.CheckedChanged += new EventHandler(radioBtnCheckedChanged);
            this.naver_radio_btn.CheckedChanged += new EventHandler(radioBtnCheckedChanged);
            this.facebook_radio_btn.CheckedChanged += new EventHandler(radioBtnCheckedChanged);
            this.pay_radio_btn.CheckedChanged += new EventHandler(radioBtnCheckedChanged);

            this.kakao_radio_btn.Click += new EventHandler(radioBtnClick);
            this.t_radio_btn.Click += new EventHandler(radioBtnClick);
            this.naver_radio_btn.Click += new EventHandler(radioBtnClick);
            this.facebook_radio_btn.Click += new EventHandler(radioBtnClick);
            this.pay_radio_btn.Click += new EventHandler(radioBtnClick);
        }

        private void radioBtnCheckedChanged(Object sender, EventArgs e)
        {
            radioCheckedChanged = true;
        }

        private void radioBtnClick(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (!radioCheckedChanged)
                rdo.Checked = false;

            radioCheckedChanged = false;
        }

        private void signinBtn()
        {
            if (id_text_box.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.", "알림",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                id_text_box.Focus();
            }

            else if (pw_text_box.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "알림",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pw_text_box.Focus();
            }

            else
            {
                signinData.setUserID(id_text_box.Text);
                signinData.setUserPw(pw_text_box.Text);

                if(auto_singin_check_box.Checked)
                {
                    Properties.Settings.Default.idBox = id_text_box.Text;
                    Properties.Settings.Default.pwBox = pw_text_box.Text;
                    Properties.Settings.Default.Save();
                }
                
                else
                {
                    Properties.Settings.Default.idBox = "";
                    Properties.Settings.Default.pwBox = "";
                    Properties.Settings.Default.Save();
                }

                mainSignIn();
            }
        }

        private void mainSignIn()
        {
            try
            {
                driver = new ChromeDriver(driverService, options);
                Cookie cookie = new Cookie();
                CookieCollection cookieCollection = new CookieCollection();
                cookieCollection = cookie.getCookie(driver);
                driver.Navigate().GoToUrl(URL);
                driver.
                driverWait(10);
                signInWay();
                if (signInCheck())
                    test();
                else
                    return;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message : " + ex);
            }
        }

        private void signInWay()
        {
            if(kakao_radio_btn.Checked)
            {

            }

            else if(t_radio_btn.Checked)
            {
                var easyTBtn = driver.FindElement(By.XPath("//*[@id='btn_simple_login_tid']"));
                easyTBtn.Click();
                var idInputBox = driver.FindElement(By.XPath("//*[@id='userId']"));
                var pwInputBox = driver.FindElement(By.XPath("//*[@id='password']"));
                idInputBox.SendKeys(id_text_box.Text);
                pwInputBox.SendKeys(pw_text_box.Text);
                driverWait(10);
                var signInBtn = driver.FindElement(By.XPath("//*[@id='authLogin']"));
                signInBtn.Click();
            }

            else if (naver_radio_btn.Checked)
            {

            }

            else if(facebook_radio_btn.Checked)
            {

            } 
            
            else if (pay_radio_btn.Checked)
            {

            }

            else
            {

            }
        }

        private bool signInCheck()
        {
            if (kakao_radio_btn.Checked)
            {
                return false;
            }

            else if (t_radio_btn.Checked)
            {
                try
                {
                    var check = driver.FindElement(By.XPath("//*[@id='formMsg_password']/p"));
                }

                catch (Exception ex)
                {
                    return false;

                }

                return true;
            }

            else if (naver_radio_btn.Checked)
            {
                return false;
            }

            else if (facebook_radio_btn.Checked)
            {
                return false;
            }

            else if (pay_radio_btn.Checked)
            {
                return false;
            }

            else
            {
                return false;
            }
        }

        private bool connectState(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 10000;
            request.Headers.Add("Authorization", "BASIC SGVsbG8=");

            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                if (((int)status >= 200) && ((int)status <= 299))
                    return true;
                else
                    return false;
            }
        }

        private void driverWait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        private void test()
        {
            driver.Navigate().GoToUrl("http://m.11st.co.kr/products/m/3136972078?trTypeCd=PW00&trCtgrNo=585021");
            driverWait(10);
            var buyNowBtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/button"));
            var productScrollDownBtn = driver.FindElement(By.XPath("//*[@id='optionContainer']/div[1]/div[1]/button"));
            var firstProduct = driver.FindElement(By.XPath("//*[@id='optlst_prdGrp']/li[2]/a"));
            buyNowBtn.Click();
            driverWait(10);
            productScrollDownBtn.Click();
            driverWait(10);
            firstProduct.Click();
        }

        private void singin_btn_Click(object sender, EventArgs e)
        {
            signinBtn();
        }
    }
}
