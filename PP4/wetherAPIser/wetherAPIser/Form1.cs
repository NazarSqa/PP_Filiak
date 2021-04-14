using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace wetherAPIser
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*1*/
            string URL_Sity = "http://" + "api.openweathermap.org/data/2.5/weather?q=" + City.Text + "&&units=metric&&appid=74415db07be3b557da5ee20fbbd395ae";
            string url = URL_Sity;


            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            
            WatherRespon watherResp = JsonConvert.DeserializeObject<WatherRespon>(response);


            if (watherResp.Main.Temp >= 20)
            {
                this.BackgroundImage = Properties.Resources.Son;
                this.Size = new Size(602,604);
                wInfo.ForeColor = Color.Navy;

            }
            else { 
                this.BackgroundImage = Properties.Resources.Rain;
                this.Size = new Size(560,315);
                wInfo.ForeColor = Color.White;
            }


            /*2*/wInfo.Text = "Temperature in" +" "+watherResp.Main.Temp + "°C" + "\n"+ watherResp.Name;
        }
    }
}
