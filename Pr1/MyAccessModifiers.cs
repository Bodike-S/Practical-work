using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class MyAccessModifiers
    {
        private int birthYear;
        protected string personalInfo;
        private protected string idNumber;
        public MyAccessModifiers(int _birthYear, string _idNumber, string _personalInfo)
        {
            birthYear = _birthYear;
            personalInfo = _personalInfo;
            idNumber = _idNumber;
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthYear;
            }
        }
        public static byte averageMiddleAge = 50;
        internal string Name
        {
            get;set;
        }
        public string NickName
        {
            get;
            internal set;
        }
        protected internal bool HasLivedHalfOfLife(MyAccessModifiers obj)
        {
            if (obj.Age == averageMiddleAge)
                return true;
            else
                return false;
        }
        public static bool operator==(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return obj1.Name.Equals(obj2.Name) && obj1.Age.Equals(obj2.Age) && obj1.personalInfo.Equals(obj2.personalInfo);
        }
        public static bool operator!=(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return obj1.Name.Equals(obj2.Name) && obj1.Age.Equals(obj2.Age) && obj1.personalInfo.Equals(obj2.personalInfo);
        }
    }
}
