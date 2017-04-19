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
    public partial class FormNewSpeech : Form
    {
        public FormNewSpeech()
        {
            InitializeComponent();
        }

        private void newMemberButton_Click(object sender, EventArgs e)
        {
            new FormNewMember().Show();
        }

        private void FormNewSpeech_Load(object sender, EventArgs e)
        {
            membersCheckedListBox.SelectionMode = SelectionMode.One;

        }

        private void FormNewSpeech_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void FormNewSpeech_Activated(object sender, EventArgs e)
        {
            membersCheckedListBox.Items.Clear();
            var allMembers = BusinessLogic.Logic.GetAllMembers();
            foreach (var member in allMembers)
            {
                membersCheckedListBox.Items.Add(member);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int speechesId = Convert.ToInt32(File.ReadAllText(FileNames.SpeechesId));
            var id = speechesId;
            speechesId++;
            File.WriteAllText(FileNames.SpeechesId, speechesId.ToString());

            var speech = new Speech()
            {
                Id = id,
                Individual = checkBox1.Checked,
                Score = Convert.ToDouble(scoreTextBox.Text),
                MemberId = Convert.ToInt32(membersCheckedListBox.SelectedItem.ToString().Split(' ')[0])
            };
            BusinessLogic.Logic.AddSpeech(speech);
        }
    }
}
