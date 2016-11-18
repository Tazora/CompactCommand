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
using System.Diagnostics;

namespace CompactCommand
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float minutes;
            float.TryParse(textBox.Text, out minutes);
            Process.Start("shutdown", "/a");
            Process.Start("shutdown", "/s /t " + minutes * 60.0f);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", "/a");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ///string command;
            ///Process p;
            ///command = "'C:\\Users/Sebastian\\sciebo\\Programmieren und Design\\Python\\DjangoSkat\\skat\\manage.py runserver'";
            ///p = Process.Start("python", command);
            ///p.WaitForExit(100000);
            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            Process python;
            pythonInfo.FileName = @"C:\Users\Sebastian\AppData\Local\Programs\Python\Python35-32\python.exe";
            pythonInfo.Arguments = "C://Users//Sebastian//sciebo//Programmieren und Design//Python//DjangoSkat//skat//manage.py runserver";
            pythonInfo.CreateNoWindow = false;
            pythonInfo.UseShellExecute = true;

            Console.WriteLine("Python Starting");
            python = Process.Start(pythonInfo);
            python.WaitForExit();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
