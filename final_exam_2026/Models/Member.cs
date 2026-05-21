using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_exam_2026.Models
{
    public class Member
    {

        // Properties
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string MembershipType { get; set; }

        public virtual List<TrainingSession> TrainingSessions { get; set; }

        // Constructors
        public Member()
        {
            TrainingSessions = new List<TrainingSession>();
        }

        // Methods

    }
}
