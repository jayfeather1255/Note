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

namespace _0510_note
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // 產生儲存檔案視窗 SaveFileDialog
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 當按下儲存之後的反應
            if (result == true)
            {
                // 寫入檔案
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
            }            
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 當按下儲存之後的反應
            if (result == true)
            {
                // 寫入檔案
                Textarea.Text = System.IO.File.ReadAllText(dig.FileName);
            }

        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void FontSmall_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 12;
        }

        private void FontNormal_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 16;
        }

        private void FontBig_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 24;
        }

        private void Whtie_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.White;
            Textarea.Foreground = Brushes.Black;
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.DarkSlateGray;
            Textarea.Foreground = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
