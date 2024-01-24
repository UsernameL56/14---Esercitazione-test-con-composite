using Classi;
namespace _14___Esercitazione_test_con_composite
{
    public partial class Form1 : Form
    {
        Test test;
        public Form1()
        {
            InitializeComponent();
            test = new Test(new List<Componente>());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}