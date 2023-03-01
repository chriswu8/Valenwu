using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valenwu.Tables;

namespace Valenwu
{
    public partial class FormPatientInfo : Form
    {
        private MyDatabase program_database;

        public FormPatientInfo(MyDatabase database)
        {
            InitializeComponent();
            program_database = database;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            program_database.Patients.Insert(new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = first_name.Text,
                LastName = last_name.Text,
                MiddleName = middle_name.Text,
                Address= address.Text,
                City = city.Text,
                Province = province.Text,
                PostalCode = postal_code.Text,
                BirthDate= birth_date.Text,
                Phone= phone.Text,
                Email = email.Text,
                Occupation= occupation.Text,
                FirstVisit = first_visit.Text,
                LastVisit = last_visit.Text,
                Insurance = insurance.Text,
                Misc= misc.Text,
            });

            this.Close();
            

        }

        
    }
}
