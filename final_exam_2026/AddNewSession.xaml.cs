using final_exam_2026.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using final_exam_2026.Data;

namespace final_exam_2026
{
    /// <summary>
    /// Interaction logic for AddNewSession.xaml
    /// </summary>
    public partial class AddNewSession : Window
    {
        

        private Member _selectedMember;
        private ClubData _db;
        private TrainingSession _selectedTrainingSession;

        public AddNewSession()
        {
            InitializeComponent();
        }

        public AddNewSession(Member selectedMember, ClubData db) : this()
        {
            _selectedMember = selectedMember;
            _db = db;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            // Read info
            string date = tbxDate.Text;
            string startTime = tbxStartTime.Text;
            string type = tbxType.Text;
            string duration = tbxDuration.Text;
            string notes = tbxNotes.Text;

            if (_selectedMember != null)
            {
                // Create appointment object
                TrainingSession newTrainingSession = new TrainingSession()
                {
                    CoachNotes = notes,
                    MemberId = _selectedMember.MemberId
                };

                // Add to database
                _db.TrainingSessions.Add(newTrainingSession);
                _db.SaveChanges();

                // Close Window
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
