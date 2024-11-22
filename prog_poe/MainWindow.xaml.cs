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

            MessageBox.Show($"Claim Submitted:\nHours Worked: {hoursWorked}\nHourly Rate: {hourlyRate}\nNotes: {notes}",
                            "Claim Submission", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Upload Document button event
        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx|Excel files (*.xlsx)|*.xlsx"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                UploadedFileName.Text = openFileDialog.SafeFileName;
                MessageBox.Show($"File '{openFileDialog.FileName}' uploaded successfully.",
                                "File Upload", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Approve Claim button event
        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Approved.", "Approval", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Reject Claim button event
        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Rejected.", "Rejection", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Download File button event
        private void DownloadFile_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as System.Windows.Controls.Button;
            string filePath = button?.Tag?.ToString();

            if (!string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show($"Downloading file: {filePath}", "Download", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Approve All Claims button event
        private void ApproveAllClaims_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("All claims approved!", "Approval", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
