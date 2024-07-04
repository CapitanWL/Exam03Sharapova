using System.Threading;

namespace Console_Exam_03_Sharapova.Models.Managers
{
    public class SmartphoneIdManager
    {
        private static int _smartphoneId = 0;

        public static int GetSmartphoneId()
        {
            return Interlocked.Increment(ref _smartphoneId);
        }
    }
}
