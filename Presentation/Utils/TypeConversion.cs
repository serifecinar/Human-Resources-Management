using System;
using System.Windows.Forms;

namespace Presentation.Utils
{
    public static class TypeConversion
    {
        public static DateTime? GetValidDate(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && DateTime.TryParse(textBox.Text, out DateTime result))
            {
                return result;
            }

            return null;
        }
        public static DateTime? GetValidDate(DateTimePicker dateTimePicker)
        {
            if (!string.IsNullOrWhiteSpace(dateTimePicker.Text) && DateTime.TryParse(dateTimePicker.Text, out DateTime result))
            {
                return result;
            }

            return null;
        }

        public static int GetValidInt(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && int.TryParse(textBox.Text, out int result))
            {
                return result;
            }

            return 0;
        }

        public static double GetValidDouble(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && double.TryParse(textBox.Text, out double result))
            {
                return result;
            }

            return 0.0;
        }
    }
}
