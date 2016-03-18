using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WindowsFormsApplication3.Models;
using WindowsFormsApplication3.ViewModels;
using System.Linq.Expressions;
using System.Configuration;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static String clientBase = ConfigurationManager.AppSettings["clientBase"];
        private async void button1_Click(object sender, EventArgs e)
        {
           await Task.WhenAll(complete());

        }
        private async Task complete()
        {
            Dwstg d = new Dwstg();

            await d.PORTs.Where(o => o.LATITUDE == null).Take(500).ForEachAsync(async o => {
                await test(o.PORT_NAME, o);
            });
        }
        private async Task test(String location,PORT p)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(clientBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(clientBase+"/api/geo/geocoding/query/" + location);

                if (response.IsSuccessStatusCode)
                {
                    var jsonAsString = await response.Content.ReadAsStringAsync();
                    var g = JsonConvert.DeserializeObject<wrapper>(jsonAsString);
                    Console.WriteLine("{0}\t${1}\t{2}", g.data.day, g.data.displayName, g.data.lat);
                    listBox2.Items.Add(g.data.displayName);
                    listBox1.Items.Add(location);
                    Dwstg d = new Dwstg();
                   var w= d.PORTs.FirstOrDefault(o => o.PORT_NAME == location);
                    w.TZONE_OFFSET = g.data.rawOffset / 60 / 60/1000;
                    w.LATITUDE = g.data.lat;
                    w.LONGITUDE = g.data.lng;
                    w.LAST_MODIFIED_DT = DateTime.Now;
                    await d.SaveChangesAsync();
                }
            }
        }
        
        public class wrapper
        {
            public GeoDateWrapper data { get; set; }
        }
    }
}
