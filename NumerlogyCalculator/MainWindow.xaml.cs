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

namespace NumerlogyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i <= 31; i++)
            {
                this.DOB_Day.Items.Add(i);
            }

            this.NameAtBirth.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Result.Text = string.Empty;

            string nameAtBirth = this.NameAtBirth.Text.ToUpper().Trim();
            if (string.IsNullOrWhiteSpace(nameAtBirth))
            {
                MessageBox.Show("Please provide the name at birth.");
                return;
            }

            string currentName = this.CurrentName.Text.ToUpper().Trim();
            if (string.IsNullOrWhiteSpace(currentName))
            {
                MessageBox.Show("Please provide the current name.");
                return;
            }

            DateTime dateOfBirth;
            try
            {
                dateOfBirth = new DateTime(int.Parse(this.DOB_Year.Text), this.DOB_Month.SelectedIndex + 1, this.DOB_Day.SelectedIndex + 1);
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide a valid date of birth.");
                return;
            }

            Calculator calculator = new Calculator();
            StringBuilder bldr = new StringBuilder();
            bldr.AppendLine(string.Format("Name at birth : {0}", nameAtBirth));
            bldr.AppendLine(string.Format("Current name : {0}", currentName));
            bldr.AppendLine(string.Format("Date of birth : {0}", dateOfBirth.ToLongDateString()));
            bldr.AppendLine();
            bldr.AppendLine("Numbers :");

            const string karmicNumberString = " -- [Karmic Debt Number]";
            int number;
            bool karmicNumber;

            number = calculator.GetLifePathNumber(dateOfBirth, out karmicNumber);
            bldr.AppendLine(string.Format("Life Path Number = {0}{1}", number, karmicNumber ? karmicNumberString : ""));

            number = calculator.GetDestinyNumber(nameAtBirth, out karmicNumber);
            bldr.AppendLine(string.Format("Destiny Number = {0}{1}", number, karmicNumber ? karmicNumberString : ""));

            number = calculator.GetSoulNumber(nameAtBirth, out karmicNumber);
            bldr.AppendLine(string.Format("Soul Number = {0}{1}", number, karmicNumber ? karmicNumberString : ""));

            number = calculator.GetPersonalityNumber(nameAtBirth, out karmicNumber);
            bldr.AppendLine(string.Format("Personality Number = {0}{1}", number, karmicNumber ? karmicNumberString : ""));

            number = calculator.GetMaturityNumber(dateOfBirth, nameAtBirth, out karmicNumber);
            bldr.AppendLine(string.Format("Maturity Number = {0}{1}", number, karmicNumber ? karmicNumberString : ""));

            number = calculator.GetCurrentNameNumber(currentName, out karmicNumber);
            bldr.AppendLine(string.Format("Current Name Number = {0}{1}", number, karmicNumber ? karmicNumberString : ""));

            number = calculator.GetBirthDayNumber(dateOfBirth, out karmicNumber);
            bldr.AppendLine(string.Format("Birth Day Number = {0}{1}", number, karmicNumber ? karmicNumberString : ""));

            string karmicLessonNumber = string.Empty;
            List<int> karmicLessonNumbers = calculator.GetKarmicLessonNumber(nameAtBirth);
            foreach (int num in karmicLessonNumbers)
            {
                if (!string.IsNullOrEmpty(karmicLessonNumber))
                {
                    karmicLessonNumber += ", ";
                }

                karmicLessonNumber += num.ToString();
            }

            bldr.AppendLine(string.Format("Karmic Lesson Numbers = {0}", karmicLessonNumber));

            this.Result.Text = bldr.ToString();
        }
    }
}
