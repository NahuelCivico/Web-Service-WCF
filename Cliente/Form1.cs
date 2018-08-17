using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cod = Int32.Parse(txtCod.Text);

            using (WSPersona.WSPersonaClient client = new WSPersona.WSPersonaClient())
            {
                var persona = client.GetPersona(cod);
            }
        }
    }
}
