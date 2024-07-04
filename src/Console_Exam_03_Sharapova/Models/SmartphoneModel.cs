using Console_Exam_03_Sharapova.Models.Managers;

namespace Console_Exam_03_Sharapova.Models
{
    public class SmartphoneModel
    {
        private int _smartphoneId;

        public int SmartphoneId
        {
            get { return _smartphoneId; }
            set { _smartphoneId = value; }
        }


        private string _smartphoneModel;
        public string SmartphoneModelName
        {
            get { return _smartphoneModel; }
            set { _smartphoneModel = value; }
        }

        private decimal _smartphonePrice;

        public decimal SmartphonePrice
        {
            get { return _smartphonePrice; }
            set { _smartphonePrice = value; }
        }

        private decimal _smartphoneDiagonal;

        public decimal SmartphoneDiagonal
        {
            get { return _smartphoneDiagonal; }
            set { _smartphoneDiagonal = value; }
        }

        public SmartphoneModel()
        {
            SmartphoneId = SmartphoneIdManager.GetSmartphoneId();
        }
    }
}
