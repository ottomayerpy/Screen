using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Screen
{
    public partial class Form1 : Form
    {
        Bitmap BM = new Bitmap(
            System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width,
            System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
        Graphics GH = null;

        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
                if (DateTime.Now.ToLongTimeString() == textBox1.Text)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        GH = Graphics.FromImage(BM as Image);
                        GH.CopyFromScreen(0, 0, 0, 0, BM.Size);
                        BM.Save(@"C:\Users\UserPC\Desktop\Screen\Shot" + i.ToString() + ".jpg");
                        Thread.Sleep(1000);
                    }
                    break;
                }
        }
    }
}