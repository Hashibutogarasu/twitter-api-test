using CoreTweet;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using PINForm;

namespace Twitter_API_Testing_App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //OSのバージョン情報を取得する
            System.OperatingSystem os = System.Environment.OSVersion;

            OSInfo.Text = os.Platform.ToString();
            Version.Text = "Version:"+os.Version.Major.ToString();

            string s1 = Properties.Settings.Default.ApiKey;
            string s2 = Properties.Settings.Default.ApiKeySecret;
            string s3 = Properties.Settings.Default.AccessToken;
            string s4 = Properties.Settings.Default.AccessTokenSecret;

            ApiKeyBox.Text = s1;
            ApiKeySecretBox.Text = s2;
            AccessTokenBox.Text = s3;
            AccessTokenSecretBox.Text = s4;

            InfoLabel.Text = "";
        }

        private void tweetButton_Click(object sender, EventArgs e)
        {
            
            string ConsumerKey = ApiKeyBox.Text.ToString();
            string ConsumerSecret = ApiKeySecretBox.Text.ToString();
            string AccessToken = AccessTokenBox.Text.ToString();
            string AccessTokenSecret = AccessTokenSecretBox.Text.ToString();
            

            try
            {
                Tokens tokens = Tokens.Create(ConsumerKey, ConsumerSecret, AccessToken, AccessTokenSecret);
                Status status = tokens.Statuses.Update(new { status = TweetBox.Text });
                InfoLabel.Text = "ツイートしました。";
            }
            catch(TwitterException twe)
            {
                Console.WriteLine(twe.Message); //メッセージを表示する
                InfoLabel.Text = twe.Message;
                

            }
            catch (System.Net.WebException twe)
            {
                //インターネット接続に関するエラー。
                Console.WriteLine(twe.Message); //メッセージを表示する
                InfoLabel.Text = twe.Message;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                
            }

            TweetBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // テキストの文字数を取得する
            int iLength = this.TweetBox.TextLength;
            int MaxTweetCount = 140 - this.TweetBox.TextLength;

            // こちらでも可能 
            //int iLength = this.textBox1.Text.Length;

            // 取得したテキストの文字数を表示する

            CounterLabel.Text = (MaxTweetCount.ToString());
            
            if(iLength != 0)
            {
                tweetButton.Enabled = true;
            }
            else
            {
                tweetButton.Enabled = false;
            }
            if(TweetBox.Text.StartsWith(" "))
            {
                TweetBox.Text = TweetBox.Text.Trim();
            }
            if (TweetBox.Text.EndsWith(" "))
            {
                TweetBox.Text = TweetBox.Text.TrimEnd();
            }


        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //github
            try
            {
                string target = "https://github.com/Hashibutogarasu/twitter-api-test";
                Process.Start("explorer", target);
            }
            catch(Exception er) {

                InfoLabel.Text = er.ToString();
                    
            }
        }

        private void TwitterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //twitter
            try
            {
                string target = "https://twitter.com/Columba_Karasu";
                Process.Start("explorer", target);
            }
            catch(Exception er)
            {
                InfoLabel.Text = er.ToString();
            }




        }

        private void ShowKey_Click(object sender, EventArgs e)
        {

            string ButtonText = ShowKey.Text;
            string ShowKeyText = "キーを表示する";
            string HideKeyText = "キーを非表示にする";

            if (ButtonText == ShowKeyText)
            {
                ShowKey.Text = HideKeyText;
                ApiKeyBox.PasswordChar = '\0';
                ApiKeySecretBox.PasswordChar = '\0';
                AccessTokenBox.PasswordChar = '\0';
                AccessTokenSecretBox.PasswordChar = '\0';
            
            }
            else if(ButtonText == HideKeyText)
            {
                ShowKey.Text = ShowKeyText;
                ApiKeyBox.PasswordChar = '*';
                ApiKeySecretBox.PasswordChar = '*';
                AccessTokenBox.PasswordChar = '*';
                AccessTokenSecretBox.PasswordChar = '*';
            }


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AuthTw_Click(object sender, EventArgs e)
        {
            // 例: コンソールから取得する
            string pin = Console.ReadLine();

            //Tokens tokens = OAuth.GetTokens(session, pin);

            try
            {
                // API Key と API secret Key を入力（ハードコーディング時は注意）
                var session = OAuth.Authorize(ApiKeyBox.Text, ApiKeySecretBox.Text);


                try
                {
                    //認証URLをコピー
                    //Clipboard.SetText(session.AuthorizeUri.AbsoluteUri.ToString());
                    InfoLabel.Text = "URLをクリップボードにコピーしました。";

                    string target = string.Format("start {0}",session.AuthorizeUri.AbsoluteUri.ToString());
                    //Use no more than one assignment when you test this code.
                    //string target = "ftp://ftp.microsoft.com";
                    //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
                    try
                    {
                        
                        //System.Diagnostics.Process.Start("powershell",target);

                        ProcessStartInfo psInfo = new ProcessStartInfo();
                        psInfo.FileName = string.Format("powershell"); // 実行するファイル
                        psInfo.Arguments = (target);
                        psInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない

                        Process.Start(psInfo);


                    }
                    catch (System.ComponentModel.Win32Exception noBrowser)
                    {
                        if (noBrowser.ErrorCode == -2147467259)
                            MessageBox.Show(noBrowser.Message);
                    }
                    catch (System.Exception other)
                    {
                        MessageBox.Show(other.Message);
                    }

                    PinDialog PINForm = new PinDialog();
                    DialogResult dr = PINForm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        try
                        {
                            CoreTweet.Tokens tokens = session.GetTokens(PINForm.value);


                            Properties.Settings.Default.ApiKey = tokens.ConsumerKey;
                            Properties.Settings.Default.ApiKeySecret = tokens.ConsumerSecret;
                            Properties.Settings.Default.AccessToken = tokens.AccessToken;
                            Properties.Settings.Default.AccessTokenSecret = tokens.ConsumerSecret;
                            Properties.Settings.Default.Save();

                            ApiKeyBox.Text = tokens.ConsumerKey;
                            ApiKeySecretBox.Text = tokens.ConsumerSecret;
                            AccessTokenBox.Text = tokens.AccessToken;
                            AccessTokenSecretBox.Text = tokens.AccessTokenSecret;

                            InfoLabel.Text = "認証しました。";

                        }
                        catch
                        {
                            InfoLabel.Text = "認証できませんでした。";
                        }

                    }
                }
                catch
                {

                }

            }

            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void ConfigLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ApiKeyBox.Text.Length !=0 && ApiKeySecretBox.Text.Length !=0) {
                try
                {

                    Properties.Settings.Default.ApiKey = ApiKeyBox.Text;
                    Properties.Settings.Default.ApiKeySecret = ApiKeySecretBox.Text;
                    Properties.Settings.Default.AccessToken = AccessTokenBox.Text;
                    Properties.Settings.Default.AccessTokenSecret = AccessTokenSecretBox.Text;
                    Properties.Settings.Default.Save();

                    InfoLabel.Text = "キーを保存しました。";
                }
                catch
                {
                    InfoLabel.Text = "キーを保存出来ませんでした。";
                }
            }
            else
            {
                InfoLabel.Text = "キー未設定の場合は保存できません。";
            }
                   
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ApiKeyBox.Text = "";
            ApiKeySecretBox.Text = "";
            AccessTokenBox.Text = "";
            AccessTokenSecretBox.Text = "";
            
            
            Properties.Settings.Default.ApiKey = ApiKeyBox.Text;
            Properties.Settings.Default.ApiKeySecret = ApiKeySecretBox.Text;
            Properties.Settings.Default.AccessToken = AccessTokenBox.Text;
            Properties.Settings.Default.AccessTokenSecret = AccessTokenSecretBox.Text;
            Properties.Settings.Default.Save();

            InfoLabel.Text = "キーをリセットしました。";
        }

        private void Close_Key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void ApiKeyBox_TextChanged(object sender, EventArgs e)
        {

            if (ApiKeyBox.Text.StartsWith(" "))
            {
                ApiKeyBox.Text = ApiKeyBox.Text.Trim();
            }
            else if (ApiKeyBox.Text.EndsWith(" "))
            {
                ApiKeyBox.Text = ApiKeyBox.Text.TrimEnd();
            }


            if (ApiKeyBox.Text.Length !=0 && ApiKeySecretBox.Text.Length !=0)
            {
                OauthButton.Enabled = true;
            }
            else
            {
                OauthButton.Enabled = false;
            }
        }

        private void ApiKeySecretBox_TextChanged(object sender, EventArgs e)
        {
            if (ApiKeySecretBox.Text.StartsWith(" "))
            {
                ApiKeySecretBox.Text = ApiKeySecretBox.Text.Trim();
            }
            else if (ApiKeySecretBox.Text.EndsWith(" "))
            {
                ApiKeySecretBox.Text = ApiKeySecretBox.Text.TrimEnd();
            }

            if (ApiKeyBox.Text.Length !=0 && ApiKeySecretBox.Text.Length !=0)
            {
                OauthButton.Enabled = true;
            }
            else
            {
                OauthButton.Enabled = false;
            }
        }
    }
}
