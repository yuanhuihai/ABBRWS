using System;
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
        private System.Timers.Timer timer2 = new System.Timers.Timer();
        private System.Timers.Timer timer3 = new System.Timers.Timer();
        private System.Timers.Timer timer4 = new System.Timers.Timer();
        private System.Timers.Timer timer5 = new System.Timers.Timer();
        private System.Timers.Timer timer6 = new System.Timers.Timer();
        private System.Timers.Timer timer7 = new System.Timers.Timer();
        private System.Timers.Timer timer8 = new System.Timers.Timer();
        private System.Timers.Timer timer9 = new System.Timers.Timer();
        private System.Timers.Timer timer10 = new System.Timers.Timer();
        private System.Timers.Timer timer11 = new System.Timers.Timer();
        private System.Timers.Timer timer12 = new System.Timers.Timer();


        private CookieContainer _cookies = new CookieContainer();

        public Form1()
        {
            this.timer1.Elapsed += timer1_Tick;
            this.timer2.Elapsed += timer2_Tick;
            this.timer3.Elapsed += timer3_Tick;
            this.timer4.Elapsed += timer4_Tick;
            this.timer5.Elapsed += timer5_Tick;
            this.timer6.Elapsed += timer6_Tick;
            this.timer7.Elapsed += timer7_Tick;
            this.timer8.Elapsed += timer8_Tick;
            this.timer9.Elapsed += timer9_Tick;
            this.timer10.Elapsed += timer10_Tick;
            this.timer11.Elapsed += timer11_Tick;
            this.timer12.Elapsed += timer12_Tick;
            InitializeComponent();
        }


        private void LocalRegist_Click(object sender, EventArgs e)
        {

            string url = $"http://127.0.0.1/users";
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
                    Console.WriteLine("Created");
                }

            }

        }

        private void mShipGet_Click(object sender, EventArgs e)
        {
            string url = $"http://127.0.0.1/rw/mastership/motion?action=request";//请求权限URL
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
                    Console.WriteLine("Motion response:NO_CONTENT");
                }

        }

        private void jogAxisModeSet_Click(object sender, EventArgs e)
        {
            string url = $"http://127.0.0.1/rw/motionsystem/mechunits/ROB_1?action=set&continue-on-err=1";
            string body = "jog-mode=AxisGroup1"; //运动模式为单轴运动 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Credentials = new NetworkCredential("Default User", "tobotics");
            request.CookieContainer = _cookies;
            request.ContentType = "application / x - www - form - uriencoded";
            Stream s = request.GetRequestStream();
            s.Write(Encoding.ASCII.GetBytes(body), 0, body.Length);
            s.Close();
            using (var httpResponse = (HttpWebResponse)request.GetResponse())
            {
                if (httpResponse.StatusCode == HttpStatusCode.NoContent)
                {
                    Console.Write("Jog Mode Set Response:NO_CONTENT");
                }
            }
        }

        private int getCCount()
        {
            string url = $"http://127.0.0.1/rw/motionsystem?resource=change-count&json=1";
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

        //1轴
        private void timer1_Tick(object sender,ElapsedEventArgs e)
        {
            timer1.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=1000&axis2=0&axis3=0&axis4=0&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例1轴正向运动，速度矢量为1000
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "POST";
            request.Credentials = new NetworkCredential("Default User", "robotics");
            request.CookieContainer = _cookies;
            request.ContentType = "application/x-www-form-urlencoded";
            Stream s = request.GetRequestStream();
            s.Write(Encoding.ASCII.GetBytes(body),0, body.Length);
            s.Close();
            using (var httpResponse = (HttpWebResponse)request.GetResponse())
            {
            }
            timer1.Start();


        }
        private void timer2_Tick(object sender, ElapsedEventArgs e)
        {
            timer2.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=-1000&axis2=0&axis3=0&axis4=0&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例1轴负向运动，速度矢量为-1000
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
            timer2.Start();


        }

        //2轴
        private void timer3_Tick(object sender, ElapsedEventArgs e)
        {
            timer3.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=1000&axis3=0&axis4=0&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例2轴正向运动，速度矢量为1000
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
            timer3.Start();


        }
        private void timer4_Tick(object sender, ElapsedEventArgs e)
        {
            timer4.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=-1000&axis3=0&axis4=0&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例1轴负向运动，速度矢量为-1000
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
            timer4.Start();


        }

        //3轴
        private void timer5_Tick(object sender, ElapsedEventArgs e)
        {
            timer5.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=1000&axis4=0&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例3轴正向运动，速度矢量为1000
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
            timer5.Start();


        }
        private void timer6_Tick(object sender, ElapsedEventArgs e)
        {
            timer6.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=-1000&axis4=0&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例3轴负向运动，速度矢量为-1000
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
            timer6.Start();


        }

        //4轴
        private void timer7_Tick(object sender, ElapsedEventArgs e)
        {
            timer7.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=0&axis4=1000&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例4轴正向运动，速度矢量为1000
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
            timer7.Start();


        }
        private void timer8_Tick(object sender, ElapsedEventArgs e)
        {
            timer8.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=0&axis4=-1000&axis5=0&axis6=0&ccount=" + ccount + "";//此处举例4轴负向运动，速度矢量为-1000
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
            timer8.Start();


        }

        //5轴
        private void timer9_Tick(object sender, ElapsedEventArgs e)
        {
            timer9.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=0&axis4=0&axis5=1000&axis6=0&ccount=" + ccount + "";//此处举例5轴正向运动，速度矢量为1000
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
            timer9.Start();


        }
        private void timer10_Tick(object sender, ElapsedEventArgs e)
        {
            timer10.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=0&axis4=0&axis5=-1000&axis6=0&ccount=" + ccount + "";//此处举例5轴负向运动，速度矢量为-1000
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
            timer10.Start();


        }

        //6轴
        private void timer11_Tick(object sender, ElapsedEventArgs e)
        {
            timer11.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=0&axis4=0&axis5=0&axis6=1000&ccount=" + ccount + "";//此处举例6轴正向运动，速度矢量为1000
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
            timer11.Start();


        }
        private void timer12_Tick(object sender, ElapsedEventArgs e)
        {
            timer12.Stop();
            int ccount = getCCount();//获取当前CCount
            string url = $"http://127.0.0.1/rw/motionsystem?action=jog";
            string body = "axis1=0&axis2=0&axis3=0&axis4=0&axis5=0&axis6=-1000&ccount=" + ccount + "";//此处举例6轴负向运动，速度矢量为-1000
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
            timer12.Start();


        }


        private void jogOneAdd_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer1.Interval = 200;
            this.timer1.Enabled = true;
        }

        private void jogOneAdd_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer1.Stop();
            this.PerformJogStop();
        }

        public void PerformJogStop()
        {
            string url=$"http://127.0.0.1/rw/motionsystem?action=jog";
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

        private void jogOneMinus_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer2.Interval = 200;
            this.timer2.Enabled = true;
        }

        private void jogOneMinus_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer2.Stop();
            this.PerformJogStop();
        }

        private void axisTwoAdd_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer3.Interval = 200;
            this.timer3.Enabled = true;
       
        }

        private void axisTwoAdd_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer3.Stop();
            this.PerformJogStop();
        }

        private void axisTwoMinus_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer4.Interval = 200;
            this.timer4.Enabled = true;
        }

        private void axisTwoMinus_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer4.Stop();
            this.PerformJogStop();
        }

        private void axisThreeAdd_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer5.Interval = 200;
            this.timer5.Enabled = true;
        }

        private void axisThreeAdd_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer5.Stop();
            this.PerformJogStop();
        }
    }
}
