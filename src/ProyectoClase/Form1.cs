using Controller;

namespace ProyectoClase
{
    public partial class Form1 : Form
    {
        private readonly PersonController controller;
        private readonly string Country = nameof(Country);
        private readonly string LastName = "Last Name";
        private readonly string NameColumn = "Name";

        public Form1()
        {
            InitializeComponent();

            this.controller = new PersonController();
            var people = controller.GetPeople();

            this.listView1.Columns.Add(Text = NameColumn, Width = 100);
            this.listView1.Columns.Add(Text = LastName, Width = 100);
            this.listView1.Columns.Add(Text = Country, Width = 100);
            this.listView1.Items.AddRange(people.Select(p => new ListViewItem([p.Name, p.LastName, p.Country])).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataStr = $"{this.NameColumn},{this.LastName},{this.Country},{Environment.NewLine}";
            this.controller.UpdateItems(dataStr);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            var messageBox = MessageBox.Show("Desea abrir la nueva ventana", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messageBox == DialogResult.Yes)
            {
                var newForm = new Form2();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("No se va a hacer nada");
            }
        }
    }
}
