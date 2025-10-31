using OtomatYonetimSistemi.Entities;

namespace OtomatYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Machines> machines = new List<Machines>
            {
                new Machines { Name = "Otomat 1", Location = "Kat 1" },
                new Machines { Name = "Otomat 2", Location = "Kat 2" },
                new Machines { Name = "Otomat 3", Location = "Kat 3" }               
            };

            MessageBox.Show("Ugur Sahin'in yaptıgı degisiklik");
            string[] urunListesi = new string[5];
        }
    }
}
