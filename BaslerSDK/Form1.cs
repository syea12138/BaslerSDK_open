using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basler.Pylon;
using System.Drawing.Imaging;

namespace BaslerSDK
{

    public partial class Form1 : Form
    {
        baslerCamcs camera = new baslerCamcs();
        public Form1()
        {
            InitializeComponent();
            camera.CameraImageEvent += Camera_CameraImageEvent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Camera_CameraImageEvent(Bitmap bmp)
        {
            pictureBox1.Invoke(new MethodInvoker(delegate
            {
            Bitmap old = pictureBox1.Image as Bitmap;
            pictureBox1.Image = bmp;
            if (old != null)
                old.Dispose();
            }));
        }
        void Unanble()
        {
            button_stop.Enabled = false;
            button_Oneshot.Enabled = false;
            button_keepShot.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (camera.CameraNumber > 0)
                camera.CameraInit();
            else
            {
                MessageBox.Show("未连接到相机");
                Unanble();
            }

        }
        private void button_stop_Click(object sender, EventArgs e)
        {
            camera.Stop();
        }

        private void button_Oneshot_Click(object sender, EventArgs e)
        {
            camera.OneShot();
        }

        private void button_keepShot_Click(object sender, EventArgs e)
        {
            camera.KeepShot();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            camera.DestroyCamera();
        }


    }




}
