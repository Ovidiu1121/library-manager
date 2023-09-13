using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema89_LibraryManager.book.model;
using Tema89_LibraryManager.book.service;
using Tema89_LibraryManager.exceptions;
using Tema89_LibraryManager.models;
using Tema89_LibraryManager.user.service;

namespace Tema89_LibraryManager.view
{
    public class PnlLogIn:Panel
    {
        private Label lbltitlu;
        private Label lblname;
        private Label lblpassword;
        private TextBox txtpassword;
        private TextBox txtname;
        private Button btnlogin;
        private IUserService userservice;
        public FrmHome frmHome;

        public PnlLogIn(FrmHome frmHome)
        {
            this.frmHome = frmHome;
            this.Size = new System.Drawing.Size(818, 497);
            this.userservice=UserServiceSingleton.Instance;

            this.lbltitlu = new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location = new System.Drawing.Point(321, 40);
            this.lbltitlu.Size = new System.Drawing.Size(130, 46);
            this.lbltitlu.Text="Log In";
            this.lbltitlu.Font=new Font("Arial", 24, FontStyle.Regular);

            this.lblname = new Label();
            this.Controls.Add(this.lblname);
            this.lblname.Location = new System.Drawing.Point(156, 155);
            this.lblname.Size=new Size(64, 25);
            this.lblname.Text="Nume";
            this.lblname.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblpassword = new Label();
            this.Controls.Add(this.lblpassword);
            this.lblpassword.Location = new System.Drawing.Point(156, 206);
            this.lblpassword.Size=new Size(64, 25);
            this.lblpassword.Text="Parola";
            this.lblpassword.Font=new Font("Arial", 12, FontStyle.Regular);

            this.txtname=new TextBox();
            this.Controls.Add(this.txtname);
            this.txtname.Location=new Point(246, 158);
            this.txtname.Size=new Size(334, 22);

            this.txtpassword=new TextBox();
            this.Controls.Add(this.txtpassword);
            this.txtpassword.Location=new Point(246, 206);
            this.txtpassword.Size=new Size(334, 22);

            this.btnlogin=new Button();
            this.Controls.Add(this.btnlogin);
            this.btnlogin.Location=new Point(246, 257);
            this.btnlogin.Size=new Size(106, 43);
            this.btnlogin.Text="Logare";
            this.btnlogin.Click+=new EventHandler(login_Click);

        }

        public void login_Click(object sender,EventArgs e)
        {
            if (this.txtname.Text.Equals("")||this.txtpassword.Text.Equals(""))
            {
                MessageBox.Show("Camp necompletat");
            }
            else
            {
                try
                {
                    User user = this.userservice.getUserByNumeParola(this.txtname.Text, this.txtpassword.Text);

                    if (this.userservice.isUser(user))
                    {
                        this.frmHome.Controls.Remove(this.frmHome.activepanel);
                        this.frmHome.activepanel=new PnlAddBook();
                        this.frmHome.Controls.Add(this.frmHome.activepanel);
                    }
                }
                catch (UserInexistentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
