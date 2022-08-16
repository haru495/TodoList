using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace TodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<TodoElement> todoList = new BindingList<TodoElement>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // ListBoxのTodoListで表示する内容を設定している
        public void SetBindingList(object sender, RoutedEventArgs e)
        {
            TodoList.ItemsSource = todoList;
        }

        public void AddTodoList(object sender, RoutedEventArgs e)
        {
            todoList.Add(new TodoElement(TodoText.Text, false));
        }

        public void DeleteTodoList(object sender, RoutedEventArgs e)
        {
            BindingList<TodoElement> ListTmp = new BindingList<TodoElement>();

            foreach(TodoElement element in todoList)
            {
                ListTmp.Add(element);
            }

            foreach(TodoElement element in ListTmp)
            {
                // CheckBoxでチェックが入るとBindingしているDoneFlgにtrueが入る
                if(element.DoneFlg) todoList.Remove(element);
            }
        }
    }
}
