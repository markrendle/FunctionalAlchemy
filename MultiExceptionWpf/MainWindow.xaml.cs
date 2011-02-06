using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

namespace MultiExceptionWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            TryWithUsing();
        }
        private void TryOpenFile()
        {
            TryCatch.Try(() =>
                             {
                                 using (var stream = File.OpenRead(FileTextBox.Text))
                                 {
                                     Trace.WriteLine(stream.Length);
                                 }
                             })
            .Catch<FileNotFoundException,
                    DirectoryNotFoundException,
                    UnauthorizedAccessException>
                (ex =>
                {
                    MessageBox.Show(ex.Message, "Fail");
                });
        }

        private void TryWithUsing()
        {
            TryCatch.TryUsing(() => File.OpenRead(FileTextBox.Text),
                              stream => Trace.WriteLine(stream.Length))
                .Catch<FileNotFoundException,
                    DirectoryNotFoundException,
                    UnauthorizedAccessException>
                (ex => MessageBox.Show(ex.Message, "Fail"));
        }
    }
}
