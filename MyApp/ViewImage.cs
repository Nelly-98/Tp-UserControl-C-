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
    public partial class ViewImage : UserControl
    {
        public ViewImage()
        {
            InitializeComponent();
        }

        private static ViewImage _instance;
        public static ViewImage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewImage();
                return _instance;

            }
        }
    }
}
