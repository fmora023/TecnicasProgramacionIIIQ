using Controller;

namespace ProyectoClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var people = PersonController.GetPeople();

            lbl_Name.Text = people[0].Name;
            lbl_Birth.Text = people[0].Birthday.ToString();
        }
    }
}
