using MvvmCross.Core.ViewModels;


namespace SimpleTest.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _firstName;
        private string _lastName;
           
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                RaisePropertyChanged(() => FullName);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}
