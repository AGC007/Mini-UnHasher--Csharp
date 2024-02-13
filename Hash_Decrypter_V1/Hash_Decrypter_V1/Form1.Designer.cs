namespace Hash_Decrypter_V1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TXT_HASH = new ns1.BunifuMaterialTextbox();
            this.BTN_FIND = new RelyUI.Controls.RelyButton();
            this.TXT_LED = new RelyUI.Controls.RelyTextBox();
            this.metroControlBox1 = new MetroSuite.MetroControlBox();
            this.SuspendLayout();
            // 
            // TXT_HASH
            // 
            this.TXT_HASH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_HASH.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_HASH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_HASH.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_HASH.HintText = "Enter Your Hash :";
            this.TXT_HASH.isPassword = false;
            this.TXT_HASH.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TXT_HASH.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TXT_HASH.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TXT_HASH.LineThickness = 3;
            this.TXT_HASH.Location = new System.Drawing.Point(15, 33);
            this.TXT_HASH.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_HASH.Name = "TXT_HASH";
            this.TXT_HASH.Size = new System.Drawing.Size(485, 52);
            this.TXT_HASH.TabIndex = 0;
            this.TXT_HASH.Tag = "";
            this.TXT_HASH.Text = "Enter Your Hash:";
            this.TXT_HASH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BTN_FIND
            // 
            this.BTN_FIND.BackColor = System.Drawing.Color.Transparent;
            this.BTN_FIND.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_FIND.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_FIND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_FIND.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_FIND.Location = new System.Drawing.Point(15, 97);
            this.BTN_FIND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_FIND.Name = "BTN_FIND";
            this.BTN_FIND.Rounded = true;
            this.BTN_FIND.RoundRadius = 3;
            this.BTN_FIND.Size = new System.Drawing.Size(485, 56);
            this.BTN_FIND.TabIndex = 1;
            this.BTN_FIND.Text = "FIND";
            this.BTN_FIND.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BTN_FIND.Click += new System.EventHandler(this.BTN_FIND_Click);
            // 
            // TXT_LED
            // 
            this.TXT_LED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.TXT_LED.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.TXT_LED.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.TXT_LED.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TXT_LED.Location = new System.Drawing.Point(15, 164);
            this.TXT_LED.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_LED.MaxLength = 32767;
            this.TXT_LED.Multiline = true;
            this.TXT_LED.Name = "TXT_LED";
            this.TXT_LED.ReadOnly = false;
            this.TXT_LED.Size = new System.Drawing.Size(485, 155);
            this.TXT_LED.TabIndex = 2;
            this.TXT_LED.Text = "Enter Your Hash And Click The Find Button :)";
            this.TXT_LED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_LED.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroControlBox1.Location = new System.Drawing.Point(407, 4);
            this.metroControlBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(96, 32);
            this.metroControlBox1.TabIndex = 3;
            // 
            // Home
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 335);
            this.Controls.Add(this.metroControlBox1);
            this.Controls.Add(this.TXT_LED);
            this.Controls.Add(this.BTN_FIND);
            this.Controls.Add(this.TXT_HASH);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Normal;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "Mini-UnHasher-[V1] By AGC007™";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuMaterialTextbox TXT_HASH;
        private RelyUI.Controls.RelyButton BTN_FIND;
        private RelyUI.Controls.RelyTextBox TXT_LED;
        private MetroSuite.MetroControlBox metroControlBox1;
    }
}

