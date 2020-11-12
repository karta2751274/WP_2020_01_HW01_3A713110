using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace WP_2020_01_HW01_3A713110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                //提取輸入內容
                string input_str = tbInput.Text;

                MD5 md5 = MD5.Create();//建立一個MD5
                byte[] source = Encoding.Default.GetBytes(tbInput.Text);//將字串轉為Byte[]
                byte[] crypto = md5.ComputeHash(source);//進行MD5加密
                string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串

                MessageBox.Show("姓名分析:  " + result);//輸出結果


            }
            catch (Exception)
            {
                //錯誤提示
                MessageBox.Show($"不要亂輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
