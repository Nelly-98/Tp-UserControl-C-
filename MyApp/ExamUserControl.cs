using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MyApp
{
    public partial class ExamUserControl : Form
    {
        public ExamUserControl()
        {
            InitializeComponent();
        }

        private void commenterImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ImageCommentee.Instance))
            {
                panel.Controls.Add(ImageCommentee.Instance);
                ImageCommentee.Instance.Dock = DockStyle.Fill;
                ImageCommentee.Instance.BringToFront();
            }
            else
                ImageCommentee.Instance.BringToFront();

        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void affichageImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ListImg.Instance))
            {
                panel.Controls.Add(ListImg.Instance);
                ListImg.Instance.Dock = DockStyle.Fill;
                ListImg.Instance.BringToFront();
            }
            else
                ListImg.Instance.BringToFront();
        }

        private void ExamUserControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
