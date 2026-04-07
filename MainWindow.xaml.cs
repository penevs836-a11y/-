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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> myTasks = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string nk = _1.Text;

            if (!string.IsNullOrWhiteSpace(nk))
            {
                myTasks.Add(nk);
                _1.Clear();

                Ss();
            }
        }
            void Ss()
            {
                string temp = "Мои дела:\n";
                for (int i = 0; i < myTasks.Count; i++)
                {
                    
                    temp += $"{i + 1}. {myTasks[i]}\n";
                }
                _2.Text = temp;
            }

        

        private void ButtonD_Click(object sender, RoutedEventArgs e)
        {
        
            if (int.TryParse(_1.Text, out int number))
            {
                int index = number - 1; 

                
                if (index >= 0 && index < myTasks.Count)
                {
                    myTasks.RemoveAt(index); 
                    _1.Clear();
                    Ss(); 
                }
                else
                {
                    _2.Text = "Задачи с таким номером нет";
                }
            }
        }
    }
}

       
    
    
