using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;

namespace Plume
{
    public partial class Form1 : Form
    {
        [DllImport("inetcpl.cpl")]
        public static extern bool LaunchInternetControlPanel(IntPtr hWnd);

        // お気に入りを格納する配列
        public ArrayList collectionFavorit = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            // 起動時のコンボボックスのサイズ変更
            toolAddress.Width = toolStrip1.Width - 160;

            // お気に入り用配列を初期化する
            collectionFavorit = new ArrayList();

            // ファイルを開くお約束の項目
            if(File.Exists(Application.StartupPath + @"\bookmark.txt") == true){
                FileStream stream = new FileStream(Application.StartupPath + @"\bookmark.txt", FileMode.Open);
                StreamReader reader = new StreamReader(stream, Encoding.Default);

                while(reader.Peek() > -1){
                    string title = reader.ReadLine();
                    string address = reader.ReadLine();
                    Favorit Favotit = new Favorit(title, address);
                    collectionFavorit.Add(Favotit);
                }

                reader.Close();
                stream.Close();

                foreach(Favorit fav in collectionFavorit){
                    ToolStripMenuItem favitem = new ToolStripMenuItem();
                    favitem.Text = fav.title;
                    favitem.ToolTipText = fav.address;
                    menuFavorit.DropDownItems.Add(favitem);
                }
            }
            else{
                // お気に入りの追加のみ表示させる
                toolStripSeparator4.Visible = false;
            }

            axWebBrowser1.GoHome();
        }

        private void toolGoBack_Click(object sender, EventArgs e)
        {
            axWebBrowser1.GoBack();
        }

        private void toolGoForward_Click(object sender, EventArgs e)
        {
            axWebBrowser1.GoForward();
        }

        private void toolStop_Click(object sender, EventArgs e)
        {
            if(axWebBrowser1.Busy == true){
                axWebBrowser1.Stop();
            }
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            if(axWebBrowser1.Document != null){
                axWebBrowser1.Refresh();
            }
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            axWebBrowser1.GoHome();
        }

