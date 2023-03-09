using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
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

namespace finalgeneric
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbcntry.Items.Add("India");
            cmbcntry.Items.Add("Japan");
            cmbcntry.Items.Add("Africa");
            cmbcntry.Items.Add("Pakistan");


        }
        List<details> odetail;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hashtable hs = new Hashtable();
            // hs.Add("IN", "India");
            // hs.Add("JAP", "Japan");
            // hs.Add("AFR", "Africa");
            // hs.Add("PAK", "Pakistan");
            // cmbcntry.Items.Add(hs);

            //// cmbcntry.ItemsSource = null;
            // //cmbcntry.ItemsSource = hs;
            // cmbcntry.DisplayMemberPath = "Value";
            // //cmbcntry.SelectedValuePath = "Value";


            //string agerex = "^[0-9]+$";
            //string age1 = txtage.Text;
            //bool val = Regex.IsMatch(age1, agerex);

            if (txtname.Text != "" && pswd.Password != "")
            {
                if (odetail == null)
                {
                    odetail = new List<details>();
                }
                details info = new details();
                info.name = txtname.Text;
                info.age = Convert.ToInt32(txtage.Text);
                info.password = pswd.Password;
                info.country = cmbcntry.Text;
                info.state = cmbsta.Text;
                odetail.Add(info);

                MessageBoxResult res = MessageBox.Show("Registered Successfully", "Success", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                if (res == MessageBoxResult.OK)
                {
                    txtname.Clear();
                    txtage.Clear();
                    pswd.Clear();
                    cmbcntry.SelectedItem = null;
                    cmbsta.Items.Clear();


                }
            }
            else
            {
                MessageBox.Show("Fill All Mandatory fields", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

           
            //for(int i=0;i< odetail.Count;i++)
           // {
           //     if (odetail[i].name.Contains(txtsname.Text))
           //         sname.Text = odetail[i].name;
           //         sage.Text =odetail[i].age.ToString();
           //         spswd.Text = odetail[i].password;
           //         scntry.Text = odetail[i].country;
           //         sstate.Text = odetail[i].state;
           // }

            foreach(var item in odetail)
            {
                if(item.name== txtsname.Text)
                {
                    //MessageBox.Show(item.password);
                    stk1.Visibility = Visibility.Visible;
                           sname.Text = item.name;
                            sage.Text = item.age.ToString();
                            spswd.Text = item.password;
                            scntry.Text = item.country;
                            sstate.Text = item.state;
                }
                //else
                //{
                   
                //    MessageBox.Show("No records found","Error",MessageBoxButton.OKCancel,MessageBoxImage.Error);
                //}
            }
        }

        private void cmbcntry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbcntry.SelectedItem == "India")
            {
               // cmbcntry.DisplayMemberPath = "india";
                cmbsta.Items.Clear();
                cmbsta.Items.Add("Tamil Nadu");
                cmbsta.Items.Add("Kerala");
                cmbsta.Items.Add("Karnataka");
                cmbsta.Items.Add("Andra Pradesh");
            }
            else if (cmbcntry.SelectedItem == "Japan")
            {
               //cmbcntry.Text = "Japan";
                cmbsta.Items.Clear();
                cmbsta.Items.Add("Kagoshima");
                cmbsta.Items.Add("Miyagi");
                cmbsta.Items.Add("Toyama");
                cmbsta.Items.Add("Aichi");
            }
            else if (cmbcntry.SelectedItem == "Africa")
            {
               // cmbcntry.Text= "Africa";
                cmbsta.Items.Clear();
                cmbsta.Items.Add("Nigeria");
                cmbsta.Items.Add("Egypt");
                cmbsta.Items.Add("Tanzania");
                cmbsta.Items.Add("Ethiopia");
            }
            else if (cmbcntry.SelectedItem == "Pakistan")
            {
               // cmbcntry.Text = "Pakistan";
                cmbsta.Items.Clear();
                cmbsta.Items.Add("Sindhu");
                cmbsta.Items.Add("Azad Kashmir");
                cmbsta.Items.Add("Khyber");
                cmbsta.Items.Add("Balochistan");
            }

        }
    }
    public class details
    {
        public String name;
        public int age;
        public String password;
        public String country;
        public String state;
    }
}
