using Lab_4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Competition c = new Competition
            //{
            //    Name = "test",
            //    SpeechList = new List<Speech>()
            //    {
            //        new Speech
            //        {
            //            Individual = true,
            //            Member = new Member{Name = "name", Surname = "surname", Birthday = DateTime.Today},
            //            Score = 100
            //        }
            //    }
            //};
            //var c1 = new Competition[] { c };
            //var jsonFormatter = new DataContractJsonSerializer(typeof(Competition[]));
            //using (FileStream fs = new FileStream("competitions.json", FileMode.OpenOrCreate))
            //{
            //    jsonFormatter.WriteObject(fs, c1);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var jsonFormatter = new DataContractJsonSerializer(typeof(Competition[]));
            //using (FileStream fs = new FileStream("competitions.json", FileMode.OpenOrCreate))
            //{                
            //    foreach (var cmp in (Competition[])jsonFormatter.ReadObject(fs))
            //    {
            //        foreach (var winners in cmp.ToShortString())
            //        {
            //            competitionsTextBox.Text += winners;
            //        }
            //    }
            //}
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Speech s = new Speech
            //{
            //    Individual = true,
            //    Score = 102,
            //    Member = new Member
            //    {
            //        Birthday = DateTime.Today,
            //        Name = "test2",
            //        Surname = "tesr"
            //    }
            //};

            //BusinessLogic.Logic.GetCompetition("test").AddSpeech(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormNewCompetition().Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            competitionsTextBox.Clear();
            var allSpeech = BusinessLogic.Logic.GetAllCompetitions();
            var lines = new List<string>();
            foreach (var member in allSpeech)
            {
                lines.Add(member.ToString());
            }
            competitionsTextBox.Lines = lines.ToArray();
        }
    }
}
