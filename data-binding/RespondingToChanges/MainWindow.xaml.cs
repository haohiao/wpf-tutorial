using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace RespondingToChanges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>()
        {
            new User("刘大"),
            new User("关二"),
            new User("张三"),
        };

        public ObservableCollection<User> Users { get => users; }

        public MainWindow()
        {
            InitializeComponent();
            // UserListBox.ItemsSource = users;
            this.DataContext = this;
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            string name = UserTextBox.Text.Trim();
            
            if (name.Length == 0) return;

            User user = new User(name);
            users.Add(user);
        }

        private void ChangeUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserListBox.SelectedItem == null) return;
            User user = UserListBox.SelectedItem as User;

            user.Name = UserTextBox.Text.Trim();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserListBox.SelectedItem == null) return;
            User user = UserListBox.SelectedItem as User;

            users.Remove(user);
        }

        private void UserListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserListBox.SelectedItem == null) return;
            User user = UserListBox.SelectedItem as User;

            UserTextBox.Text = user.Name;
        }
    }

    public class User : INotifyPropertyChanged
    {
        public User() { }
        public User(string name)
        {
            Name = name;
        }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (name == value) return;
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}