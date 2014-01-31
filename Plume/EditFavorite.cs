using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Plume
{
    public partial class EditFavorite : Form
    {
        // 選択された行を格納するフィールド
        private int currentRow;

        // お気に入りを格納する配列
        public ArrayList collectionFavorit = new ArrayList();

        public EditFavorite()
        {
            InitializeComponent();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // 選択された行を取得する
            currentRow = e.ItemIndex;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            // 配列をクリアする
            collectionFavorit.Clear();
            int listCiunt = listView1.Items.Count;

            for (int i = 0; listCiunt > i; i++) {
                // 取得したお気に入りの内容を配列に取り込む
                Favorit fav = new Favorit(listView1.Items[i].Text, listView1.Items[i].SubItems[1].Text);
                collectionFavorit.Add(fav);
            }

            // 選択しているアイテムをテキストに表示
            textSiteTitle.Text = listView1.Items[currentRow].Text;
            textUrl.Text = listView1.Items[currentRow].SubItems[1].Text;

            // 編集と削除ボタンを有効にする
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // 削除の確認メッセージ
            DialogResult ret = MessageBox.Show(textSiteTitle.Text + "を削除しますか？", "Plume", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (ret == DialogResult.OK) {
                collectionFavorit.RemoveAt(currentRow);
                UpdateListView();
            }
        }

        public void UpdateListView()
        {
            // リストビューの内容をクリアする
            listView1.Items.Clear();

            foreach (Favorit fav in collectionFavorit) {
                ListViewItem item = new ListViewItem();
                item.Text = fav.title;
                item.SubItems.Add(fav.address);
                listView1.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // 編集の確認メッセージ
            DialogResult ret = MessageBox.Show(listView1.Items[currentRow].Text + "を編集しますか？", "Plume", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (ret == DialogResult.OK) {
                listView1.Items[currentRow].Text = textSiteTitle.Text;
                listView1.Items[currentRow].SubItems[1].Text = textUrl.Text;
            }
        }
    }
}