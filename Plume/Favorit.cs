using System;
using System.Collections.Generic;
using System.Text;

namespace Plume
{
    class Favorit
    {
        // インスタンスフィールド(お気に入りの情報)
        public string title;        // ホームページのタイトル
        public string address;      // ホームページアドレス

        // コンストラクタ
        public Favorit(string title, string address)
        {
            this.title = title;
            this.address = address;
        }
    }
}
