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
using Restaurant_Bill_Calculator.Models;

namespace Restaurant_Bill_Calculator
{
    public partial class MainWindow : Window
    {
        public double sales_tax_rate = 0.0668d;

        public List<Models.MenuItem> list_beverages = new List<Models.MenuItem>();
        public List<Models.MenuItem> list_appetizers = new List<Models.MenuItem>();
        public List<Models.MenuItem> list_main_course = new List<Models.MenuItem>();
        public List<Models.MenuItem> list_dessert = new List<Models.MenuItem>();
        public List<Models.MenuItem> list_total_bill = new List<Models.MenuItem>();




        // ----    CONSTRUCTOR    ---- //
        public MainWindow()
        {
            InitializeComponent();

            // Add Beverages to list...
            list_beverages.Add(new Models.MenuItem { Name = "Soda", Price = 1.95d });
            list_beverages.Add(new Models.MenuItem { Name = "Tea", Price = 1.50d });
            list_beverages.Add(new Models.MenuItem { Name = "Coffee", Price = 1.25d });
            list_beverages.Add(new Models.MenuItem { Name = "Mineral Water", Price = 2.95d });
            list_beverages.Add(new Models.MenuItem { Name = "Juice", Price = 2.50d });
            list_beverages.Add(new Models.MenuItem { Name = "Milk", Price = 1.50d });

            // Add Appetizers to list...
            list_appetizers.Add(new Models.MenuItem { Name = "Buffalo Wings", Price = 5.95d });
            list_appetizers.Add(new Models.MenuItem { Name = "Buffalo Fingers", Price = 6.95d });
            list_appetizers.Add(new Models.MenuItem { Name = "Potato Skins", Price = 8.95d });
            list_appetizers.Add(new Models.MenuItem { Name = "Nachos", Price = 8.95d });
            list_appetizers.Add(new Models.MenuItem { Name = "Mushroom Caps", Price = 10.95d });
            list_appetizers.Add(new Models.MenuItem { Name = "Shrimp Cocktail", Price = 12.95d });
            list_appetizers.Add(new Models.MenuItem { Name = "Chips and Salsa", Price = 6.95d });

            // Add Main Courses to list...
            list_main_course.Add(new Models.MenuItem { Name = "Seafood Alfredo", Price = 15.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Chicken Alfredo", Price = 13.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Chicken Picatta", Price = 13.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Turkey Club", Price = 11.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Lobster Pie", Price = 19.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Prime Rib", Price = 20.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Shrimp Scampi", Price = 18.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Turkey Dinner", Price = 13.95d });
            list_main_course.Add(new Models.MenuItem { Name = "Stuffed Chicken", Price = 14.95d });

            // Add Desserts to list...
            list_dessert.Add(new Models.MenuItem { Name = "Apple Pie", Price = 5.95d });
            list_dessert.Add(new Models.MenuItem { Name = "Sundae", Price = 3.95d });
            list_dessert.Add(new Models.MenuItem { Name = "Carrot Cake", Price = 5.95d });
            list_dessert.Add(new Models.MenuItem { Name = "Mud Pie", Price = 4.95d });
            list_dessert.Add(new Models.MenuItem { Name = "Apple Crisp", Price = 5.95d });

            // Set ItemsSource for all Combo Boxes...
            beverage_ComboBox.ItemsSource = list_beverages;
            appetizer_ComboBox.ItemsSource = list_appetizers;
            mainCourse_ComboBox.ItemsSource = list_main_course;
            dessert_ComboBox.ItemsSource = list_dessert;

            TallyBill();
        }

        // ----    CLEAR BILL BUTTON    ---- //
        private void clearBill_Button_Click(object sender, RoutedEventArgs e)
        {
            ClearBill();
        }

        // ----    CLEAR BILL    ---- //
        private void ClearBill()
        {
            list_total_bill.Clear();
            foreach (var item in list_beverages) { item.Quantity = 1; }
            foreach (var item in list_appetizers) { item.Quantity = 1; }
            foreach (var item in list_main_course) { item.Quantity = 1; }
            foreach (var item in list_dessert) { item.Quantity = 1; }
            TallyBill();
        }

        // ----    TALLY UP BILL    ---- //
        private void TallyBill()
        {
            double total = 0d;

            bill_total_item_TextBlock.Text = string.Empty;
            bill_total_price_TextBlock.Text = string.Empty;

            foreach (var item in list_total_bill)
            {
                if(item.Quantity > 1)
                {
                    total += item.Price * item.Quantity;
                    bill_total_item_TextBlock.Text += $"{item.Name} ({item.Quantity})\n";
                    bill_total_price_TextBlock.Text += $"{item.Price * item.Quantity:C}\n";
                }
                else
                {
                    total += item.Price;
                    bill_total_item_TextBlock.Text += $"{item.Name}\n";
                    bill_total_price_TextBlock.Text += $"{item.Price:C}\n";
                }
            }

            // Set sub-total and taxes...
            sub_and_tax_TextBlock.Text = $"Sub-Total:\nTax ({sales_tax_rate * 100}%):";
            sub_and_tax_values_TextBlock.Text = $"{total:C}\n{total * sales_tax_rate:C}";

            // Set total...
            total_TextBlock.Text = "Total:";
            total_value_TextBlock.Text = $"{total + (total * sales_tax_rate):C}";
        }

        // ----    ADD: BEVERAGE    ---- //
        private void beverage_AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(beverage_ComboBox.Text)) { return; }

            Models.MenuItem new_item = (Models.MenuItem)beverage_ComboBox.SelectedItem;
            if(list_total_bill.Contains(new_item))
            {
                Models.MenuItem existing_item = list_total_bill.Find(x => x.Name == new_item.Name);
                existing_item.Quantity++;
            }
            else
            {
                list_total_bill.Add(new_item);
            }

            TallyBill();
        }

        // ----    ADD: APPETIZER    ---- //
        private void appetizer_AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(appetizer_ComboBox.Text)) { return; }

            Models.MenuItem new_item = (Models.MenuItem)appetizer_ComboBox.SelectedItem;
            if (list_total_bill.Contains(new_item))
            {
                Models.MenuItem existing_item = list_total_bill.Find(x => x.Name == new_item.Name);
                existing_item.Quantity++;
            }
            else
            {
                list_total_bill.Add(new_item);
            }

            TallyBill();
        }

        // ----    ADD: MAIN COURSE    ---- //
        private void mainCourse_AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(mainCourse_ComboBox.Text)) { return; }

            Models.MenuItem new_item = (Models.MenuItem)mainCourse_ComboBox.SelectedItem;
            if (list_total_bill.Contains(new_item))
            {
                Models.MenuItem existing_item = list_total_bill.Find(x => x.Name == new_item.Name);
                existing_item.Quantity++;
            }
            else
            {
                list_total_bill.Add(new_item);
            }

            TallyBill();
        }

        // ----    ADD: DESSERT    ---- //
        private void dessert_AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(dessert_ComboBox.Text)) { return; }

            Models.MenuItem new_item = (Models.MenuItem)dessert_ComboBox.SelectedItem;
            if (list_total_bill.Contains(new_item))
            {
                Models.MenuItem existing_item = list_total_bill.Find(x => x.Name == new_item.Name);
                existing_item.Quantity++;
            }
            else
            {
                list_total_bill.Add(new_item);
            }

            TallyBill();
        }
    }
}
