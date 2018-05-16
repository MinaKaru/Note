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

namespace notebook
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // 讀檔 ( 路徑 )
            //Textarea.Text = System.IO.File.ReadAllText(@"C:\Users\陳柏霖\Desktop\Note\123.txt");

            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                Textarea.Text = System.IO.File.ReadAllText(dig.FileName);
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // 存檔 ( 路徑 . 文字內容 )
            //System.IO.File.WriteAllText(@"C:\Users\陳柏霖\Desktop\Note\123.txt", Textarea.Text);

            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                string filename = dig.FileName;
            }
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Clear();
        }

        private void BlackBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.Foreground = Brushes.Black;
        }

        private void WhiteBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.Foreground = Brushes.White;
        }

        private void Size1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.FontSize = 30;
        }

        private void Size2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.FontSize = 20;
        }

        private void Size3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.FontSize = 15;
        }
    }
}
