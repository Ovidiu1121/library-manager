using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema89_LibraryManager.view;

namespace Tema89_LibraryManager
{
    public partial class FrmHome : Form
    {
        public Panel activepanel;

        public FrmHome()
        {
            InitializeComponent();

            activepanel = new PnlLogIn(this);
            this.Controls.Add(activepanel);

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
