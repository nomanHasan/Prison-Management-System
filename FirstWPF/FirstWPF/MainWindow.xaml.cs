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
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HtCaption = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg,
                int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void moveWindow(object sender, MouseButtonEventArgs e)
        {
            ReleaseCapture();

            SendMessage(new WindowInteropHelper(this).Handle, WM_NCLBUTTONDOWN, HtCaption, 0);

        }

        private void EXIT(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize(object sender, MouseButtonEventArgs e)
        {
            if(this.WindowState==WindowState.Normal)this.WindowState = WindowState.Maximized;
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void ActivateTitleIcons(object sender, MouseEventArgs mouseEventArgs)
        {
            CloseButton.Fill = (ImageBrush) Main.Resources["close_act"];
            MinButton.Fill = (ImageBrush) Main.Resources["minimize_act"];
            MaxButton.Fill = (ImageBrush) Main.Resources["maximize_act"];
        }

        private void DeactivateTitleIcons(object sender, MouseEventArgs e)
        {
            CloseButton.Fill = (ImageBrush) Main.Resources["close_inact"];
            MinButton.Fill = (ImageBrush) Main.Resources["minimize_inact"];
            MaxButton.Fill = (ImageBrush) Main.Resources["maximize_inact"];
        }

        private void ClosePressing(object sender, MouseEventArgs e)
        {
            CloseButton.Fill = (ImageBrush) Main.Resources["close_pr"];
        }

        private void MinimizePressing(object sender, MouseButtonEventArgs e)
        {
            MinButton.Fill = (ImageBrush) Main.Resources["minimize_pr"];
        }

        private void MaximizePressing(object sender, MouseEventArgs e)
        {
            MaxButton.Fill = (ImageBrush) Main.Resources["maximize_pr"];
        }

        private void Login(object sender, MouseEventArgs e)
        {
            
        }
    }
}
