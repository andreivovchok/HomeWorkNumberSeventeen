using System;

namespace HomeWorkNumberSeventeen
{
    public class Car
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Car(int age)
        {
            _age = age;
        }
    }
}
