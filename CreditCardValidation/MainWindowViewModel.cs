using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validation.luhn10;

namespace CreditCardValidation
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Fields

        private bool _aboutFlyout;
        public bool AboutFlyout
        {
            get
            {
                return _aboutFlyout;
            }
            set
            {
                if (_aboutFlyout == value)
                    return;

                _aboutFlyout = value;
                OnPropertyChanged("AboutFlyout");
            }
        }

        private string _validationNumber;
        public string ValidationNumber
        {
            get
            {
                if (_validationNumber == null)
                    _validationNumber = "";

                return _validationNumber;
            }
            set
            {
                _validationNumber = value;
                OnPropertyChanged("ValidationNumber");
            }
        }

        private string _validationMessage;
        public string ValidationMessage
        {
            get
            {
                if (_validationMessage == null)
                    _validationMessage = "";

                return _validationMessage;
            }
            private set
            {
                _validationMessage = value;
                OnPropertyChanged("ValidationMessage");
            }
        }

        private string _calculateNumber;
        public string CalculateNumber
        {
            get
            {
                if (_calculateNumber == null)
                    _calculateNumber = "";

                return _calculateNumber;
            }
            set
            {
                _calculateNumber = value;
                OnPropertyChanged("CalculateNumber");
            }
        }

        private string _checkDigitNumber;
        public string CheckDigitNumber
        {
            get
            {
                if (_checkDigitNumber == null)
                    _checkDigitNumber = "?";

                return _checkDigitNumber;
            }
            set
            {
                _checkDigitNumber = value;
                OnPropertyChanged("CheckDigitNumber");
            }
        }

        private string _calculateMessage;
        public string CalculateMessage
        {
            get
            {
                if (_calculateMessage == null)
                    _calculateMessage = "";

                return _calculateMessage;
            }
            set
            {
                _calculateMessage = value;
                OnPropertyChanged("CalculateMessage");
            }
        }

        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
        }

        #endregion

        #region Events

        internal void AboutButtonClicked()
        {
            AboutFlyout = !AboutFlyout;
        }

        internal void ValidateButtonClicked()
        {
            IValidationAlgorithm validation = new Luhn10();

            bool result = validation.Validate(_validationNumber);

            if (result == true)
            {
                ValidationMessage = "Validation successful";
            }
            else
            {
                ValidationMessage = "Validation failed";
            }
        }

        internal void ValidationFieldModified()
        {
            ValidationMessage = "";
        }

        internal void CalculateButtonClicked()
        {
            IValidationAlgorithm calculator = new Luhn10();

            int checkDigit = calculator.CalculateCheckDigit(CalculateNumber);

            if (checkDigit < 0)
            {
                CheckDigitNumber = "?";
                CalculateMessage = "Calculation failed";
            }
            else
            {
                CheckDigitNumber = checkDigit.ToString();
                CalculateMessage = "Calculation successful";
            }
        }

        internal void CalculateFieldModified()
        {
            CalculateMessage = "";
            CheckDigitNumber = "?";
        }

        #endregion

        #region IPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion
    }
}
