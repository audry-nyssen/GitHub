using System;
using System.Collections.Generic;
using System.IO;
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
using MarkdownSharp;

namespace MarkDownParser
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FILEPATH = @"C:\Users\Yoh\Downloads\MarkDownParser\MarkDownParser\MarkDownParser\bin\Debug\temp.html";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (File.Exists(FILEPATH))
            {
                File.Delete(FILEPATH);
            }

            using (StreamWriter sw = new StreamWriter(File.Open(FILEPATH, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)))
            {
                Markdown md = new Markdown();
                sw.Write("<meta charset=\"utf-8\">" + md.Transform(txt1.Text));
            }
            webBrowser1.Navigate(FILEPATH);
        }

        public void OpenFileMarkDown()
        {

        }
    }
}
