
namespace post
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startpost = new MaterialSkin.Controls.MaterialButton();
            this.stoppost = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passtext = new MaterialSkin.Controls.MaterialTextBox();
            this.gmailtext = new MaterialSkin.Controls.MaterialTextBox();
            this.linktext = new MaterialSkin.Controls.MaterialTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.teamnametext = new MaterialSkin.Controls.MaterialTextBox();
            this.stopnumbertext = new MaterialSkin.Controls.MaterialTextBox();
            this.startnumbertext = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.update = new MaterialSkin.Controls.MaterialButton();
            this.entername = new MaterialSkin.Controls.MaterialTextBox();
            this.yolla = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // startpost
            // 
            this.startpost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startpost.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startpost.Depth = 0;
            this.startpost.HighEmphasis = true;
            this.startpost.Icon = null;
            this.startpost.Location = new System.Drawing.Point(51, 36);
            this.startpost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startpost.MouseState = MaterialSkin.MouseState.HOVER;
            this.startpost.Name = "startpost";
            this.startpost.Size = new System.Drawing.Size(132, 36);
            this.startpost.TabIndex = 3;
            this.startpost.Text = "START POSTING";
            this.startpost.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startpost.UseAccentColor = false;
            this.startpost.UseVisualStyleBackColor = true;
            this.startpost.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // stoppost
            // 
            this.stoppost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stoppost.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stoppost.Depth = 0;
            this.stoppost.HighEmphasis = true;
            this.stoppost.Icon = null;
            this.stoppost.Location = new System.Drawing.Point(191, 36);
            this.stoppost.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stoppost.MouseState = MaterialSkin.MouseState.HOVER;
            this.stoppost.Name = "stoppost";
            this.stoppost.Size = new System.Drawing.Size(131, 36);
            this.stoppost.TabIndex = 3;
            this.stoppost.Text = "STOP   POSTING ";
            this.stoppost.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stoppost.UseAccentColor = false;
            this.stoppost.UseVisualStyleBackColor = true;
            this.stoppost.Click += new System.EventHandler(this.stoppost_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(306, 61);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(138, 36);
            this.materialButton3.TabIndex = 7;
            this.materialButton3.Text = "authtenticate";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passtext);
            this.groupBox1.Controls.Add(this.gmailtext);
            this.groupBox1.Controls.Add(this.materialButton3);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login informations";
            // 
            // passtext
            // 
            this.passtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtext.Depth = 0;
            this.passtext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passtext.Hint = "password *";
            this.passtext.LeadingIcon = null;
            this.passtext.Location = new System.Drawing.Point(21, 86);
            this.passtext.MaxLength = 50;
            this.passtext.MouseState = MaterialSkin.MouseState.OUT;
            this.passtext.Multiline = false;
            this.passtext.Name = "passtext";
            this.passtext.Password = true;
            this.passtext.Size = new System.Drawing.Size(278, 50);
            this.passtext.TabIndex = 9;
            this.passtext.Text = "";
            this.passtext.TrailingIcon = null;
            // 
            // gmailtext
            // 
            this.gmailtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gmailtext.Depth = 0;
            this.gmailtext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gmailtext.Hint = "@gmail.com *";
            this.gmailtext.LeadingIcon = null;
            this.gmailtext.Location = new System.Drawing.Point(21, 30);
            this.gmailtext.MaxLength = 50;
            this.gmailtext.MouseState = MaterialSkin.MouseState.OUT;
            this.gmailtext.Multiline = false;
            this.gmailtext.Name = "gmailtext";
            this.gmailtext.Size = new System.Drawing.Size(278, 50);
            this.gmailtext.TabIndex = 8;
            this.gmailtext.Text = "";
            this.gmailtext.TrailingIcon = null;
            // 
            // linktext
            // 
            this.linktext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linktext.Depth = 0;
            this.linktext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.linktext.Hint = "Link text *";
            this.linktext.LeadingIcon = null;
            this.linktext.Location = new System.Drawing.Point(17, 84);
            this.linktext.MaxLength = 50;
            this.linktext.MouseState = MaterialSkin.MouseState.OUT;
            this.linktext.Multiline = false;
            this.linktext.Name = "linktext";
            this.linktext.Size = new System.Drawing.Size(168, 50);
            this.linktext.TabIndex = 10;
            this.linktext.Text = "";
            this.linktext.TrailingIcon = null;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(619, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialTextBox2);
            this.groupBox2.Controls.Add(this.materialTextBox1);
            this.groupBox2.Controls.Add(this.teamnametext);
            this.groupBox2.Controls.Add(this.linktext);
            this.groupBox2.Controls.Add(this.stopnumbertext);
            this.groupBox2.Controls.Add(this.startnumbertext);
            this.groupBox2.Location = new System.Drawing.Point(6, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 207);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Enabled = false;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "#";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(191, 84);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.ReadOnly = true;
            this.materialTextBox2.Size = new System.Drawing.Size(168, 50);
            this.materialTextBox2.TabIndex = 14;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Enabled = false;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "#";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(191, 28);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.ReadOnly = true;
            this.materialTextBox1.Size = new System.Drawing.Size(168, 50);
            this.materialTextBox1.TabIndex = 13;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // teamnametext
            // 
            this.teamnametext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamnametext.Depth = 0;
            this.teamnametext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.teamnametext.Hint = "Team name *";
            this.teamnametext.LeadingIcon = null;
            this.teamnametext.Location = new System.Drawing.Point(17, 26);
            this.teamnametext.MaxLength = 50;
            this.teamnametext.MouseState = MaterialSkin.MouseState.OUT;
            this.teamnametext.Multiline = false;
            this.teamnametext.Name = "teamnametext";
            this.teamnametext.Size = new System.Drawing.Size(168, 50);
            this.teamnametext.TabIndex = 12;
            this.teamnametext.Text = "";
            this.teamnametext.TrailingIcon = null;
            // 
            // stopnumbertext
            // 
            this.stopnumbertext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stopnumbertext.Depth = 0;
            this.stopnumbertext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stopnumbertext.Hint = "Stop post number *";
            this.stopnumbertext.LeadingIcon = null;
            this.stopnumbertext.Location = new System.Drawing.Point(191, 138);
            this.stopnumbertext.MaxLength = 50;
            this.stopnumbertext.MouseState = MaterialSkin.MouseState.OUT;
            this.stopnumbertext.Multiline = false;
            this.stopnumbertext.Name = "stopnumbertext";
            this.stopnumbertext.Size = new System.Drawing.Size(168, 50);
            this.stopnumbertext.TabIndex = 11;
            this.stopnumbertext.Text = "";
            this.stopnumbertext.TrailingIcon = null;
            // 
            // startnumbertext
            // 
            this.startnumbertext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startnumbertext.Depth = 0;
            this.startnumbertext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.startnumbertext.Hint = "Start post number *";
            this.startnumbertext.LeadingIcon = null;
            this.startnumbertext.Location = new System.Drawing.Point(17, 140);
            this.startnumbertext.MaxLength = 50;
            this.startnumbertext.MouseState = MaterialSkin.MouseState.OUT;
            this.startnumbertext.Multiline = false;
            this.startnumbertext.Name = "startnumbertext";
            this.startnumbertext.Size = new System.Drawing.Size(168, 50);
            this.startnumbertext.TabIndex = 10;
            this.startnumbertext.Text = "";
            this.startnumbertext.TrailingIcon = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialButton1);
            this.groupBox3.Controls.Add(this.update);
            this.groupBox3.Controls.Add(this.entername);
            this.groupBox3.Controls.Add(this.yolla);
            this.groupBox3.Controls.Add(this.materialButton5);
            this.groupBox3.Controls.Add(this.materialButton2);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 298);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(192, 19);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "ADD";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_2);
            // 
            // update
            // 
            this.update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.update.Depth = 0;
            this.update.HighEmphasis = true;
            this.update.Icon = null;
            this.update.Location = new System.Drawing.Point(192, 19);
            this.update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.update.MouseState = MaterialSkin.MouseState.HOVER;
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(64, 36);
            this.update.TabIndex = 19;
            this.update.Text = "ADD";
            this.update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.update.UseAccentColor = false;
            this.update.UseVisualStyleBackColor = true;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // entername
            // 
            this.entername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entername.Depth = 0;
            this.entername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.entername.Hint = "Enter name *";
            this.entername.LeadingIcon = null;
            this.entername.Location = new System.Drawing.Point(17, 19);
            this.entername.MaxLength = 50;
            this.entername.MouseState = MaterialSkin.MouseState.OUT;
            this.entername.Multiline = false;
            this.entername.Name = "entername";
            this.entername.Size = new System.Drawing.Size(168, 50);
            this.entername.TabIndex = 12;
            this.entername.Text = "";
            this.entername.TrailingIcon = null;
            // 
            // yolla
            // 
            this.yolla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.yolla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yolla.Depth = 0;
            this.yolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yolla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yolla.Hint = "Enter text message *";
            this.yolla.Location = new System.Drawing.Point(306, 98);
            this.yolla.MouseState = MaterialSkin.MouseState.HOVER;
            this.yolla.Name = "yolla";
            this.yolla.Size = new System.Drawing.Size(246, 169);
            this.yolla.TabIndex = 15;
            this.yolla.Text = "Enter text message";
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(306, 59);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.Size = new System.Drawing.Size(129, 36);
            this.materialButton5.TabIndex = 18;
            this.materialButton5.Text = "STOP MESSAGE  ";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(306, 19);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(138, 36);
            this.materialButton2.TabIndex = 16;
            this.materialButton2.Text = "START MESSAGE";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(249, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Name (Right click to remove name)";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(17, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 162);
            this.listBox1.TabIndex = 14;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(619, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-8, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(880, 48);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 119);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(775, 536);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.materialMultiLineTextBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto Poster";
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(472, 188);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(289, 322);
            this.listBox2.TabIndex = 17;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Hint = "Enter text message *";
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(472, 27);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.ReadOnly = true;
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(289, 149);
            this.materialMultiLineTextBox1.TabIndex = 16;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.startpost);
            this.groupBox4.Controls.Add(this.stoppost);
            this.groupBox4.Location = new System.Drawing.Point(6, 403);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 95);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Start/Stop";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.materialMultiLineTextBox2);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto dm message";
            // 
            // materialMultiLineTextBox2
            // 
            this.materialMultiLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox2.Depth = 0;
            this.materialMultiLineTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox2.Hint = "Enter text message *";
            this.materialMultiLineTextBox2.Location = new System.Drawing.Point(472, 27);
            this.materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            this.materialMultiLineTextBox2.ReadOnly = true;
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(289, 149);
            this.materialMultiLineTextBox2.TabIndex = 17;
            this.materialMultiLineTextBox2.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.materialTextBox3);
            this.groupBox5.Controls.Add(this.materialTextBox4);
            this.groupBox5.Controls.Add(this.materialButton7);
            this.groupBox5.Location = new System.Drawing.Point(6, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 156);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Login informations";
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "password *";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(21, 86);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Password = true;
            this.materialTextBox3.Size = new System.Drawing.Size(278, 50);
            this.materialTextBox3.TabIndex = 9;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.Hint = "@gmail.com *";
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(21, 30);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(278, 50);
            this.materialTextBox4.TabIndex = 8;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(306, 61);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(138, 36);
            this.materialButton7.TabIndex = 7;
            this.materialButton7.Text = "authtenticate";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 648);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "trash by baris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton startpost;
        private MaterialSkin.Controls.MaterialButton stoppost;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox passtext;
        private MaterialSkin.Controls.MaterialTextBox gmailtext;
        private MaterialSkin.Controls.MaterialTextBox linktext;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox teamnametext;
        private MaterialSkin.Controls.MaterialTextBox stopnumbertext;
        private MaterialSkin.Controls.MaterialTextBox startnumbertext;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox entername;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox yolla;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private System.Windows.Forms.CheckBox checkBox2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialButton update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox2;
        private System.Windows.Forms.ListBox listBox2;
    }
}

