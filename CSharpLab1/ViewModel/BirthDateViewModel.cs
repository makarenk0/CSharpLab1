using CSharpLab1.Model;
using CSharpLab1.Tools.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLab1.ViewModel
{
    public class BirthDateViewModel : INotifyPropertyChanged
    {
        #region Fields
        private User _user = new User();
        private RelayCommand<object> _enterCommand;


        #endregion

        #region Properties

        public DateTime BirthDate
        {
            get
            {
                return _user.BirthDate;
            }
            set
            {
                _user.BirthDate = value;   
            }
        }

        public int Age
        {
            get
            {
                return _user.Age;
            }
        }

        public String UserWesternZodiac
        {
            get
            {
                return _user.UserWesternZodiac;
            }
        }

        public RelayCommand<object> EnterCommand
        {
            get
            {
                return _enterCommand ?? (_enterCommand = new RelayCommand<object>(EnterInplementation,
                    o => CanExecuteCommand()));
            }
        }
        #endregion
        public bool CanExecuteCommand()
        {
            return (BirthDate)!=null;
        }


        private async void EnterInplementation(object obj)
        {
            await Task.Run(() => Thread.Sleep(1000));
            bool result = _user.processData();
            if (result)
            {

               OnPropertyChanged("Age");
               OnPropertyChanged("UserWesternZodiac");
            }
            else
            {
                MessageBox.Show($"You can`t be born in {BirthDate} !");
            }

            if (_user.todayBirthday())
            {
                MessageBox.Show($"Happy Birthday!");
            }
           
        }

        #region INotifyPropertyImplementation
        public event PropertyChangedEventHandler PropertyChanged;

       // [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
