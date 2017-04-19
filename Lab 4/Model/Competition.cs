using Lab_4.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace Lab_4.Model
{
    [DataContract]
    class Competition
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Speech> SpeechList { get; set; }

        public void AddSpeech(Speech speech)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(Competition[]));
            using (FileStream fs = new FileStream("competitions.json", FileMode.OpenOrCreate))
            {
                var allCmp = (Competition[])jsonFormatter.ReadObject(fs);
                fs.SetLength(0);
                foreach (var cmp in allCmp)                
                    if (cmp.Name == this.Name)                    
                        cmp.SpeechList.Add(speech);
                jsonFormatter.WriteObject(fs, allCmp);

            }
        }

        public List<string> ToShortString()
        {
            var winners = new List<string>();
            //foreach (var winner in Logic.GetWinner(SpeechList))
            //    winners.Add($"Competition: {Name}, Winner: {winner.Member.Name}");

            return winners;
           
        }

        public override string ToString()
        {
            var lines = new List<string>();
            var str = Name;
            lines.Add(Name);
            foreach (var speech in SpeechList)
            {
                str += " " + speech.ToString();
                lines.Add(speech.ToString());
            }
            return str;
        }


    }
}
