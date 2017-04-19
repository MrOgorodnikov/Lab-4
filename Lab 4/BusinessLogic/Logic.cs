using Lab_4.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.BusinessLogic
{
    class Logic
    {
        public static List<Speech> GetWinner(List<Speech> speechList)
        {
            var maxScore = speechList.Select(sl => sl.Score).ToList().Max();
            return speechList.Where(sl => sl.Score == maxScore).ToList();            
        }

        public static Competition GetCompetition(string name)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(Competition[]));
            using (FileStream fs = new FileStream("competitions.json", FileMode.OpenOrCreate))
            {
                var allCmp = (Competition[])jsonFormatter.ReadObject(fs);
                foreach (var cmp in allCmp)
                    if (cmp.Name == name)
                        return cmp;
                

            }
            return new Competition();
        }
        
        public static List<Member> GetAllMembers()
        {
            var json = new DataContractJsonSerializer(typeof(Member[]));
            using (FileStream fs = new FileStream(FileNames.Members, FileMode.OpenOrCreate))
            {
                var members = new List<Member>();
                if (fs.Length != 0)
                {
                    var memb = (Member[])json.ReadObject(fs);
                    members = memb.ToList();
                }

                return members;
                
            }
        }

        public static List<Competition> GetAllCompetitions()
        {
            var json = new DataContractJsonSerializer(typeof(Competition[]));
            using (FileStream fs = new FileStream(FileNames.Competitions, FileMode.OpenOrCreate))
            {
                var members = new List<Competition>();
                if (fs.Length != 0)
                {
                    var memb = (Competition[])json.ReadObject(fs);
                    members = memb.ToList();
                }

                return members;

            }
        }

        public static List<Speech> GetAllSpeech()
        {
            var json = new DataContractJsonSerializer(typeof(Speech[]));
            using (FileStream fs = new FileStream(FileNames.Speeches, FileMode.OpenOrCreate))
            {
                var speech = new List<Speech>();
                if (fs.Length != 0)
                {
                    var sp = (Speech[])json.ReadObject(fs);
                    speech = sp.ToList();
                }

                return speech;

            }
        }

        public static Speech GetSpeechById(int id)
        {
            var json = new DataContractJsonSerializer(typeof(Speech[]));
            using (FileStream fs = new FileStream(FileNames.Speeches, FileMode.OpenOrCreate))
            {
                foreach (var speech in (Speech[])json.ReadObject(fs))
                {
                    if (speech.Id == id)
                    {
                        return speech;
                    }
                };

                return new Speech();
            }
        }

        public static Member GetMemberById(int id)
        {
            var json = new DataContractJsonSerializer(typeof(Member[]));
            using (FileStream fs = new FileStream(FileNames.Members, FileMode.OpenOrCreate))
            {
                foreach (var member in (Member[])json.ReadObject(fs))
                {
                    if (member.Id == id)
                    {
                        return member;
                    }
                }

                return new Member();

            }
        }

        public static void AddMember(Member member)
        {
            var json = new DataContractJsonSerializer(typeof(Member[]));
            using (FileStream fs = new FileStream(FileNames.Members, FileMode.OpenOrCreate))
            {
                var members = new List<Member>();
                if (fs.Length != 0)
                {
                    var memb = (Member[])json.ReadObject(fs);
                    members = memb.ToList();
                }
                
                members.Add(member);
                fs.SetLength(0);
                json.WriteObject(fs, members.ToArray());
            }
        }

        public static void AddSpeech(Speech speech)
        {
            var json = new DataContractJsonSerializer(typeof(Speech[]));
            using (FileStream fs = new FileStream(FileNames.Speeches, FileMode.OpenOrCreate))
            {
                var speeches = new List<Speech>();
                if (fs.Length != 0)
                {
                    var sp = (Speech[])json.ReadObject(fs);
                    speeches = sp.ToList();
                }

                speeches.Add(speech);
                fs.SetLength(0);
                json.WriteObject(fs, speeches.ToArray());
            }
        }

        public static void AddCompetition(Competition competition)
        {
            var json = new DataContractJsonSerializer(typeof(Competition[]));
            using (FileStream fs = new FileStream(FileNames.Competitions, FileMode.OpenOrCreate))
            {
                var speeches = new List<Competition>();
                if (fs.Length != 0)
                {
                    var sp = (Competition[])json.ReadObject(fs);
                    speeches = sp.ToList();
                }

                speeches.Add(competition);
                fs.SetLength(0);
                json.WriteObject(fs, speeches.ToArray());
            }
        }
    }
}
