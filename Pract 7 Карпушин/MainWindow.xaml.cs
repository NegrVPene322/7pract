using System.Runtime.ExceptionServices;
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

namespace Pract_7_Карпушин
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
        Time first = new Time(0,0,0);
        Time second = new Time(0,0,0);
        Time third = new Time(0,0,0);
        private void bt_input1_Click(object sender, RoutedEventArgs e)
        {
            string str1 = tb_t1.Text;
            string str2 = tb_t2.Text;
            string str3 = tb_t3.Text;
            string[] words1 = str1.Split(' ');
            string[] words2 = str2.Split(' ');
            string[] words3 = str3.Split(' ');


            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];

            if ((words1.Length == 3) && (words2.Length == 3) && (words3.Length == 3))
            {

                for (int i = 0; i < words1.Length; i++)
                {

                    int q, w, r;
                    bool f1, f2, f3;
                    f1 = int.TryParse(words1[i], out q);
                    f2 = int.TryParse(words2[i], out w);
                    f3 = int.TryParse(words3[i], out r);
                    if (f1 && f2 && f3)
                    {
                        a[i] = q;
                        b[i] = w;
                        c[i] = r;
                    }
                    else MessageBox.Show("Некоректный формат");



                }


                Triad triad1 = new Triad(a[0], a[1], a[2]);
                Triad triad2 = new Triad(b[0], b[1], b[2]);
                Triad triad3 = new Triad(c[0], c[1], c[2]);

                bool f1a2 = triad1 == triad2;
                if (f1a2) tb_1a2t.Text = "1 и 2 равны ";
                else tb_1a2t.Text = "1 и 2 не равны";

                bool f1a3 = triad1 == triad3;
                if (f1a3) tb_1a3t.Text = "1 и 3 равны";
                else tb_1a3t.Text = "1 и 3 не равны";

                bool f2a3 = triad2 == triad3;
                if (f2a3) tb_2a3t.Text = "2 и 3 равны";
                else tb_2a3t.Text = "2 и 3 не равны";
            }
            else MessageBox.Show("Не везде по 3 числа");
        }

        private void bt_clear1_Click(object sender, RoutedEventArgs e)
        {
            tb_1a2t.Clear();
            tb_1a3t.Clear();
            tb_2a3t.Clear();
        }

        private void bt_input2_Click(object sender, RoutedEventArgs e)
        {
            string str1 = tb_time1.Text;
            string str2 = tb_time2.Text;
            string str3 = tb_time3.Text;
            string[] words4 = str1.Split(' ');
            string[] words5 = str2.Split(' ');
            string[] words6 = str3.Split(' ');


            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];

            if ((words4.Length == 3) && (words5.Length == 3) && (words6.Length == 3))
            {

                for (int i = 0; i < words4.Length; i++)
                {

                    int q, w, r;
                    bool f1, f2, f3;
                    f1 = int.TryParse(words4[i], out q);
                    f2 = int.TryParse(words5[i], out w);
                    f3 = int.TryParse(words6[i], out r);
                    if (f1 && f2 && f3)
                    {
                        a[i] = q;
                        b[i] = w;
                        c[i] = r;
                    }
                    else MessageBox.Show("Некоректный формат");



                }


                Time first = new Time(a[0], a[1], a[2]);
                Time second = new Time(b[0], b[1], b[2]);
                Time third = new Time(c[0], c[1], c[2]);

                string vid1 = Time.Vid(first);
                string vid2 = Time.Vid(second);
                string vid3 = Time.Vid(third);

                string time1a2 = Time.Moment(first, second);
                string time2a3 = Time.Moment(second, third);
                string time1a3 = Time.Moment(first, third);

                tb_time1a2t.Text = time1a2;
                tb_time1a3t.Text = time1a3;
                tb_time2a3t.Text = time2a3;

                tb_vid1.Text = vid1;
                tb_vid2.Text = vid2;
                tb_vid3.Text = vid3;
            }
            else MessageBox.Show("Не везде по 3 числа");
            
        
        
        
        }

        private void bt_clear2_Click(object sender, RoutedEventArgs e)
        {
            tb_time1a2t.Clear();
            tb_time1a3t.Clear();
            tb_time2a3t.Clear();
            tb_vid1.Clear();
            tb_vid2.Clear();
            tb_vid3.Clear();
            first = null;
            second = null;
            third = null;
        }

        private void bt_esc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_inf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая 7, разраб карпушин а.д вариант 9");
        }
    }
}
