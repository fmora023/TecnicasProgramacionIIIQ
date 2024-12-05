using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClase
{
    /// <summary>
    /// Login Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form2 : Form
    {
        /// <summary>
        /// Gets or sets the people.
        /// </summary>
        /// <value>
        /// The people.
        /// </value>
        public List<Person> People { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form2"/> class.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var user = this.txt_User.Text;
            var pass = this.txt_Pass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor digite la informacion");
                this.txt_Pass.Text = string.Empty;
                this.txt_User.Text = string.Empty;
                return;
            }

            foreach (var item in this.People)
            {
                if (user == $"{ item.Name } {item.LastName}" && pass == item.Country)
                {
                    MessageBox.Show("Login Success");
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Login Failed");
            this.txt_Pass.Text = string.Empty;
            this.txt_User.Text = string.Empty;
        }
    }
}
