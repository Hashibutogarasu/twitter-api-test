
namespace Twitter_API_Testing_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TweetBox = new System.Windows.Forms.TextBox();
            this.tweetButton = new System.Windows.Forms.Button();
            this.ApiKeyBox = new System.Windows.Forms.TextBox();
            this.ApiKeySecretBox = new System.Windows.Forms.TextBox();
            this.AccessTokenBox = new System.Windows.Forms.TextBox();
            this.AccessTokenSecretBox = new System.Windows.Forms.TextBox();
            this.ConfigLabel = new System.Windows.Forms.Label();
            this.TweetLabel = new System.Windows.Forms.Label();
            this.TweetInfoLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ApiKeyLabel = new System.Windows.Forms.Label();
            this.ApiKeySecretLabel = new System.Windows.Forms.Label();
            this.AccessTokenLabel = new System.Windows.Forms.Label();
            this.AccessTokenSecretLabel = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.TweetBoxCountLabel = new System.Windows.Forms.Label();
            this.TwitterLink = new System.Windows.Forms.LinkLabel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.OSInfo = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.ShowKey = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OauthButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TweetBox
            // 
            this.TweetBox.Location = new System.Drawing.Point(12, 31);
            this.TweetBox.Multiline = true;
            this.TweetBox.Name = "TweetBox";
            this.TweetBox.Size = new System.Drawing.Size(281, 110);
            this.TweetBox.TabIndex = 0;
            this.TweetBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TweetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Close_Key);
            // 
            // tweetButton
            // 
            this.tweetButton.Location = new System.Drawing.Point(12, 147);
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Size = new System.Drawing.Size(75, 23);
            this.tweetButton.TabIndex = 1;
            this.tweetButton.Text = "ツイート";
            this.tweetButton.UseVisualStyleBackColor = true;
            this.tweetButton.Click += new System.EventHandler(this.tweetButton_Click);
            // 
            // ApiKeyBox
            // 
            this.ApiKeyBox.Location = new System.Drawing.Point(364, 49);
            this.ApiKeyBox.Name = "ApiKeyBox";
            this.ApiKeyBox.PasswordChar = '*';
            this.ApiKeyBox.Size = new System.Drawing.Size(215, 23);
            this.ApiKeyBox.TabIndex = 2;
            this.ApiKeyBox.TextChanged += new System.EventHandler(this.ApiKeyBox_TextChanged);
            this.ApiKeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Close_Key);
            // 
            // ApiKeySecretBox
            // 
            this.ApiKeySecretBox.Location = new System.Drawing.Point(364, 93);
            this.ApiKeySecretBox.Name = "ApiKeySecretBox";
            this.ApiKeySecretBox.PasswordChar = '*';
            this.ApiKeySecretBox.Size = new System.Drawing.Size(215, 23);
            this.ApiKeySecretBox.TabIndex = 3;
            this.ApiKeySecretBox.TextChanged += new System.EventHandler(this.ApiKeySecretBox_TextChanged);
            this.ApiKeySecretBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Close_Key);
            // 
            // AccessTokenBox
            // 
            this.AccessTokenBox.Location = new System.Drawing.Point(364, 137);
            this.AccessTokenBox.Name = "AccessTokenBox";
            this.AccessTokenBox.PasswordChar = '*';
            this.AccessTokenBox.Size = new System.Drawing.Size(215, 23);
            this.AccessTokenBox.TabIndex = 4;
            this.AccessTokenBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Close_Key);
            // 
            // AccessTokenSecretBox
            // 
            this.AccessTokenSecretBox.Location = new System.Drawing.Point(364, 181);
            this.AccessTokenSecretBox.Name = "AccessTokenSecretBox";
            this.AccessTokenSecretBox.PasswordChar = '*';
            this.AccessTokenSecretBox.Size = new System.Drawing.Size(215, 23);
            this.AccessTokenSecretBox.TabIndex = 5;
            this.AccessTokenSecretBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Close_Key);
            // 
            // ConfigLabel
            // 
            this.ConfigLabel.AutoSize = true;
            this.ConfigLabel.Location = new System.Drawing.Point(364, 9);
            this.ConfigLabel.Name = "ConfigLabel";
            this.ConfigLabel.Size = new System.Drawing.Size(48, 15);
            this.ConfigLabel.TabIndex = 6;
            this.ConfigLabel.Text = "キー設定";
            this.ConfigLabel.Click += new System.EventHandler(this.ConfigLabel_Click);
            // 
            // TweetLabel
            // 
            this.TweetLabel.AutoSize = true;
            this.TweetLabel.Location = new System.Drawing.Point(13, 13);
            this.TweetLabel.Name = "TweetLabel";
            this.TweetLabel.Size = new System.Drawing.Size(41, 15);
            this.TweetLabel.TabIndex = 7;
            this.TweetLabel.Text = "ツイート";
            // 
            // TweetInfoLabel
            // 
            this.TweetInfoLabel.AutoSize = true;
            this.TweetInfoLabel.Location = new System.Drawing.Point(13, 173);
            this.TweetInfoLabel.Name = "TweetInfoLabel";
            this.TweetInfoLabel.Size = new System.Drawing.Size(34, 15);
            this.TweetInfoLabel.TabIndex = 8;
            this.TweetInfoLabel.Text = "INFO";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 188);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(136, 15);
            this.InfoLabel.TabIndex = 9;
            this.InfoLabel.Text = "ここに情報が表示されます。";
            // 
            // ApiKeyLabel
            // 
            this.ApiKeyLabel.AutoSize = true;
            this.ApiKeyLabel.Location = new System.Drawing.Point(364, 31);
            this.ApiKeyLabel.Name = "ApiKeyLabel";
            this.ApiKeyLabel.Size = new System.Drawing.Size(47, 15);
            this.ApiKeyLabel.TabIndex = 10;
            this.ApiKeyLabel.Text = "Api Key";
            // 
            // ApiKeySecretLabel
            // 
            this.ApiKeySecretLabel.AutoSize = true;
            this.ApiKeySecretLabel.Location = new System.Drawing.Point(364, 75);
            this.ApiKeySecretLabel.Name = "ApiKeySecretLabel";
            this.ApiKeySecretLabel.Size = new System.Drawing.Size(82, 15);
            this.ApiKeySecretLabel.TabIndex = 11;
            this.ApiKeySecretLabel.Text = "Api Key Secret";
            // 
            // AccessTokenLabel
            // 
            this.AccessTokenLabel.AutoSize = true;
            this.AccessTokenLabel.Location = new System.Drawing.Point(364, 119);
            this.AccessTokenLabel.Name = "AccessTokenLabel";
            this.AccessTokenLabel.Size = new System.Drawing.Size(77, 15);
            this.AccessTokenLabel.TabIndex = 12;
            this.AccessTokenLabel.Text = "Access Token";
            // 
            // AccessTokenSecretLabel
            // 
            this.AccessTokenSecretLabel.AutoSize = true;
            this.AccessTokenSecretLabel.Location = new System.Drawing.Point(364, 163);
            this.AccessTokenSecretLabel.Name = "AccessTokenSecretLabel";
            this.AccessTokenSecretLabel.Size = new System.Drawing.Size(112, 15);
            this.AccessTokenSecretLabel.TabIndex = 13;
            this.AccessTokenSecretLabel.Text = "Access Token Secret";
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(268, 147);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(25, 15);
            this.CounterLabel.TabIndex = 14;
            this.CounterLabel.Text = "140";
            // 
            // TweetBoxCountLabel
            // 
            this.TweetBoxCountLabel.AutoSize = true;
            this.TweetBoxCountLabel.Location = new System.Drawing.Point(187, 147);
            this.TweetBoxCountLabel.Name = "TweetBoxCountLabel";
            this.TweetBoxCountLabel.Size = new System.Drawing.Size(75, 15);
            this.TweetBoxCountLabel.TabIndex = 15;
            this.TweetBoxCountLabel.Text = "残り文字数：";
            // 
            // TwitterLink
            // 
            this.TwitterLink.AutoSize = true;
            this.TwitterLink.Location = new System.Drawing.Point(489, 9);
            this.TwitterLink.Name = "TwitterLink";
            this.TwitterLink.Size = new System.Drawing.Size(42, 15);
            this.TwitterLink.TabIndex = 16;
            this.TwitterLink.TabStop = true;
            this.TwitterLink.Text = "Twitter";
            this.TwitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TwitterLink_LinkClicked);
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(537, 9);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(42, 15);
            this.githubLink.TabIndex = 17;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "github";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // OSInfo
            // 
            this.OSInfo.AutoSize = true;
            this.OSInfo.Location = new System.Drawing.Point(9, 297);
            this.OSInfo.Name = "OSInfo";
            this.OSInfo.Size = new System.Drawing.Size(43, 15);
            this.OSInfo.TabIndex = 18;
            this.OSInfo.Text = "OSInfo";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(9, 312);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(45, 15);
            this.Version.TabIndex = 19;
            this.Version.Text = "Version";
            // 
            // ShowKey
            // 
            this.ShowKey.Location = new System.Drawing.Point(449, 210);
            this.ShowKey.Name = "ShowKey";
            this.ShowKey.Size = new System.Drawing.Size(130, 23);
            this.ShowKey.TabIndex = 20;
            this.ShowKey.Text = "キーを表示する";
            this.ShowKey.UseVisualStyleBackColor = true;
            this.ShowKey.Click += new System.EventHandler(this.ShowKey_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(504, 304);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "終了";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OauthButton
            // 
            this.OauthButton.Enabled = false;
            this.OauthButton.Location = new System.Drawing.Point(364, 209);
            this.OauthButton.Name = "OauthButton";
            this.OauthButton.Size = new System.Drawing.Size(75, 23);
            this.OauthButton.TabIndex = 22;
            this.OauthButton.Text = "認証する";
            this.OauthButton.UseVisualStyleBackColor = true;
            this.OauthButton.Click += new System.EventHandler(this.AuthTw_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "キーを保存する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(364, 239);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "リセット";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(591, 336);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OauthButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowKey);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.OSInfo);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.TwitterLink);
            this.Controls.Add(this.TweetBoxCountLabel);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.AccessTokenSecretLabel);
            this.Controls.Add(this.AccessTokenLabel);
            this.Controls.Add(this.ApiKeySecretLabel);
            this.Controls.Add(this.ApiKeyLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TweetInfoLabel);
            this.Controls.Add(this.TweetLabel);
            this.Controls.Add(this.ConfigLabel);
            this.Controls.Add(this.AccessTokenSecretBox);
            this.Controls.Add(this.AccessTokenBox);
            this.Controls.Add(this.ApiKeySecretBox);
            this.Controls.Add(this.ApiKeyBox);
            this.Controls.Add(this.tweetButton);
            this.Controls.Add(this.TweetBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Twitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Close_Key);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TweetBox;
        private System.Windows.Forms.Button tweetButton;
        private System.Windows.Forms.TextBox ApiKeyBox;
        private System.Windows.Forms.TextBox ApiKeySecretBox;
        private System.Windows.Forms.TextBox AccessTokenBox;
        private System.Windows.Forms.TextBox AccessTokenSecretBox;
        private System.Windows.Forms.Label ConfigLabel;
        private System.Windows.Forms.Label TweetLabel;
        private System.Windows.Forms.Label TweetInfoLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label ApiKeyLabel;
        private System.Windows.Forms.Label ApiKeySecretLabel;
        private System.Windows.Forms.Label AccessTokenLabel;
        private System.Windows.Forms.Label AccessTokenSecretLabel;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Label TweetBoxCountLabel;
        private System.Windows.Forms.LinkLabel TwitterLink;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label OSInfo;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button ShowKey;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OauthButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
    }
}

