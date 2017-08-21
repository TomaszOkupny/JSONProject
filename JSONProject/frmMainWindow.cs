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

namespace JSONProject
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = String.Empty;
        }


        private void deserialiseJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(strJson);
                txtOutput.Text = jsonObject.username;
            }
            catch(Exception ex)
            {
                txtOutput.Text = "Error: " + ex.Message.ToString();
            }
        }

        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            deserialiseJson(txtInputJson.Text);
        }
    }
}
