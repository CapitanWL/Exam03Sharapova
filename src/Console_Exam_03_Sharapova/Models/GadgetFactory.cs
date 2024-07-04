using Console_Exam_03_Sharapova.Validations;

namespace Console_Exam_03_Sharapova.Models
{
    public class GadgetFactory
    {
        private int _arraySize;

        private SmartphoneModel[] _smartphoneModels;

        public SmartphoneModel[] SmartphoneModels
        {
            get { return _smartphoneModels; }
            set { _smartphoneModels = value; }
        }

        public GadgetFactory(int size)
        {
            _arraySize = size;

            SmartphoneModels = new SmartphoneModel[_arraySize];

            FillArray();
        }

        private void FillArray()
        {
            for (int i = 0; i < _smartphoneModels.Length; i++)
            {
                _smartphoneModels[i] = new SmartphoneModel();

                _smartphoneModels[i].SmartphoneModelName = SmartphoneFieldsValidation.GetModelName();
                _smartphoneModels[i].SmartphonePrice = SmartphoneFieldsValidation.GetPrice();
                _smartphoneModels[i].SmartphoneDiagonal = SmartphoneFieldsValidation.GetDiagonal();
            }
        }
    }
}
