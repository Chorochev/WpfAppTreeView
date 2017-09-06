using System.Windows;

namespace WpfAppTreeView
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TreeViewModel dc = new TreeViewModel();
            // Создадим узлы для иерархического списка
            // Уровень 1
            TreeViewItemModel level1_1 = new TreeViewItemModel() { Number = 1, Name = "Уровень 1" };
            TreeViewItemModel level1_2 = new TreeViewItemModel() { Number = 2, Name = "Уровень 1" };
            // Уровень 2
            TreeViewItemModel level2_1 = new TreeViewItemModel() { Number = 1, Name = "Уровень 2" };
            TreeViewItemModel level2_2 = new TreeViewItemModel() { Number = 2, Name = "Уровень 2" };
            TreeViewItemModel level2_3 = new TreeViewItemModel() { Number = 3, Name = "Уровень 2" };
            TreeViewItemModel level2_4 = new TreeViewItemModel() { Number = 4, Name = "Уровень 2" };
            // Уровень 3
            TreeViewItemModel level3_1 = new TreeViewItemModel() { Number = 1, Name = "Уровень 3" };
            TreeViewItemModel level3_2 = new TreeViewItemModel() { Number = 2, Name = "Уровень 3" };
            // Собираем иерархический список
            level2_3.ListTreeViewItem.Add(level3_1);
            level2_3.ListTreeViewItem.Add(level3_2);
            level1_1.ListTreeViewItem.Add(level2_1);
            level1_1.ListTreeViewItem.Add(level2_2);
            level1_1.ListTreeViewItem.Add(level2_3);
            level1_1.ListTreeViewItem.Add(level2_4);
            dc.Root_ListTreeViewItem.Add(level1_1);
            dc.Root_ListTreeViewItem.Add(level1_2);
            // Контекст данных
            DataContext = dc;
        }
    }
}