        private void toolNavigate_Click(object sender, EventArgs e)
        {
            if(toolAddress.Text == ""){
                toolAddress.Text = "about:blank";
            }
            
            try{
                string url = toolAddress.Text;
                if (!toolAddress.Text.StartsWith("http://") && !toolAddress.Text.StartsWith("https://") && !toolAddress.Text.StartsWith("ftp://") && !toolAddress.Text.StartsWith("about:")) {
                    url = "http://" + url;
                }
                axWebBrowser1.Navigate(url);
                toolAddress.Items.Add(url);
            }
            catch{
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            
        }

        private void toolAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                try{
                    string url = toolAddress.Text;
                    if(!toolAddress.Text.StartsWith("http://") && !toolAddress.Text.StartsWith("https://") && !toolAddress.Text.StartsWith("ftp://")){
                        url = "http://" + url;
                    }
                    axWebBrowser1.Navigate(url);
                    toolAddress.Items.Add(url);
                }
                catch{
                }
            }
        }

        private void toolAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                axWebBrowser1.Navigate(toolAddress.Text);
            }
            catch{
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_Resize(object sender, EventArgs e)
        {
            toolAddress.Width = toolStrip1.Width - 160;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            Object obj = null;
            axWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_SAVEAS, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref obj, ref obj);
        }

        private void menuPrint_Click(object sender, EventArgs e)
        {
            Object obj = null;
            axWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref obj, ref obj);
        }

        private void menuProperty_Click(object sender, EventArgs e)
        {
            Object obj = null;
            axWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PROPERTIES, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref obj, ref obj);
        }

        private void menuInternetOption_Click(object sender, EventArgs e)
        {
            bool ret = LaunchInternetControlPanel(this.Handle);
        }

        private void menuFavorit_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // お気に入りに追加と仕切りは反応させない
            if(e.ClickedItem.Text.StartsWith("お気に入り") || e.ClickedItem.Name.ToString().StartsWith("toolStripSeparator")){
                return;
            }

            try{
                string url = e.ClickedItem.ToolTipText;
                axWebBrowser1.Navigate(url);
                toolAddress.Items.Add(url);
            }
            catch{
            }
        }

        private void menuAddFavorite_Click(object sender, EventArgs e)
        {
            Form2 favAddForm = new Form2();
            favAddForm.textTitle.Text = axWebBrowser1.LocationName;
            favAddForm.textUrl.Text = axWebBrowser1.LocationURL;
            DialogResult res = favAddForm.ShowDialog();

            if(res == DialogResult.OK){
                // コレクションに追加する
                Favorit Favotit = new Favorit(favAddForm.textTitle.Text, favAddForm.textUrl.Text);
                collectionFavorit.Add(Favotit);

                if(menuFavorit.DropDownItems.Count >= 2){
                    toolStripSeparator4.Visible = true;
                    menuEditFavorite.Enabled = true;
                }

                // お気に入りメニューに新規項目を追加
                ToolStripMenuItem favitem = new ToolStripMenuItem();
                favitem.Text = ((Favorit)collectionFavorit[collectionFavorit.Count - 1]).title;
                favitem.ToolTipText = ((Favorit)collectionFavorit[collectionFavorit.Count - 1]).address;
                menuFavorit.DropDownItems.Add(favitem);

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // データファイルを削除する
            if(File.Exists(Application.StartupPath + @"bookmark.txt") == true){
                File.Delete(Application.StartupPath + @"bookmark.txt");
            }

            // ファイルストリームを作成する
            FileStream stream = new FileStream(Application.StartupPath + @"\bookmark.txt", FileMode.Create);

            // ファイルストリームをストリームライタに関連付ける
            StreamWriter writer = new StreamWriter(stream, Encoding.Default);

            // お気に入りの情報を書き込む
            foreach(Favorit fav in collectionFavorit) {
                writer.WriteLine(fav.title);
                writer.WriteLine(fav.address);
            }

            // ストリームライタとファイルストリームを閉じる
            writer.Close();
            stream.Close();
        }

        private void menuEditFavorite_Click(object sender, EventArgs e)
        {
            Form3 favEditForm = new Form3();

            // 現在のお気に入りを編集用リストに格納する
            favEditForm.listView1.Items.Clear();

            foreach(Favorit fav in collectionFavorit){
                ListViewItem lvitem = new ListViewItem();
                lvitem.Text = fav.title;
                lvitem.SubItems.Add(fav.address);
                favEditForm.listView1.Items.Add(lvitem);
            }

            DialogResult res = favEditForm.ShowDialog();

            if(res == DialogResult.OK){
                // お気に入り配列をクリアする
                collectionFavorit.Clear();

                // お気に入り配列を再構築する
                for(int i = 0; favEditForm.listView1.Items.Count > i; i++){
                    Favorit fav = new Favorit(favEditForm.listView1.Items[i].Text, favEditForm.listView1.Items[i].SubItems[1].Text);
                    collectionFavorit.Add(fav);
                }
                
                // お気に入りメニューを一度削除
                int itemCount = menuFavorit.DropDownItems.Count - 1;

                do{
                    menuFavorit.DropDownItems.RemoveAt(itemCount);
                    itemCount--;
                }while(itemCount > 2);

                foreach(Favorit fav in collectionFavorit){
                    ToolStripMenuItem favitem = new ToolStripMenuItem();
                    favitem.Text = fav.title;
                    favitem.ToolTipText = fav.address;
                    menuFavorit.DropDownItems.Add(favitem);
                }

                if(menuFavorit.DropDownItems.Count <= 3){
                    toolStripSeparator4.Visible = false;
                    menuEditFavorite.Enabled = false;
                }
            }
        }

        private void axWebBrowser1_StatusTextChange(object sender, AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent e)
        {
            toolStatus.Text = e.text;
        }

        private void axWebBrowser1_NavigateComplete2(object sender, AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event e)
        {
            toolAddress.Text = e.uRL.ToString();
        }

        private void axWebBrowser1_TitleChange(object sender, AxSHDocVw.DWebBrowserEvents2_TitleChangeEvent e)
        {
            this.Text = e.text + " - Plume";
        }

        private void axWebBrowser1_CommandStateChange(object sender, AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEvent e)
        {
            const uint CSC_NAVIGATEFORWARD = 0x00000001;
            const uint CSC_NAVIGATEBACK = 0x00000002;

            switch ((uint)e.command) {
                case CSC_NAVIGATEFORWARD:
                    toolGoForward.Enabled = e.enable;
                    break;
                case CSC_NAVIGATEBACK:
                    toolGoBack.Enabled = e.enable;
                    break;
            }
        }

        private void axWebBrowser1_NewWindow2(object sender, AxSHDocVw.DWebBrowserEvents2_NewWindow2Event e)
        {
            Form1 frmNewForm;
            frmNewForm = new Form1();

            frmNewForm.axWebBrowser1.RegisterAsBrowser = true;
            e.ppDisp = frmNewForm.axWebBrowser1.Application;
            frmNewForm.Visible = true;
        }

        private void menuPageSet_Click(object sender, EventArgs e)
        {
            Object obj = null;
            axWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PAGESETUP, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref obj, ref obj);
        }

        private void menuPrintPreview_Click(object sender, EventArgs e)
        {
            Object obj = null;
            axWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINTPREVIEW, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref obj, ref obj);
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            Form4 frmFileOpen;
            frmFileOpen = new Form4();
            DialogResult ret = frmFileOpen.ShowDialog();

            if(ret == DialogResult.OK){
                try{
                    string url = frmFileOpen.cmbFileName.Text;
                    axWebBrowser1.Navigate(url);
                    toolAddress.Items.Add(url);
                }
                catch{
                }
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            Form5 frmAbout;
            frmAbout = new Form5();
            frmAbout.ShowDialog();

            if(frmAbout.linkflag == DialogResult.OK){
                string url = "http://www.angel-teatime.com/";
                axWebBrowser1.Navigate(url);
                toolAddress.Items.Add(url);
            }
        }
    }
}