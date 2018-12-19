using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using face;


namespace ImageProcessingSystem
{
    public partial class FaceCheck : Form
    {
        public FaceCheck()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

       
        FilterInfoCollection videoDevices;
     
        public int selectedDeviceIndex = 0;
        public int selectedPICIndex = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            //图片名称，年月日时分秒毫秒.jpg
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".jpg";

            //获取项目的根目录
            string path = AppDomain.CurrentDomain.BaseDirectory;

            //将图片保存在服务器里面
            bitmap.Save(path+"\\"+fileName, ImageFormat.Jpeg);
            //System.Drawing.Image img_s = new Bitmap(videoSourcePlayer1.Width, videoSourcePlayer1.Height);
            //videoSourcePlayer1.DrawToBitmap((Bitmap)img_s, new Rectangle(0, 0, videoSourcePlayer1.Width, videoSourcePlayer1.Height));
            //img_s.Save(@"E:\a.jpg", ImageFormat.Jpeg);
            bitmap.Dispose();

            //进行面部特征识别
            facemodel facem = face_test.FaceDetect(path + "\\" + fileName);
            
            this.lb_age_message.Text = facem.age;      //年龄
            //this.label5.Text = facem.beauty;  //漂亮度
            string expression = facem.expression;//表情
            if (expression.Equals("0"))
            {
                this.lb_face_message.Text = "不笑";
            }
            else if (expression.Equals("1"))
            {
                this.lb_face_message.Text = "微笑";
            }
            else if (expression.Equals("2"))
            {
                this.lb_face_message.Text = "大笑";
            }
            string gender = facem.gender;//性别
            if (gender.Equals("male"))
            {
                this.lb_sex_message.Text = "男";
            }
            else
            {
                this.lb_sex_message.Text = "女";
            }
           
            string race = facem.race;//人种
            if (race.Equals("yellow"))
            {
                this.lb_kind_message.Text = "黄人";
            }
            else if (race.Equals("white"))
            {
                this.lb_kind_message.Text = "白人";
            }
            else if (race.Equals("black"))
            {
                this.lb_kind_message.Text = "黑人";
            }
            else if (race.Equals("arabs"))
            {
                this.lb_kind_message.Text = "棕人";
            }
            
        }
        public void openCan()
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameras.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new Size(320, 240);
            videoSource.DesiredFrameRate = 1;

            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

        }

        private void FaceCheck_Load(object sender, EventArgs e)
        {
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    comboBoxCameras.Items.Add(device.Name);
                }

                comboBoxCameras.SelectedIndex = 0;
                
            }
            catch (ApplicationException)
            {
                comboBoxCameras.Items.Add("No local capture devices");
                videoDevices = null;
            }


            
        }

        private void close_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.Stop();
            this.Close();
            
        }

        private void btn_vd_Click(object sender, EventArgs e)
        {
            try
            {
                openCan();
            }
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Image img = new Bitmap(videoSourcePlayer1.Width, videoSourcePlayer1.Height);
                videoSourcePlayer1.DrawToBitmap((Bitmap)img, new Rectangle(0, 0, videoSourcePlayer1.Width, videoSourcePlayer1.Height));
                img.Save(@"E:\a.bmp", ImageFormat.Bmp);
            }
            catch { }
        }
    }
}
