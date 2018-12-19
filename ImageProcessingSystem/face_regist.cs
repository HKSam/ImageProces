using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace ImageProcessingSystem
{
    public partial class face_regist : Form
    {
        public face_regist()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }
        public static string Api_Key = "OVYw5Ok0y9U8n6CfVPYt0wfZ";
        //Secret_Key
        public static string Secret_Key = "aCN3lupCarq3rC9G8Rylqz1d36Towp8G";
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        public int selectedDeviceIndex = 0;
        public int selectedPICIndex = 0;
        private FilterInfoCollection vDevices;
        private void face_regist_Load(object sender, EventArgs e)
        {
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    cb_index.Items.Add(device.Name);
                }

                cb_index.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                cb_index.Items.Add("No local capture devices");
                videoDevices = null;
            }


            //打开摄像头
            openCamera();
           
        }
        //打开摄像头
        public void openCamera()
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(vDevices[cb_index.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new Size(320, 240);
            videoSource.DesiredFrameRate = 1;

            cb_Cameras.VideoSource = videoSource;
            cb_Cameras.Start();
        }

        private void regist_Click(object sender, EventArgs e)
        {
        //    Users user = new Users();
        //    user.name = this.name.Text;
        //    user.id = DateTime.Now.Ticks / 10000;
        //    user.password = this.password.Text;
        //    user.phone = this.phone.Text;
        //    user.age = (int)this.age.Value;
        //    user.address = this.address.Text;
        //    user.picture = SavePicture();
        //    //注册人脸通过的话进去
        //    if (FaceRegister(user))
        //    {
        //        int rel = AddUsers(user);//添加信息
        //        if (rel > 0)
        //        {
        //            MessageBox.Show("注册成功", "提示信息");
        //        }
        //        else
        //        {
        //            MessageBox.Show("添加失败", "提示信息");
        //        }
        //    }
        //    string SavePicture()
        //    {
        //        if (videoSource == null)
        //        {
        //            return null;
        //        }

        //        Bitmap bitmap = cb_Cameras.GetCurrentVideoFrame();
        //        //图片名称，年月日时分秒毫秒.jpg
        //        string fileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".jpg";

        //        //获取项目的根目录
        //        string path = AppDomain.CurrentDomain.BaseDirectory;
        //        string picture = path + "\\picture\\" + fileName;
        //        //将图片保存在服务器里面
        //        bitmap.Save(picture, ImageFormat.Jpeg);
        //        bitmap.Dispose();
        //        return picture;
            //}

         
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_Cameras.Stop();
            this.Close();
        }
        //public int AddUsers(Users users)
        //{
        //    int rel = 0;
        //    string sql = "insert INTO Users VALUES(@id,@name,@age,@phone,@password,@address,@picture)";
        //    SqlParameter[] param = {
        //                                new SqlParameter("@id",users.id),
        //                                new SqlParameter("@name",users.name),
        //                                new SqlParameter("@age",users.age),
        //                                new SqlParameter("@phone",users.phone),
        //                                new SqlParameter("@password",users.password),
        //                                new SqlParameter("@address",users.address),
        //                                new SqlParameter("@picture",users.picture)

        //                           };
        //    rel = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, param);
        //    return rel;
        //}
        //public static bool FaceRegister(Users user)
        //{
        //    var client = new Baidu.Aip.Face.Face(Api_Key, Secret_Key);
        //    //当前毫秒数可能是负数，取绝对值
        //    var image1 = File.ReadAllBytes(user.picture);

        //    var result = client.User.Register(image1, user.id.ToString(), user.name, new[] { "gr_test" });
        //    //得到根节点
        //    JObject jo_result = (JObject)JsonConvert.DeserializeObject(result.ToString());
        //    if ((string)jo_result["error_msg"] != null)
        //    {
        //        MessageBox.Show("对不起，请把脸放上！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //        return false;
        //    }

        //    return true;
        //}

    }
}
