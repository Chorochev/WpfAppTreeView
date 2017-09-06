using System.Collections.Generic;

namespace WpfAppTreeView
{
    /// <summary>
    /// Модель данных для иерархического списка
    /// </summary>
    class TreeViewModel
    {
        /// <summary>
        /// Коллекция элементов иерархического списка
        /// </summary>
        public List<TreeViewItemModel> Root_ListTreeViewItem { get; set; }

        public TreeViewModel()
        {
            // Инициализируем коллекцию элементов
            Root_ListTreeViewItem = new List<TreeViewItemModel>();
        }
    }
    /// <summary>
    /// Элемент иерархического списка
    /// </summary>
    class TreeViewItemModel
    {
        /// <summary>
        /// Поле для примера
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Поле для примера
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Поле для примера
        /// </summary>
        public string FullName
        {
            get { return string.Format("{0}_{1}", Name, Number); }
        }
        /// <summary>
        /// Коллекция элементов иерархического списка для текущего элемента
        /// </summary>        
        public List<TreeViewItemModel> ListTreeViewItem { get; set; }

        public TreeViewItemModel()
        {
            // Инициализируем коллекцию элементов
            ListTreeViewItem = new List<TreeViewItemModel>();
        }
    }
}
