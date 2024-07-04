using Console_Exam_03_Sharapova.Models;
using System.Linq;

namespace Console_Exam_03_Sharapova.Operations
{
    public static class SortOpertionsModel
    {
        public static SmartphoneModel[] SortSmartphoneModels(SmartphoneModel[] smartphones)
        {
           return smartphones.OrderByDescending(s => s.SmartphoneModelName)
                .ThenByDescending(s => s.SmartphoneDiagonal)
                .ToArray();
        }
    }
}
