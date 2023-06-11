using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ABBRWS
{
    public partial class Form1 : Form
    {

        private System.Timers.Timer timer1 = new System.Timers.Timer();



        private CookieContainer _cookies = new CookieContainer();

        private int J1=0, J2=0, J3=0, J4=0, J5=0, J6=0, speedRate=1000;


        public Form1()
        {
            this.timer1.Elapsed += timer1_Tick;
           
            InitializeComponent();
        }


        private void LocalRegist_Click(object sender, EventArgs e)
        {

            string url = $"http://"+robotIp.Text+"/users";
            string body = "username=xyz&application=RobotStudio&location=IN-BLR-XXXX&ulocale=local";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Credentials = new NetworkCredential("Default User", "robotics");
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = _cookies;
            Stream s = request.GetRequestStream();
            s.Write(Encoding.ASCII.GetBytes(body), 0, body.Length);//向数据流中写入body 内容
            s.Close();
            using (var a = (HttpWebResponse)request.GetResponse())
            {
                if (a.StatusCode == HttpStatusCode.Created)
                {
           
                    LocalRegist.BackColor = Color.Green;
                }

            }

        }

        private void mShipGet_Click(object sender, EventArgs e)
        {
            string url = $"http://" + robotIp.Text + "/rw/mastership/motion?action=request";//请求权限URL
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Credentials = new NetworkCredential("Default User", "robotics");
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = _cookies;
            Stream s = request.GetRequestStream();
            s.Close();
            using (var httpResponse = (HttpWebResponse)request.GetResponse())
                if (httpResponse.StatusCode == HttpStatusCode.NoContent)
                {
                 
                    mShipGet.BackColor = Color.Green;
                }

        }

        private void jogAxisModeSet_Click(object sender, EventArgs e)
        {
            string url = $"http://"+robotIp.Text+"/rw/motionsystem/mechunits/ROB_1?action=set&continue-on-en=1";
            string body = "jog-mode=AxisGroup1";
            //运动模式为单轴运动
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.Credentials = new NetworkCredential("Default User", "robotics");
            request.CookieContainer = _cookies;
            request.ContentType = "application/x-www-form-urlencoded";
            Stream s = request.GetRequestStream();
            s.Write(Encoding.ASCII.GetBytes(body), 0, body.Length);//向数据流中写入body 内容
            s.Close();
            using (var httpResponse = (HttpWebResponse)request.GetResponse())
            {
                if (httpResponse.StatusCode == HttpStatusCode.NoContent)
                {
                   
                   jogAxisModeSet.BackColor = Color.Green;
             
                }
            }
        }

        private int getCCount()
        {
            string url = $"http://" + robotIp.Text + "/rw/motionsystem?resource=change-count&json=1";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Credentials = new NetworkCredential("Default User", "robotics");
            request.CookieContainer = _cookies;
            request.Proxy = null;
            request.Timeout = 10000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response != null)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string content = reader.ReadToEnd();
                    dynamic res = JsonConvert.DeserializeObject(content);
                    var state = res._embedded._state[0];
                    if (state != null)
                    {
                        Console.WriteLine("state:" + state["change-count"]);
                        return Convert.ToInt32(state["change-count"]);//返回当前 CCount
                    }
                }
               
              
            }
        
            return -1;
        }


        private void timer1_Tick(object sender,ElapsedEventArgs e)
        {
            timer1.Stop();
            int ccount = getCCount();//获取当前CCount
            string body = "axis1=" + J1 * speedRate + "&axis2=" + J2 * speedRate + "&axis3=" + J3 * speedRate + "&axis4=" + J4 * speedRate + "&axis5=" + J5 * speedRate + "&axis6=" + J6 * speedRate + "&ccount=" + ccount + "";
            startAxisMove(body);
            timer1.Start();

        }




        public void PerformJogStop()
        {
            string url=$"http://" + robotIp.Text + "/rw/motionsystem?action=jog";
            int ccount = getCCount();
            string body = "axis1=0&axis2=0&axis3=0&axis4=0&axis5=0&axis6=0&ccount=" + ccount + "";
            HttpWebRequest request=(HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Credentials = new NetworkCredential("Default User", "robotics");
            request.CookieContainer=_cookies;
            request.ContentType ="application/x-www-form-urlencoded";
            Stream s = request.GetRequestStream();
            s.Write(Encoding.ASCII.GetBytes(body), 0, body.Length);
            s.Close();
            using (var httpResponse = (HttpWebResponse)request.GetResponse())
            {
            }
        }

        //1轴+长按鼠标
        private void jogOneAdd_MouseDown(object sender, MouseEventArgs e)
        {
            J1 = 1;
            btn_MouseDown();
        }
        //1轴+松开鼠标
        private void jogOneAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }

        //1轴-长按鼠标
        private void jogOneMinus_MouseDown(object sender, MouseEventArgs e)
        {
            J1 = -1;
            btn_MouseDown();
        }
        //1轴-松开鼠标
        private void jogOneMinus_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }

        //2轴+长按鼠标
        private void axisTwoAdd_MouseDown(object sender, MouseEventArgs e)
        {
            J2 = 1;
            btn_MouseDown();

        }
        //2轴+松开鼠标
        private void axisTwoAdd_MouseUp(object sender, MouseEventArgs e)
        {
           btn_MouseUp();
        }
        //2轴-长按鼠标
        private void axisTwoMinus_MouseDown(object sender, MouseEventArgs e)
        {
            J2 = -1;
            btn_MouseDown();
        }
        //2轴-松开鼠标
        private void axisTwoMinus_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }

        //3轴+长按鼠标
        private void axisThreeAdd_MouseDown(object sender, MouseEventArgs e)
        {
            J3 = 1;
            btn_MouseDown();
        }
        //3轴+松开鼠标
        private void axisThreeAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }

        //3轴-长按鼠标
        private void axisThreeMinus_MouseDown(object sender, MouseEventArgs e)
        {
            J3 = -1;
            btn_MouseDown();
        }
        //3轴-松开鼠标
        private void axisThreeMinus_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }

        //4轴+长按鼠标
        private void axisFourAdd_MouseDown(object sender, MouseEventArgs e)
        {
            J4 = 1;
            btn_MouseDown();
        }
        //4轴+松开鼠标
        private void axisFourAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }
        //4轴-长按鼠标
        private void axisFourMinus_MouseDown(object sender, MouseEventArgs e)
        {
            J4 = -1;
            btn_MouseDown();
        }
        //4轴-松开鼠标
        private void axisFourMinus_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }
        //5轴+长按鼠标
        private void axisFiveAdd_MouseDown(object sender, MouseEventArgs e)
        {
            J5 = 1;
            btn_MouseDown();
        }
        //5轴+松开鼠标
        private void axisFiveAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }
        //5轴-长按鼠标
        private void axisFiveMinus_MouseDown(object sender, MouseEventArgs e)
        {
            J5 = -1;
            btn_MouseDown();

        }
        //5轴-松开鼠标
        private void axisFiveMinus_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }
        //6轴+长按鼠标
        private void axisSixAdd_MouseDown(object sender, MouseEventArgs e)
        {
            J6 = 1;
            btn_MouseDown();
        }
        //6轴+松开鼠标
        private void axisSixAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }
        //6轴-长按鼠标
        private void axisSixMinus_MouseDown(object sender, MouseEventArgs e)
        {
            J6 = -1;
            btn_MouseDown();
        }
        //6轴-松开鼠标
        private void axisSixMinus_MouseUp(object sender, MouseEventArgs e)
        {
            btn_MouseUp();
        }


        //轴关节运动
        public void startAxisMove(string body)
        {
 
                string url = $"http://" + robotIp.Text + "/rw/motionsystem?action=jog";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.Credentials = new NetworkCredential("Default User", "robotics");
                request.CookieContainer = _cookies;
                request.ContentType = "application/x-www-form-urlencoded";
                Stream s = request.GetRequestStream();
                s.Write(Encoding.ASCII.GetBytes(body), 0, body.Length);
                s.Close();
                using (var httpResponse = (HttpWebResponse)request.GetResponse())
                {
                }
           
        
        }

        //获取机器人轴坐标
        private void getAxisValue_Click(object sender, EventArgs e)
        {
            string url = "http://" + robotIp.Text + "/rw/motionsystem/mechunits/ROB_1/jointtarget?json=1";
            string username = "Default User";
            string password = "robotics";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Credentials = new NetworkCredential(username, password);
            request.CookieContainer = _cookies;
            request.PreAuthenticate = true;
            request.Proxy = null;
            request.Timeout = 60;
            request.ServicePoint.Expect100Continue = false;
            WebResponse response = request.GetResponse();
            if (response != null)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    dynamic obj = JsonConvert.DeserializeObject(result);
                    var service = obj._embedded._state[0];
                    axisOneValue.Text = service.rax_1;
                    axisTwoValue.Text = service.rax_2;
                    axisThreeValue.Text = service.rax_3;
                    axisFourValue.Text = service.rax_4;
                    axisFiveValue.Text = service.rax_5;
                    axisSixValue.Text = service.rax_6;

                }
            }
        }

     

        private void speedRatio_Click(object sender, EventArgs e)
        {
            string url = "http://" + robotIp.Text + "/rw/panel/speedratio?json=1";
            string username = "Default User";
            string password = "robotics";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Credentials = new NetworkCredential(username, password);
            request.CookieContainer = _cookies;
            request.PreAuthenticate = true;
            request.Proxy = null;
            request.Timeout = 60;
            request.ServicePoint.Expect100Continue = false;
            WebResponse response = request.GetResponse();
            if (response != null)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    dynamic obj = JsonConvert.DeserializeObject(result);
                    var service = obj._embedded._state[0];
                   speedRatioValue.Text=service.speedratio;

                }
            }
        }

        private void opMode_Click(object sender, EventArgs e)
        {
            string url = "http://" + robotIp.Text + "/rw/panel/opmode?json=1";
            string username = "Default User";
            string password = "robotics";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Credentials = new NetworkCredential(username, password);
            request.CookieContainer = _cookies;
            request.PreAuthenticate = true;
            request.Proxy = null;
            request.Timeout = 60;
            request.ServicePoint.Expect100Continue = false;
            WebResponse response = request.GetResponse();
            if (response != null)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    dynamic obj = JsonConvert.DeserializeObject(result);
                    var service = obj._embedded._state[0];
                    opModeValue.Text=service.opmode;

                }
            }
        }

        private void motorStatus_Click(object sender, EventArgs e)
        {
            string url = "http://" + robotIp.Text + "/rw/panel/ctrlstate?json=1";
            string username = "Default User";
            string password = "robotics";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Credentials = new NetworkCredential(username, password);
            request.CookieContainer = _cookies;
            request.PreAuthenticate = true;
            request.Proxy = null;
            request.Timeout = 60;
            request.ServicePoint.Expect100Continue = false;
            WebResponse response = request.GetResponse();
            if (response != null)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    dynamic obj = JsonConvert.DeserializeObject(result);
                    var service = obj._embedded._state[0];
                    motorStatusValue.Text=service.ctrlstate;

                }
            }
        }

        private void btn_MouseDown()
        {
            this.timer1.Interval = 200;
            this.timer1.Enabled = true;
        }

        private void btn_MouseUp()
        {
            J1 = 0;
            J2 = 0;
            J3 = 0;
            J4 = 0;
            J5 = 0;
            J6 = 0;
            this.timer1.Stop();
            this.PerformJogStop();
        }

    }
}
