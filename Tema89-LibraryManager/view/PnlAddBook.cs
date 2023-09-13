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
using Tema89_LibraryManager.utils;

namespace Tema89_LibraryManager.view
{
    public class PnlAddBook:Panel
    {
        private Label lbltitle;
        private Label lblauthor;
        private Label lblgenre;
        private TextBox txttitle;
        private TextBox txtgenre;
        private TextBox txtauthor;
        private Button btnadd;
        private Label lblheadertitle;
        private IBookService bookservice;


        public PnlAddBook()
        {

            this.bookservice =BookServiceSingleton.Instance;
            this.Size = new System.Drawing.Size(818, 497);

            this.lblheadertitle = new Label();
            this.Controls.Add(this.lblheadertitle);
            this.lblheadertitle.Location = new System.Drawing.Point(322, 36);
            this.lblheadertitle.Size = new System.Drawing.Size(118, 29);
            this.lblheadertitle.Text="Add Book";
            this.lblheadertitle.Font=new Font("Arial", 14, FontStyle.Regular);

            this.lbltitle = new Label();
            this.Controls.Add(this.lbltitle);
            this.lbltitle.Location = new System.Drawing.Point(187, 123);
            this.lbltitle.Size=new Size(49, 25);
            this.lbltitle.Text="Title";
            this.lbltitle.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblauthor = new Label();
            this.Controls.Add(this.lblauthor);
            this.lblauthor.Location = new System.Drawing.Point(187, 177);
            this.lblauthor.Size=new Size(70, 25);
            this.lblauthor.Text="Author";
            this.lblauthor.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblgenre = new Label();
            this.Controls.Add(this.lblgenre);
            this.lblgenre.Location = new System.Drawing.Point(187, 232);
            this.lblgenre.Size=new Size(66, 25);
            this.lblgenre.Text="Genre";
            this.lblgenre.Font=new Font("Arial", 12, FontStyle.Regular);

            this.txttitle=new TextBox();
            this.Controls.Add(this.txttitle);
            this.txttitle.Location=new Point(288, 126);
            this.txttitle.Size=new Size(285, 22);

            this.txtauthor=new TextBox();
            this.Controls.Add(this.txtauthor);
            this.txtauthor.Location=new Point(288, 180);
            this.txtauthor.Size=new Size(285, 22);

            this.txtgenre=new TextBox();
            this.Controls.Add(this.txtgenre);
            this.txtgenre.Location=new Point(288, 235);
            this.txtgenre.Size=new Size(285, 22);

            this.btnadd=new Button();
            this.Controls.Add(this.btnadd);
            this.btnadd.Location=new Point(288, 288);
            this.btnadd.Size=new Size(118, 37);
            this.btnadd.Text="Add";
            this.btnadd.Click+=new EventHandler(addBook_Click);
            

        }

        public void addBook_Click(object sender,EventArgs e)
        {
            if (this.txtauthor.Text.Equals("")||this.txttitle.Text.Equals("")||this.txtgenre.Text.Equals(""))
            {
                MessageBox.Show("Camp necompletat");
            }
            else
            {
                try
                {
                    Book book = new Book(this.txttitle.Text, this.txtauthor.Text, this.txtgenre.Text);

                    this.bookservice.addBook(book);

                    MessageBox.Show("Cartea a fost adaugata");
                }
                catch (CarteExistentaException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


    }
}
