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
        // private WesternZodiac _userWesternZodiac;

        private string[] WesternZodiac = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };

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


        public bool processData()
        {
            _age = System.DateTime.UtcNow.Year - _birthDate.Year;
            if (System.DateTime.UtcNow < _birthDate || Age > 135)
            {
                return false;
            }

            uint zodiac = (uint)(_birthDate.DayOfYear / 30);
            if (zodiac == 0 && (_birthDate.DayOfYear < 21 || _birthDate.DayOfYear > 23))
            {
                zodiac = 11;  // Sagittarius
            }
            _userWesternZodiac = WesternZodiac[zodiac];



            return true;
        }

        public bool todayBirthday()
        {
            return System.DateTime.UtcNow.Date == _birthDate.Date;
        }
    }
}
