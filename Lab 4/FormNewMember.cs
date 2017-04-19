using Lab_4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class FormNewMember : Form
    {
        public FormNewMember()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox3.Text = e.Start.ToShortDateString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int membersId = Convert.ToInt32(File.ReadAllText(FileNames.MembersId));
            var id = membersId;
            membersId++;
            File.WriteAllText(FileNames.MembersId, membersId.ToString());
            BusinessLogic.Logic.AddMember(new Model.Member
            {                
                Id = id,
                Name = textBox1.Text,
                Surname = textBox2.Text,
                Birthday = Convert.ToDateTime(textBox3.Text)
            });
            
        }
    }
}
