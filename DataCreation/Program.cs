using final_exam_2026.Data;
using final_exam_2026.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace DataCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ClubData db = new ClubData();

                using (db)
                {
                    //Create Members
                    Member m1 = new Member()
                    {
                        FirstName = "Judd",
                        Surname = "Trump",
                        DateOfBirth = new DateTime(1990,09,12),
                        ContactNumber = "123456789",
                        MembershipType = "Premium"
                    };

                    Console.WriteLine("Created the Member");

                    // Save to Database
                    Console.WriteLine("ABOUT TO ADD Member");
                    db.Members.Add(m1);
                    Console.WriteLine("Added Member to db");

                    // Create appointment
                    TrainingSession t1 = new TrainingSession()
                    {
                        SessionDate = new DateTime(2025, 5, 1, 9, 0, 0),
                        Member = m1,
                        MemberId = m1.MemberId,
                        SessionType = "Snooker Practice",
                        DurationMinutes = 120,
                        CoachNotes = "Focus on break-building and safety play."
                    };
                    Console.WriteLine("Created TrainingSession");

                    db.TrainingSessions.Add(t1);
                    Console.WriteLine("Added TrainingSession to DB");

                    db.SaveChanges();
                    Console.WriteLine("Saved changed to DB");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
        }
    }
}
