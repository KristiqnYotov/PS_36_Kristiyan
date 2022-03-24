using System;
using System.Collections.Generic;
using System.Windows;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window
    {
        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }
        public DateTime LastChecked { get; set; }

        public ExpenseItHome()
        {
            MainCaptionText = "View Expense Report :";
            LastChecked = DateTime.Now;
            this.DataContext = this;
            InitializeComponent();
            ExpenseDataSource = new List<Person>()
            {
               new Person()
               {
                 Name="Mike",
                 Department ="Legal",
                 Expenses = new List<Expense>()
                 {
                      new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
                      new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                 }
               },
               new Person()
               {
                 Name ="Lisa",
                 Department ="Marketing",
                 Expenses = new List<Expense>()
                 {
                       new Expense() { ExpenseType="Document printing", ExpenseAmount=50 },
                       new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
                 }
               },
               new Person()
               {
                 Name="John",
                 Department ="Engineering",
                 Expenses = new List<Expense>()
                 {
                    new Expense() { ExpenseType="Magazine subscription", ExpenseAmount=50 },
                    new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
                    new Expense() { ExpenseType="Software", ExpenseAmount=500 }
                 }
               },
               new Person()
               {
                 Name="Mary",
                 Department ="Finance",
                 Expenses = new List<Expense>()
                 {
                   new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
               },
               new Person()
               {
                 Name="Theo",
                 Department ="Marketing",
                 Expenses = new List<Expense>()
                 {
                    new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
               },
               new Person()
               {
                 Name="James",
                 Department ="Engineering",
                 Expenses = new List<Expense>()
                 {
                    new Expense() { ExpenseType="Car", ExpenseAmount=10000 }
                 }
               },
               new Person()
               {
                 Name="David",
                 Department ="Engineering",
                 Expenses = new List<Expense>()
                 {
                    new Expense() { ExpenseType="Phone", ExpenseAmount=1000 }
                 }
               }
            };
        }

        private void View_Expences(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReport = new ExpenseReport(peopleListBox.SelectedItem);
            expenseReport.Height = this.Height + 100;
            expenseReport.Width = this.Width + 100;
            expenseReport.ShowDialog();
        }
       
    }
}
