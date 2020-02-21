using CSharpLab1.Model;
using CSharpLab1.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSharpLab1.ViewModel
{
    class BirthDateViewModel : INotifyPropertyChanged
    {
        #region Fields
        private User _user = new User();
        private RelayCommand<object> _enterCommand;

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Properties

        #endregion
    }
}
