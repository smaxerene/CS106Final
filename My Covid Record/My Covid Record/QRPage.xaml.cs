﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using QRCoder;

namespace My_Covid_Record
{
    public partial class QRPage : Window
    {
        public QRPage()
        {
            InitializeComponent();
        }

        private void btnClosePopup_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void btnShowPopup_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnShowPopup)
            {

                myPopup.IsOpen = true;
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void GenerateQRCode_Click(object sender, RoutedEventArgs e)
        {
            string inputData = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(inputData))
            {
                MessageBox.Show("Please enter the text to generate the QR code or put the link of your website.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputData, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                qrCode.GetGraphic(20).Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                imgQRCode.Source = bitmapImage;
            }
        }

        private void DownloadQRCode_Click(object sender, RoutedEventArgs e)
        {
            if (imgQRCode.Source == null)
            {
                MessageBox.Show("Please generate the QR code first.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            BitmapSource bitmapSource = (BitmapSource)imgQRCode.Source;
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

            string fileName = "QRCode.png"; // Change the file name and extension as desired
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    encoder.Save(fileStream);
                }

                MessageBox.Show($"QR code saved successfully: {filePath}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving QR code: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
