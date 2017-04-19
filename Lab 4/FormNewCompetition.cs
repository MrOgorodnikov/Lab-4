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
    public partial class FormNewCompetition : Form
    {
        public FormNewCompetition()
        {
            InitializeComponent();
        }

        private void newSpeechButton_Click(object sender, EventArgs e)
        {
            new FormNewSpeech().Show();
        }

        private void FormNewCompetition_Activated(object sender, EventArgs e)
        {
            speechCheckedListBox.Items.Clear();
            var allSpeech = BusinessLogic.Logic.GetAllSpeech();
            foreach (var member in allSpeech)
            {
                speechCheckedListBox.Items.Add(member);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int competitionsId = Convert.ToInt32(File.ReadAllText(FileNames.CompetitionsId));
            var id = competitionsId;
            competitionsId++;
            File.WriteAllText(FileNames.CompetitionsId, competitionsId.ToString());
            var speeches = new List<Speech>();

            foreach (var speech in speechCheckedListBox.SelectedItems)
            {
                speeches.Add(BusinessLogic.Logic.GetSpeechById(Convert.ToInt32(speech.ToString().Split(' ')[0])));
            }

            var competition = new Competition
            {
                Name = nameTextBox.Text,
                SpeechList = speeches
            };

            BusinessLogic.Logic.AddCompetition(competition);
        }
    }
}
