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
    public partial class main : System.Web.UI.Page
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


        }

        public class MyClass
        {
            public string no { get; set; }
            public string code { get; set; }

        }


    }
}