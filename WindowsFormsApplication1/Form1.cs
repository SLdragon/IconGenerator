using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "选择图片";
            fileDialog.Filter = "所有文件(*.jpg)|*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK) 
            { 
                string file = fileDialog.FileName; 
                MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bitmap img = new Bitmap(file);

               
                SaveFileDialog sfd = new SaveFileDialog();
               
                sfd.Filter = "jpg文件(*.jpg)|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    String path = sfd.FileName;
                    String path36_36=path.Insert(path.Length-4,"36_36");
                    String path48_48 = path.Insert(path.Length - 4, "48_48");
                    String path72_72 = path.Insert(path.Length - 4, "72_72");
                    String path128_128 = path.Insert(path.Length - 4, "128_128");

                    Bitmap target = new Bitmap(img, new Size(36, 36));
                    target.Save(path36_36);
                    target = new Bitmap(img, new Size(48, 48));
                    target.Save(path48_48);
                    target = new Bitmap(img, new Size(72, 72));
                    target.Save(path72_72);
                    target = new Bitmap(img, new Size(128,128));
                    target.Save(path128_128); 
                }
            }
        }
    }
}
