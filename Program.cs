using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RearAlice
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult haveRearAlice = MessageBox.Show("あなたはリア-アリスをもっていますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (haveRearAlice == DialogResult.No)
            {
                OpenWebsite("https://booth.pm/ja/items/2146588");
            }
            else
            {
                MessageBox.Show("今日も素敵なリアアリスをしよう！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("リアアリスリアアリスリアアリスリアアリスリアアリス", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Twitterを開きます。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenWebsite("https://twitter.com/anko__729");
            }
        }

        static void OpenWebsite(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ウェブサイトの開封中にエラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

