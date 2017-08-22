using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace JSONProject
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }



        private void deserialiseJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(strJson);
                txtOutput.Text = jsonObject.ToString();
            }
            catch(Exception ex)
            {
                txtOutput.Text = "Error: " + ex.Message.ToString();
            }
        }



        #region EventHandler
        private void cmdGetUrl_Click(object sender, EventArgs e)
        {
            String url = txtUrl.Text;
            RestClient rClient = new RestClient();
            rClient.endPiont = url;
            txtInputJson.Text = rClient.getWebContent();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = String.Empty;
        }

        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            deserialiseJson(txtInputJson.Text);
        }

        #endregion



    }
}
