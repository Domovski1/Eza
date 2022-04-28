using System;
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
        // Тут добавляем лист с данными, из которых мы и будем брать 15 записей в будущем
        public MaterialsPage()
        {
            InitializeComponent();
        }



        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MaterialList.ItemsSource = App.db.Material.Where(x => x.Title.Contains(TxbSearch.Text)).Take(15).ToList();
                ResultTxb.Text = MaterialList.Items.Count + "/" + App.db.Material.Where(x => x.Title.Contains(TxbSearch.Text)).Count().ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                CmbFilter.ItemsSource = App.db.MaterilType.ToList();
                CmbFilter.DisplayMemberPath = "Title";
                CmbSort.SelectedIndex = 0;
                CmbFilter.SelectedIndex = 0;

                // Вывод данных из БД должен быть тут
                MaterialList.ItemsSource = App.db.Material.Take(15).ToList();


                ResultTxb.Text = MaterialList.Items.Count + "/" + App.db.Material.Count().ToString();

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Упс, что-то пошло не так!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
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


        // При выделении нескольких эл-ов появляется кнопка редактировать все
        private void MaterialList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MaterialList.SelectedItems.Count > 1)
            {
                ChangeAllValue_Btn.Visibility = Visibility.Visible;
            }
            else if (MaterialList.SelectedItems.Count == 1)
            {
                ChangeAllValue_Btn.Visibility = Visibility.Collapsed;

            }
        }
    }
}
