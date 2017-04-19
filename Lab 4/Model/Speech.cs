using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Model
{
    [DataContract]
    class Speech
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public bool Individual { get; set; }
        [DataMember]
        public static int Count { get; set; }
        [DataMember]
        public int MemberId { get; set; }
        [DataMember]
        public double Score { get; set; }

        public override string ToString()
        {
            return $"{Id} {BusinessLogic.Logic.GetMemberById(MemberId)}";
        }
    }
}
