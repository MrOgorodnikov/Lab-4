using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Model
{
    [DataContract]
    class Member
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname}";
        }
    }
}
