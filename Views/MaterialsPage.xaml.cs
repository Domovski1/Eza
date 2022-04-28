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
            CmbSort.SelectedIndex = 0;

            // Вывод данных из БД должен быть тут
            MaterialList.ItemsSource = App.db.Material.Take(15).ToList();


            ResultTxb.Text = MaterialList.Items.Count + "/" + App.db.Material.Count().ToString();
            ;
        }



        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        void SortandFilter()
        {

        }

        private void ThirtyMaterials_Click(object sender, RoutedEventArgs e)
        {
            MaterialList.ItemsSource = App.db.Material.Where(x => x.Code > 15).Take(15).ToList();
            FirstTxb.TextDecorations = null;
            SecondTxb.TextDecorations = TextDecorations.Underline;

        }
    }
}
