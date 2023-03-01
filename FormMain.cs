namespace Valenwu
{
    public partial class Valenwu : Form
    {
        private MyDatabase program_database;
        public Valenwu(MyDatabase database)
        {
            InitializeComponent();
            program_database = database;
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            FormPatient formPatient = new FormPatient(program_database);
            formPatient.ShowDialog();
        }
    }
}