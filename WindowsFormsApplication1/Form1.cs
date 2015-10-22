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
                Bitmap img = new Bitmap(file);
                MessageBox.Show("已选择文件:" + file+"\n图片尺寸："+img.Width+"×"+img.Height, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               
                SaveFileDialog sfd = new SaveFileDialog();                
               
                sfd.Filter = "jpg文件(*.jpg)|*.jpg";
                Bitmap target;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    String path = sfd.FileName;

                    if (checkbox.Checked)
                    {
                        String path36_36 = path.Insert(path.Length - 4, "36_36");
                        String path48_48 = path.Insert(path.Length - 4, "48_48");
                        String path72_72 = path.Insert(path.Length - 4, "72_72");
                        String path128_128 = path.Insert(path.Length - 4, "128_128");

                        target = new Bitmap(img, new Size(36, 36));
                        target.Save(path36_36);
                        target = new Bitmap(img, new Size(48, 48));
                        target.Save(path48_48);
                        target = new Bitmap(img, new Size(72, 72));
                        target.Save(path72_72);
                        target = new Bitmap(img, new Size(128, 128));
                        target.Save(path128_128);
                    }
                    else
                    {
                        String newPath = path.Insert(path.Length - 4, "new");
                        int width, height;
                        int.TryParse(textWidth.Text, out width);
                        int.TryParse(textHeight.Text, out height);

                        if (width == 0)
                        {
                            width = img.Width;
                            textWidth.Text = img.Width.ToString();
                        }
                        if (height == 0)
                        {
                            height = img.Height;
                            textHeight.Text = img.Height.ToString();
                        }
                        
                        target = new Bitmap(img, new Size(width, height));
                        target.Save(newPath);
                    }

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked)
            {
                textWidth.Enabled = false;
                textHeight.Enabled = false;
                label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            }
            else
            {
                textWidth.Enabled = true;
                textHeight.Enabled = true;
                label1.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }
    }
}
