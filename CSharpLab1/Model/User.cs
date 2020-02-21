using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab1.Model
{
    class User
    {
        private int _age;
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
                _age = _birthDate.Year;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }
    }
}
