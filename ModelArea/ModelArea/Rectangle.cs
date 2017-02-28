﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    public class Rectangle : IForm
    {
        private double _sideA;
        private double _sideB;

        

        public Rectangle(double sideA, double sideB)
        {
            if (sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentOutOfRangeException($"Стороны не могут быть длиной меньше 0");
            }
            else
            {
                _sideA = sideA;
                _sideB = sideB;
            }
        }
        public FormType GetType
        {
            get
            {
                return FormType.Rectangle;
            }
        }

        public double SetSideA
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны не может быть меньше либо равна 0");
                }
                else
                {
                    _sideA = value;
                }
            }
        }
        public double SetSideB
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны не может быть меньше либо равна 0");
                }
                else
                {
                    _sideB = value;
                }
            }
        }

        public double GetLength
        {
            get
            {
                return (_sideA + _sideB) * 2;
            }
        }
        public double GetArea
        {
            get
            {
                return _sideA * _sideB;
            } 
        }

       
    }
}
