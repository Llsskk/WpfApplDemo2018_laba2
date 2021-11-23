using System.Windows;
using WpfApplDemo2018.ViewModel;
namespace WpfApplDemo2018.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowRole : Window
{
        public WindowRole()
        {
            InitializeComponent();
            RoleViewModel vmRole = new RoleViewModel();
            lvRole.ItemsSource = vmRole.ListRole;
        }
    }
}
