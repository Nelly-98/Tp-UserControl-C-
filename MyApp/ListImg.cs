using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class ListImg : UserControl
    {
        public ListImg()
        {
            InitializeComponent();
        }

        private static ListImg _instance;
        public static ListImg Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListImg();
                return _instance;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ViewImage.Instance))
            {
                panel1.Controls.Add(ViewImage.Instance);
                ViewImage.Instance.Dock = DockStyle.Fill;
                ViewImage.Instance.BringToFront();
            }
            else
                ViewImage.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ViewImage.Instance))
            {
                panel1.Controls.Add(ViewImage.Instance);
                ViewImage.Instance.Dock = DockStyle.Fill;
                ViewImage.Instance.BringToFront();
            }
            else
                ViewImage.Instance.BringToFront();
        }
    }
}
