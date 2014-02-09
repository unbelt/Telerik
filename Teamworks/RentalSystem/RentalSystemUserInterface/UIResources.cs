namespace RentalSystemUserInterface
{
    using System.Text.RegularExpressions;
    using System.Windows.Controls;
    using System.Windows.Media;

    public static class UIResources
    {
        public static SolidColorBrush RedBrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        public static SolidColorBrush GreenBrush = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        public static SolidColorBrush WhiteBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        public static System.Windows.Visibility Visible = System.Windows.Visibility.Visible;
        public static System.Windows.Visibility Hidden = System.Windows.Visibility.Hidden;

        public static bool NameValidate(TextBox sender, TextChangedEventArgs e)
        {
            Regex validName = new Regex("[a-zA-Z]{3,20}");

            if (sender.Text.Length == 0 || validName.IsMatch(sender.Text) || string.IsNullOrWhiteSpace(sender.Text))
            {
                sender.Background = WhiteBrush;
                return true;
            }
            else
            {
                sender.Background = RedBrush;
                return false;
            }
        }

        public static bool EGNValidate(TextBox sender, TextChangedEventArgs e)
        {
            int egn;

            if (sender.Text.Length == 10 || sender.Text.Length == 0 || string.IsNullOrWhiteSpace(sender.Text))
            {
                sender.Background = WhiteBrush;

                if (int.TryParse(sender.Text, out egn))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                sender.Background = RedBrush;
                return false;
            }
        }

        public static bool CityValidate(TextBox sender, TextChangedEventArgs e)
        {
            Regex validCity = new Regex("[a-zA-Z]{3,20}");

            if (sender.Text.Length == 0 || validCity.IsMatch(sender.Text) || string.IsNullOrWhiteSpace(sender.Text))
            {
                sender.Background = WhiteBrush;
                return true;
            }
            else
            {
                sender.Background = RedBrush;
                return false;
            }
        }

        public static bool AddressValidate(TextBox sender, TextChangedEventArgs e)
        {
            Regex validAddress = new Regex("[a-zA-Z]{5,20}");

            if (sender.Text.Length == 0 || validAddress.IsMatch(sender.Text) || string.IsNullOrWhiteSpace(sender.Text))
            {
                sender.Background = WhiteBrush;
                return true;
            }
            else
            {
                sender.Background = RedBrush;
                return false;
            }
        }

        public static bool PhoneValidate(TextBox sender, TextChangedEventArgs e)
        {
            int phone;

            if (sender.Text.Length > 5 || sender.Text.Length == 0 || string.IsNullOrWhiteSpace(sender.Text))
            {
                sender.Background = WhiteBrush;

                if (int.TryParse(sender.Text, out phone))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                sender.Background = RedBrush;
                return false;
            }
        }

        public static bool DLValidate(TextBox sender, TextChangedEventArgs e)
        {
            Regex validDL = new Regex("[a-zA-Z0-9]{6,20}");

            if (sender.Text.Length == 0 || validDL.IsMatch(sender.Text) || string.IsNullOrWhiteSpace(sender.Text))
            {
                sender.Background = WhiteBrush;
                return true;
            }
            else
            {
                sender.Background = RedBrush;
                return false;
            }
        }
    }
}