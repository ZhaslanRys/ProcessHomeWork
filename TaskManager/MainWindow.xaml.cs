using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TaskManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Process[] processes;
        public MainWindow()
        {
            InitializeComponent();
            processes = Process.GetProcesses();
            foreach(var process in processes)
            {
                listBox.Items.Add("ProcessName: " + process.ProcessName + "\t\tProcessId: " + process.Id);
            }
        }

        private void KillButtonClick(object sender, RoutedEventArgs e)
        {
            
            var processes = Process.GetProcesses();
            processes[listBox.SelectedIndex].Kill();
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }
    }
}
