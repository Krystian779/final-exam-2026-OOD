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
using System.Windows.Navigation;
using System.Windows.Shapes;
using final_exam_2026.Data;

namespace final_exam_2026
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClubData db;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // determine Member selected
            Member selectedMember = lbxMembers.SelectedItem as Member;

            // check for null
            if (selectedMember != null)
            {
                // display details of patient in textboxes
                tblkID.Text = selectedMember.MemberId.ToString();
                tblkFirstName.Text = selectedMember.FirstName;
                tblkSurname.Text = selectedMember.Surname;
                tblkContactNumber.Text = selectedMember.ContactNumber;
                tblkDateOfBirth.Text = selectedMember.DateOfBirth.ToString();

                // display appointments for patient in listbox
                var trainingSessions = db.TrainingSessions.Where(a => a.MemberId == selectedMember.MemberId).ToList();

                if (trainingSessions.Count > 0)
                {
                    lbxTrainingSessions.ItemsSource = trainingSessions;
                    lbxTrainingSessions.SelectedIndex = -1;
                }
                else
                {
                    lbxTrainingSessions.ItemsSource = new string[] { "No appointments found" };
                }
            }
        }
    }
}
