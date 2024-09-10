using System.Windows;

namespace CMCS_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Implement the functionality for submitting claims
            MessageBox.Show("Claim Submitted");
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            // Implement the functionality for uploading documents
            MessageBox.Show("Document Uploaded");
        }

        private void VerifyClaims_Click(object sender, RoutedEventArgs e)
        {
            // Implement the functionality for verifying claims
            MessageBox.Show("Claims Verified");
        }

        private void ApproveClaims_Click(object sender, RoutedEventArgs e)
        {
            // Implement the functionality for approving claims
            MessageBox.Show("Claims Approved");
        }
    }
}
