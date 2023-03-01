using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valenwu
{
    public partial class FormPatient : Form
    {
        int counter = 0;

        private MyDatabase program_database;

        public FormPatient(MyDatabase database)
        {
            InitializeComponent();
            program_database = database;
            displayPatients();
        }

        protected override void OnActivated(EventArgs e)
        {
            displayPatients();
        }

        public void displayPatients()
        {
            var allPatients = program_database.Patients.ToList();
            foreach (var patient in allPatients)
            {
                Label testLabel = new Label();
                testLabel.Text = patient.FirstName;
                testLabel.Location = new Point(10, 10);
                if (counter >= 1)
                {
                    testLabel.Location = new Point(12, counter * testLabel.Height + 10);
                }
                this.panel1.Controls.Add(testLabel);
                counter += 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPatientInfo formPatientInfo = new FormPatientInfo(program_database);
            formPatientInfo.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
