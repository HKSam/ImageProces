using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using face;

namespace ImageProcessingSystem
{
    class face_test
    {
        public static string Api_Key = "你的Api_Key";
        public static string Secret_Key = "你的Secret_Key";
        
        /// 脸部比对
        
        public static facemodel FaceDetect(String img)
        {
            var client = new Baidu.Aip.Face.Face(Api_Key, Secret_Key);
            var image = File.ReadAllBytes(img);
            var options = new Dictionary<string, object>()
            {
                { "face_fields", "age,expression,gender,race"}
            };
            string result = client.FaceDetect(image, options).ToString();

            //解析json数据
            return json_test(result.ToString());
        }

        
        // 解析json数据
       
        public static facemodel json_test(string json)
        {
            //得到根节点
            JObject jo_result = (JObject)JsonConvert.DeserializeObject(json.ToString());
            //得到result节点
            JArray jo_age = (JArray)JsonConvert.DeserializeObject(jo_result["result"].ToString());
            //查找某个字段与值
            facemodel facem = new facemodel();
            foreach (var val in jo_age)
            {
                facem.age = ((JObject)val)["age"].ToString();
                facem.expression = ((JObject)val)["expression"].ToString();
                facem.gender = ((JObject)val)["gender"].ToString();
                facem.race = ((JObject)val)["race"].ToString();
            }

            return facem;
        }

    }
}
