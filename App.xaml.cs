using Clothes.Model;
using System.Windows;

namespace Clothes
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ClothesBaseEntities db = new ClothesBaseEntities();
    }
}
