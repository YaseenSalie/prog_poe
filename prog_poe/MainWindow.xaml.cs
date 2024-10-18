using System.Windows;
using Microsoft.Win32;

namespace CMCS_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Submit Claim button event
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            string hoursWorked = HoursWorkedTextBox.Text;
            string hourlyRate = HourlyRateTextBox.Text;
            string notes = NotesTextBox.Text;

            // Process the claim submission logic here
            MessageBox.Show($"Claim Submitted!\nHours Worked: {hoursWorked}\nHourly Rate: {hourlyRate}\nNotes: {notes}",
                            "Submission Successful", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Upload Document button event
        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx|Excel files (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                MessageBox.Show($"Document '{fileName}' uploaded successfully.", "Upload Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Verify Claims button event
        private void VerifyClaims_Click(object sender, RoutedEventArgs e)
        {
            // Logic for verifying claims
            MessageBox.Show("All pending claims have been verified!", "Verification Successful", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Approve Claims button event
        private void ApproveClaims_Click(object sender, RoutedEventArgs e)
        {
            // Logic for approving claims
            MessageBox.Show("All pending claims have been approved!", "Approval Successful", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
