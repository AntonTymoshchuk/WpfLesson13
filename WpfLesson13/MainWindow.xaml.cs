using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLesson13.Models;

namespace WpfLesson13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Month decemberMonth = new Month() { Name = "December" };
            Month januaryMonth = new Month() { Name = "January" };
            Month februaryMonth = new Month() { Name = "February" };
            Month marchMonth = new Month() { Name = "March" };
            Month aprilMonth = new Month() { Name = "April" };
            Month mayMonth = new Month() { Name = "May" };
            Month juneMonth = new Month() { Name = "June" };
            Month julyMonth = new Month() { Name = "July" };
            Month augustMonth = new Month() { Name = "August" };
            Month septemberMonth = new Month() { Name = "September" };
            Month octoberMonth = new Month() { Name = "October" };
            Month novemberMonth = new Month() { Name = "November" };

            Season winterSeason = new Season()
            {
                Name = "Winter",
                Months = new List<Month>() { decemberMonth, januaryMonth, februaryMonth }
            };
            Season springSeason = new Season()
            {
                Name = "Spring",
                Months = new List<Month>() { marchMonth, aprilMonth, mayMonth }
            };
            Season summerSeason = new Season()
            {
                Name = "Summer",
                Months = new List<Month>() { juneMonth, julyMonth, augustMonth }
            };
            Season autumnSeason = new Season()
            {
                Name = "Autumn",
                Months = new List<Month>() { septemberMonth, octoberMonth, novemberMonth }
            };

            Year year2019 = new Year()
            {
                Name = "2019",
                Seasons = new List<Season>() { winterSeason, springSeason, summerSeason, autumnSeason }
            };

            yearTreeView.Items.Add(year2019);

            //for (int i = 1; i < 10; i++)
            //{
            //    TreeViewItem treeViewItem = new TreeViewItem();
            //    treeViewItem.Header = $"{i}";
            //    for (int j = 0; j < i; j++)
            //        treeViewItem.Items.Add(new TextBlock() { Text = $"{i}.{j + 1}" });
            //    myTreeView.Items.Add(treeViewItem);
            //}
            //myTreeView.Items.Add(new TreeViewItem() { Header = @"C:\" });
        }

        //private void GetContent(DirectoryInfo directoryInfo, TreeViewItem treeViewItem)
        //{
        //    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
        //    FileInfo[] fileInfos = directoryInfo.GetFiles();
        //    TreeViewItem[] childrenTreeViewItems = new TreeViewItem[directoryInfos.Length];
        //    for (int i = 0; i < childrenTreeViewItems.Length; i++)
        //    {
        //        childrenTreeViewItems[i] = new TreeViewItem() { Header = directoryInfos[i].Name };
        //        GetContent(directoryInfos[i], childrenTreeViewItems[i]);
        //    }
        //}
    }
}
