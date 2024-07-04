using Console_Exam_03_Sharapova.Models.Messages;
using static System.Console;

namespace Console_Exam_03_Sharapova.Validations
{
    public class SmartphoneFieldsValidation
    {
        private static string _readlineField;

        #region array size

        public static int GetArraySize()
        {
            WriteLine("\nВведите размер массива смартфонов. Критерии:\n" +
                "\n\t 1) Целое число" +
                "\n\t 2) Больше нуля" +
                "\n\t 3) Меньше или равно 20\n");

            while (true)
            {
                _readlineField = ReadLine();

                if (string.IsNullOrWhiteSpace(_readlineField)
                    || !int.TryParse(_readlineField, out int result)
                    || result <= 0
                    || result > 20)
                {
                    OneMessageModel.Message();
                }
                else
                {
                    return result;
                }
            }
        }

        #endregion

        #region model name

        public static string GetModelName()
        {
            WriteLine("\nВведите модель сматрфона Критерии:\n" +
                "\n\t 1) Непустое значение \n");

            while (true)
            {
                _readlineField = ReadLine();

                if (string.IsNullOrWhiteSpace(_readlineField))
                {
                    OneMessageModel.Message();
                }
                else
                {
                    return _readlineField;
                }
            }
        }

        #endregion

        #region price

        public static decimal GetPrice()
        {
            WriteLine("\nВведите стоимость смартфона в российских рублях (culture=ru, вместо точки - запятая). Критерии:\n" +
                "\n\t 1) Положительное число" +
                "\n\t 2) Больше нуля" +
                "\n\t 3) Меньше или равно 100000 рублей" +
                "\n\t 4) Больше или равно 1000 рублей \n");

            while (true)
            {
                _readlineField = ReadLine();

                if (string.IsNullOrWhiteSpace(_readlineField)
                   
                    || !decimal.TryParse(_readlineField, out decimal result)
                    || result <= 0
                    || result > 100000
                    || result < 1000)
                {
                    OneMessageModel.Message();
                }
                else
                {
                    return result;
                }
            }
        }

        #endregion

        #region diagonal

        public static decimal GetDiagonal()
        {
            WriteLine("\nВведите диагональ смартфона. Критерии:\n" +
                "\n\t 1) Положительное число" +
                "\n\t 2) Больше нуля" +
                "\n\t 3) Меньше или равно 20" +
                "\n\t 4) Больше или равно 5\n");

            while (true)
            {
                _readlineField = ReadLine();

                if (string.IsNullOrWhiteSpace(_readlineField)

                    || !decimal.TryParse(_readlineField, out decimal result)
                    || result <= 0
                    || result < 5
                    || result > 20)
                {
                    OneMessageModel.Message();
                }
                else
                {
                    return result;
                }
            }
        }

        #endregion
    }
}
