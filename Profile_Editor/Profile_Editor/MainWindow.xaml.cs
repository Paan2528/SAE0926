using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Profile_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static class ValidatorExtensions { 
            public static bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    
                    return false;

                }
            }

        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;

            bool email_check = ValidatorExtensions.IsValidEmail(EmailTextBox.Text);

                if (email_check == false)
                {
                    MessageBox.Show("Invalid email address");
                EmailTextBox.Focus();
                return;
               
                }
            string adress = AddressTextBox.Text;
            int number = 0;

            bool isNumber = int.TryParse(NumberTextBox.Text, out number);
            if (!isNumber)
            {
                MessageBox.Show("Invalid phone number. Please enter a valid integer."); 
            NumberTextBox.Focus();
                return;
            }


            string result_message_Name = $"Name: {name}";
            string result_message_Email = $"E-Email: {email} ";
            string result_message_Adress = $"Address: {adress}";
            string result_message_Number = $"Phone Number: {number}";
            


            TextResult_Name.Text = result_message_Name;
            TextResult_Email.Text = result_message_Email;
            TextResult_Address.Text = result_message_Adress;
            TextResult_Number.Text = result_message_Number;
            TextResult_successfully.Text = "Profile updated successfully!";


        }
    }
}