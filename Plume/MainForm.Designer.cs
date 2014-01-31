namespace Plume
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPageSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSourceView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFavorit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddFavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditFavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInternetOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolGoBack = new System.Windows.Forms.ToolStripButton();
            this.toolGoForward = new System.Windows.Forms.ToolStripButton();
            this.toolStop = new System.Windows.Forms.ToolStripButton();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAddress = new System.Windows.Forms.ToolStripComboBox();
            this.toolNavigate = new System.Windows.Forms.ToolStripButton();
            this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.menuFavorit,
            this.ツールTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSave,
            this.toolStripSeparator3,
            this.menuPageSet,
            this.menuPrint,
            this.menuPrintPreview,
            this.toolStripSeparator2,
            this.menuProperty,
            this.menuExit});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(226, 22);
            this.menuOpen.Text = "開く(&O)";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(226, 22);
            this.menuSave.Text = "名前を付けて保存(&A)...";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // menuPageSet
            // 
            this.menuPageSet.Name = "menuPageSet";
            this.menuPageSet.Size = new System.Drawing.Size(226, 22);
            this.menuPageSet.Text = "ページ設定(&U)...";
            this.menuPageSet.Click += new System.EventHandler(this.menuPageSet_Click);
            // 
            // menuPrint
            // 
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(226, 22);
            this.menuPrint.Text = "印刷(&P)...";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // menuPrintPreview
            // 
            this.menuPrintPreview.Name = "menuPrintPreview";
            this.menuPrintPreview.Size = new System.Drawing.Size(226, 22);
            this.menuPrintPreview.Text = "印刷プレビュー(&R)";
            this.menuPrintPreview.Click += new System.EventHandler(this.menuPrintPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // menuProperty
            // 
            this.menuProperty.Name = "menuProperty";
            this.menuProperty.Size = new System.Drawing.Size(226, 22);
            this.menuProperty.Text = "プロパティ(&R)";
            this.menuProperty.Click += new System.EventHandler(this.menuProperty_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(226, 22);
            this.menuExit.Text = "アプリケーションの終了(&X)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSourceView});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.表示VToolStripMenuItem.Text = "表示(&V)";
            // 
            // menuSourceView
            // 
            this.menuSourceView.Name = "menuSourceView";
            this.menuSourceView.Size = new System.Drawing.Size(130, 22);
            this.menuSourceView.Text = "ソース(&C)";
            // 
            // menuFavorit
            // 
            this.menuFavorit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddFavorite,
            this.menuEditFavorite,
            this.toolStripSeparator4});
            this.menuFavorit.Name = "menuFavorit";
            this.menuFavorit.Size = new System.Drawing.Size(98, 22);
            this.menuFavorit.Text = "お気に入り(&A)";
            this.menuFavorit.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuFavorit_DropDownItemClicked);
            // 
            // menuAddFavorite
            // 
            this.menuAddFavorite.Name = "menuAddFavorite";
            this.menuAddFavorite.Size = new System.Drawing.Size(191, 22);
            this.menuAddFavorite.Text = "お気に入りに追加(&D)";
            this.menuAddFavorite.Click += new System.EventHandler(this.menuAddFavorite_Click);
            // 
            // menuEditFavorite
            // 
            this.menuEditFavorite.Name = "menuEditFavorite";
            this.menuEditFavorite.Size = new System.Drawing.Size(191, 22);
            this.menuEditFavorite.Text = "お気に入りの編集(&E)";
            this.menuEditFavorite.Click += new System.EventHandler(this.menuEditFavorite_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInternetOption});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // menuInternetOption
            // 
            this.menuInternetOption.Name = "menuInternetOption";
            this.menuInternetOption.Size = new System.Drawing.Size(243, 22);
            this.menuInternetOption.Text = "インターネット オプション(&O)";
            this.menuInternetOption.Click += new System.EventHandler(this.menuInternetOption_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(178, 22);
            this.menuAbout.Text = "バージョン情報(&A)";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatus
            // 
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(12, 18);
            this.toolStatus.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGoBack,
            this.toolGoForward,
            this.toolStop,
            this.toolRefresh,
            this.toolHome,
            this.toolStripSeparator1,
            this.toolAddress,
            this.toolNavigate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 26);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Resize += new System.EventHandler(this.toolStrip1_Resize);
            // 
            // toolGoBack
            // 
            this.toolGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGoBack.Enabled = false;
            this.toolGoBack.Image = ((System.Drawing.Image)(resources.GetObject("toolGoBack.Image")));
            this.toolGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGoBack.Name = "toolGoBack";
            this.toolGoBack.Size = new System.Drawing.Size(23, 23);
            this.toolGoBack.Text = "戻る";
            this.toolGoBack.Click += new System.EventHandler(this.toolGoBack_Click);
            // 
            // toolGoForward
            // 
            this.toolGoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGoForward.Enabled = false;
            this.toolGoForward.Image = ((System.Drawing.Image)(resources.GetObject("toolGoForward.Image")));
            this.toolGoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGoForward.Name = "toolGoForward";
            this.toolGoForward.Size = new System.Drawing.Size(23, 23);
            this.toolGoForward.Text = "進む";
            this.toolGoForward.Click += new System.EventHandler(this.toolGoForward_Click);
            // 
            // toolStop
            // 
            this.toolStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStop.Image")));
            this.toolStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStop.Name = "toolStop";
            this.toolStop.Size = new System.Drawing.Size(23, 23);
            this.toolStop.Text = "中止";
            this.toolStop.Click += new System.EventHandler(this.toolStop_Click);
            // 
            // toolRefresh
            // 
            this.toolRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolRefresh.Image")));
            this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(23, 23);
            this.toolRefresh.Text = "更新";
            this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // toolHome
            // 
            this.toolHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHome.Image = ((System.Drawing.Image)(resources.GetObject("toolHome.Image")));
            this.toolHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHome.Name = "toolHome";
            this.toolHome.Size = new System.Drawing.Size(23, 23);
            this.toolHome.Text = "ホーム";
            this.toolHome.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolAddress
            // 
            this.toolAddress.AutoSize = false;
            this.toolAddress.Name = "toolAddress";
            this.toolAddress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolAddress.Size = new System.Drawing.Size(121, 26);
            this.toolAddress.SelectedIndexChanged += new System.EventHandler(this.toolAddress_SelectedIndexChanged);
            this.toolAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolAddress_KeyDown);
            // 
            // toolNavigate
            // 
            this.toolNavigate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNavigate.Image = ((System.Drawing.Image)(resources.GetObject("toolNavigate.Image")));
            this.toolNavigate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNavigate.Name = "toolNavigate";
            this.toolNavigate.Size = new System.Drawing.Size(23, 23);
            this.toolNavigate.Text = "移動";
            this.toolNavigate.Click += new System.EventHandler(this.toolNavigate_Click);
            // 
            // axWebBrowser1
            // 
            this.axWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser1.Enabled = true;
            this.axWebBrowser1.Location = new System.Drawing.Point(0, 52);
            this.axWebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser1.OcxState")));
            this.axWebBrowser1.Size = new System.Drawing.Size(784, 488);
            this.axWebBrowser1.TabIndex = 6;
            this.axWebBrowser1.StatusTextChange += new AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler(this.axWebBrowser1_StatusTextChange);
            this.axWebBrowser1.CommandStateChange += new AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler(this.axWebBrowser1_CommandStateChange);
            this.axWebBrowser1.TitleChange += new AxSHDocVw.DWebBrowserEvents2_TitleChangeEventHandler(this.axWebBrowser1_TitleChange);
            this.axWebBrowser1.NewWindow2 += new AxSHDocVw.DWebBrowserEvents2_NewWindow2EventHandler(this.axWebBrowser1_NewWindow2);
            this.axWebBrowser1.NavigateComplete2 += new AxSHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler(this.axWebBrowser1_NavigateComplete2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 563);
            this.Controls.Add(this.axWebBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Plume";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolGoBack;
        private System.Windows.Forms.ToolStripButton toolGoForward;
        private System.Windows.Forms.ToolStripButton toolStop;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.ToolStripButton toolHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolAddress;
        private System.Windows.Forms.ToolStripButton toolNavigate;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuProperty;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSourceView;
        private System.Windows.Forms.ToolStripMenuItem menuInternetOption;
        private System.Windows.Forms.ToolStripMenuItem menuFavorit;
        private System.Windows.Forms.ToolStripMenuItem menuAddFavorite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuEditFavorite;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private AxSHDocVw.AxWebBrowser axWebBrowser1;
        private System.Windows.Forms.ToolStripMenuItem menuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem menuPageSet;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
    }
}

