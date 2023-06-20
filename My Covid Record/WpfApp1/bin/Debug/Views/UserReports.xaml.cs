﻿using System;
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

namespace WpfApp1.Views
{
    public partial class UserReports : Window
    {
        public UserReports()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string subject = SubjectTextBox.Text;
            string description = DescriptionTextBox.Text;

            ReportIssue reportIssueWindow = new ReportIssue(email, subject, description);
            reportIssueWindow.ShowDialog();
        }
       
    }
}
