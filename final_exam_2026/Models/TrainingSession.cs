using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_exam_2026.Models
{
    public class TrainingSession
    {

        // Properties
        public int SessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }

        public virtual int MemberId { get; set; }
        public virtual Member Member { get; set; }

        // Constructors

        // Methods
        override public string ToString()
        {
            return $"{SessionDate}: {SessionType} ({DurationMinutes}) mins {CoachNotes}";
        }
    }
}
