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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;
using Xceed.Words.NET;

namespace lab_12_one_thousand_documents
    
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stopwatch stopwatch = new Stopwatch();
        string currentTime = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            string folderName = @"C:\Users\Suzanne\github\2020-06-c-sharp-labs\labs\lab_12_new_doc_writer";
            string pathString = System.IO.Path.Combine(folderName, "TestFolder");
            System.IO.Directory.CreateDirectory(pathString);

            for (int i = 0; i < 5; i++)
            {
                string pathFile = $@"C:\Users\Suzanne\github\2020-06-c-sharp-labs\labs\lab_12_new_doc_writer{i}.txt";
                using (StreamWriter streamwriter = File.CreateText(pathFile)) ;

            }
            var document = DocX.Create("MyReport.docx");
            document.InsertParagraph("This is an amazing report with the time taken to produce 1000 documents.");
            document.InsertParagraph{stopwatch.Elapsed};
            document.InsertParagraph($"Report generated by Alex Matheakis {DateTime.Now}");
            document.Save();
            Process.Start("WINWORD.EXE", "MyReport.docx");
            stopwatch.Stop();

            clocktxtblock.Text = $"Time Taken: {stopwatch.Elapsed}s";

        }
    }
}


