using Console_Exam_03_Sharapova.Models;
using Console_Exam_03_Sharapova.Operations;
using Console_Exam_03_Sharapova.Validations;
using System;
System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");

// Author: Capitan

Console.WriteLine("\nВыполнила: Шарапова Е.В. ИПсп-121\n");
Console.WriteLine("\nЗадание: Описать тип (структуру или класс) Smartphone для хранения данных о смартфоне (свойства: модель - строка, цена - число, размер диагонали экрана - число). Создать класс GadgetFactory, в котором обеспечить хранение одномерного массива указателей (или ссылок) на экземпляры типа Smartphone (специфику языка программирования учесть самостоятельно). В классе GadgetFactory реализовать (в виде двух отдельных методов) алгоритм сортировки по убыванию (по сочетанию значений двух свойств в порядке убывания приоритета: «модель» и «размер диагонали экрана») и сохранение массива в файл. Формат файла выбрать самостоятельно. В главной функции создать объект класса GadgetFactory и заполнить массив в диалоговом режиме (предварительно запросив размер массива у пользователя). Далее отсортировать массив. Вывести результат в файл.\n");

            FileOperationsModel
                .WriteArrayToFile(SortOpertionsModel
                .SortSmartphoneModels(new GadgetFactory(SmartphoneFieldsValidation.GetArraySize())
                .SmartphoneModels));

