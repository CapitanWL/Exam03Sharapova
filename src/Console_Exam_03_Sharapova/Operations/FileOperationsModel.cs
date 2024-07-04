using Console_Exam_03_Sharapova.Models;
using System;
using System.IO;

namespace Console_Exam_03_Sharapova.Operations
{
    public static class FileOperationsModel
    {
        private static readonly string path = @"D:\Users\stu-ipsp121\Desktop\Exam_03\Exam_03_Sharapova\Console_Exam_03_Sharapova\Results\result.txt";

        public static void WriteArrayToFile(SmartphoneModel[] smartphones)
        {
            using StreamWriter sw = new StreamWriter(path);

            try
            {

                foreach (var s in smartphones)
                {
                    sw.WriteLine("Идентификатор смартфона: " + s.SmartphoneId.ToString());
                    sw.WriteLine("Название модели смартфона: " + s.SmartphoneModelName.ToString());
                    sw.WriteLine("Стоимость смартфона: "  + s.SmartphonePrice.ToString());
                    sw.WriteLine("Диагональ смартфона: "  + s.SmartphoneDiagonal.ToString());
                    sw.WriteLine("\n");
                }

                Console.WriteLine("\nМассив отсортировани и успешно записан в файл!\n\n" +
                    "Путь к файлу: " + path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nОшибка записи в файл: " + ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
