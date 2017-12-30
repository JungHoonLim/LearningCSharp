using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LearningCSharp.util;

namespace LearningCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "c:/test";

            bool isSuccess = FileUtils.deleteDirectory(path);
            if (isSuccess) {
                MessageBox.Show(path + " 삭제 완료");
            }
            else {
                MessageBox.Show(path + " 에 폴더가 없습니다.");
            }
        }
    }
}
