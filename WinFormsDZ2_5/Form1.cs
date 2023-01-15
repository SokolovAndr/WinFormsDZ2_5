using System.Linq;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsDZ2_5
{
    public partial class Form1 : Form
    {
        Timer Timer;
        public Form1()
        {
            InitializeComponent();
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += (s, e) => {
                label1.Text = DateTime.Now.ToString("yyyy.MM.dd, HH.mm.ss");
            };
            Timer.Start();  
        }
    }
}