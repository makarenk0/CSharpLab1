using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLab1.Model
{
    class User
    {
        private int _age;
        private DateTime _birthDate;
        private string _userWesternZodiac;
        private string _userChineseZodiac;

        private string[] WesternZodiac = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
        private string[] ChineseZodiac = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };


        public User()
        {
            _birthDate = System.DateTime.UtcNow;
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public string UserWesternZodiac
        {
            get
            {
                return _userWesternZodiac;
            }
        }

        public string UserChineseZodiac
        {
            get
            {
                return _userChineseZodiac;
            }
        }


        public bool processData()
        {
            _age = System.DateTime.UtcNow.Year - _birthDate.Year;
            if (System.DateTime.UtcNow < _birthDate || Age > 135)
            {
                return false;
            }

            #region WesternZodiac
            uint wzodiac = (uint)(_birthDate.DayOfYear / 30);
            if (wzodiac == 0 && (_birthDate.DayOfYear < 21 || _birthDate.DayOfYear > 23))
            {
                wzodiac = 11;  // Sagittarius
            }
            _userWesternZodiac = WesternZodiac[wzodiac];
            #endregion

            #region ChineseZodiac
            uint chzodiac = (uint)((_birthDate.Year-1900) % 12);
            _userChineseZodiac = ChineseZodiac[chzodiac];
            #endregion

            return true;
        }

        public bool todayBirthday()
        {
            return System.DateTime.UtcNow.Date == _birthDate.Date;
        }
    }
}
