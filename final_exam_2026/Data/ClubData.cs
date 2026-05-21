using final_exam_2026.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace final_exam_2026.Data
{
    public class ClubData : DbContext
    {

        public ClubData() : base("OODExam_KrystianChmielak") { }

        public DbSet<Member> Members { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }
    }
}
