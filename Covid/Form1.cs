using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid
{
    public partial class CovidForm : Form
    {
        List<Person> people = new List<Person>();
        public CovidForm()
        {
            InitializeComponent();
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            // hardcoded list of people
            // TODO - add real data
           people.Add(new Person { FirstName="daniel", LastName = "Ps"});

            StartUpPeopleList();
        }

        private void StartUpPeopleList()
        {
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = people;
            listPeopleListBox.DisplayMember = "FullName";
        }
        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;
            p.Email = emailText.Text;
            p.ContactNumber = contactNumberText.Text;
            p.Gender = (string)genderBox.SelectedItem;
            p.Age = ageText.Text;
            p.UnderlyingDiseases = diseasesText.Text;
            p.Address = addressText.Text;
            p.Date = dateTimeOfInfection.Value;


            //TODO - do something with item people

            people.Add(p);
            StartUpPeopleList();

            firstNameText.Text = "";
            lastNameText.Text = "";


        }
        private void CovidForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
