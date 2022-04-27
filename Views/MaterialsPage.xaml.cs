using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Clothes.Views
{
    /// <summary>
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        public MaterialsPage()
        {
            InitializeComponent();
        }



        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CmbFilter.SelectedIndex = 0;



            // Вывод данных из БД должен быть тут
            MaterialList.ItemsSource = App.db.Material.ToList();
            ;
        }



        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
