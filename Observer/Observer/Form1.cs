using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        private changestring cs;
        private observerF oform;
        public Form1()
        {
            InitializeComponent();
            oform = new observerF();
            cs = new changestring();
            
            cs.registrar(oform);
            oform.Show();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtobserver_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtobserver_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs.notificar(txtobserver.Text);
        }
    }
}
