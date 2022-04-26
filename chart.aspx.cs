using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace WebApplicationJson
{
    public partial class chart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string data = "";

            using (WebClient web1 = new WebClient())
            {
               data = web1.DownloadString("https://gist.githubusercontent.com/ChaiyachetU/eb18cb962af268f12825d7c8dc65d570/raw/caf1f611babb5bcd305b673ba47c086340dd0136/pea_material_data.json");
           
            }
        MyClass[] result = JsonConvert.DeserializeObject<MyClass[]>(data);

          int totalElements = result.Count();
            string createText = "";
            for (int i = 0; i < totalElements; i++)
            {
                string resultgolf = result[i].no + ":" +result[1].code  ;
                createText += resultgolf + Environment.NewLine;

            }

            string path = "c:/golf.txt";
            // Create a file to write to.
          
            File.WriteAllText(path, createText);

      

            // Open the file to read from.
            string readText = File.ReadAllText(path);

            Label1.Text = readText;

            DivPieChart();
        }

        public class MyClass
        {
            public string no { get; set; }
            public string code { get; set; }

        }



        public void DivPieChart()
        {


            try
            {




                String chart = "";
                // You can change your chart height by modify height value
                chart = "<canvas id=\"gauge\" width =\"100%\" height=\"40\"></canvas>";
                chart += "<script>";
                chart += "new Chart(document.getElementById(\"gauge\"), {type: 'bar'";
                chart += ", data:{  labels:[";
                chart += "'งบประมาณที่ตั้งไว้(ล้านบาท)','งบประมาณที่ใช้ไป(ล้านบาท)'";
                chart += "],datasets: [{ data: [";

                chart += "'500.25','500.25'";
                //   chart += value2;


                chart += "],";
                chart += "backgroundColor:['rgba(128, 0, 128, 0.8)','rgba(124, 252, 0, 0.8)','rgba(255, 0, 0, 0.8)','rgba(124, 252, 0, 0.2)','rgba(125, 125, 80, 0.2)','rgba(25, 79, 32, 0.2)','rgba(255, 99, 132, 0.2)','rgba(255, 149, 64, 0.2)', 'rgba(255, 205, 86, 0.2)','rgba(75, 192, 192, 0.2)','rgba(54, 162, 235, 0.2)','rgba(153, 102, 255, 0.2)','rgba(201, 203, 207, 0.2)'],";
                chart += "borderColor:[ 'rgb(128, 0, 128)','rgb(124, 252, 0)','rgb(255, 0, 0)','rgb(124, 252, 0)','rgb(125, 125, 80)','rgb(25, 79, 32)','rgb(255, 99, 132)','rgb(255, 149, 64)', 'rgb(255, 205, 86)','rgb(75, 192, 192)', 'rgb(54, 162, 235)', 'rgb(153, 102, 255)','rgb(201, 203, 207)'],";


                chart += "borderWidth: 1,";
                chart += "label: \"การใช้งบประมาณ(ล้านบาท)\",borderColor: \"#3e00cd\",fill: true}"; // Chart color

                // start

                /*
                    chart += ",{ data: [";
                //   chart += value1;

                chart += "'100','200'";
                chart += "],";
                    chart += "backgroundColor:['rgba(155, 99, 152, 0.2)','rgba(155, 199, 132, 0.2)','rgba(215, 99, 232, 0.2)','rgba(185, 129, 132, 0.2)','rgba(125, 125, 80, 0.2)','rgba(25, 79, 32, 0.2)','rgba(255, 99, 132, 0.2)','rgba(255, 149, 64, 0.2)', 'rgba(255, 205, 86, 0.2)','rgba(75, 192, 192, 0.2)','rgba(54, 162, 235, 0.2)','rgba(153, 102, 255, 0.2)','rgba(201, 203, 207, 0.2)'],";
                    chart += "borderColor:[ 'rgb(155, 99, 152)','rgb(155, 199, 132)','rgb(215, 99, 232)','rgb(180, 129, 132)','rgb(125, 125, 80)','rgb(25, 79, 32)','rgb(255, 99, 132)','rgb(255, 149, 64)', 'rgb(255, 205, 86)','rgb(75, 192, 192)', 'rgb(54, 162, 235)', 'rgb(153, 102, 255)','rgb(201, 203, 207)'],";
                    chart += "borderWidth: 1,";
                    chart += "label: \"ค่าใช้จ่ายตามเกณฑ์(ล้านบาท)\",borderColor: \"#3e95cd\",fill: true}"; // Chart color
                    //   chart += "]},options: { title: { display: true,text: 'Dashboard'}}"; // Chart title
                  
                */
                chart += "]"; // Chart title


                // end
                chart += "}"; // Chart title
                chart += "});";
                chart += "</script>";

                ltChart.Text = chart;







            }
            catch (Exception ex)
            {
                string golf = ex.Message;
            }
        }





    }
}