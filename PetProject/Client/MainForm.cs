using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Newtonsoft.Json;

namespace Client
{
    public partial class MainForm : Form
    {

 
        public MainForm()
        {
            InitializeComponent();
            LoadPets();
        }

        private void LoadPets()
        {
            using (WebClient client = new WebClient())
            {
                var token = "cdb9ceef-fda8-466b-a3c7-a70bec498dd7";
                if (string.IsNullOrWhiteSpace(token))
                {
                    MessageBox.Show("Please enter a valid token.");
                    return;
                }

                client.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");

                try
                {
                    string response = client.DownloadString("http://localhost:44388/api/pets");
                    List<PetDTO> pets = JsonConvert.DeserializeObject<List<PetDTO>>(response);
                    dataGridView1.DataSource = pets;
                }
                catch (WebException ex)
                {
                    if (ex.Response != null)
                    {
                        using (var response = ex.Response)
                        {
                            var httpResponse = (HttpWebResponse)response;
                            MessageBox.Show("Error: " + httpResponse.StatusDescription);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
