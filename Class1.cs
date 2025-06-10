using System;
using System.Globalization;

namespace PowerStruct
{
    public struct RealPower
    {
        private double _base;
        private double _exponent;

        public double Base
        {
            get => _base;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Основание степени должно быть положительным числом");
                _base = value;
            }
        }

        public double Exponent
        {
            get => _exponent;
            set => _exponent = value;
        }

        public double Value => Math.Pow(Base, Exponent);

        public RealPower(double baseValue, double exponent) : this()
        {
            Base = baseValue;
            Exponent = exponent;
        }

        public override string ToString() => 
            $"{_base.ToString("0.#####", CultureInfo.InvariantCulture)}E{_exponent.ToString("0.#####", CultureInfo.InvariantCulture)}";

        public override bool Equals(object obj)
        {
            if (obj is RealPower other)
            {
                return Math.Abs(Value - other.Value) < 1e-10;
            }
            throw new ArgumentException("Объект для сравнения не является степенью");
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(RealPower x, RealPower y) => x.Equals(y);
        public static bool operator !=(RealPower x, RealPower y) => !x.Equals(y);

        public static RealPower operator *(RealPower x, RealPower y)
        {
            if (Math.Abs(x.Base - y.Base) >= 1e-13)
                throw new ArgumentException("Умножение возможно только для степеней с одинаковыми основаниями");
            return new RealPower(x.Base, x.Exponent + y.Exponent);
        }

        public static RealPower operator /(RealPower x, RealPower y)
        {
            if (Math.Abs(x.Base - y.Base) >= 1e-13)
                throw new ArgumentException("Деление возможно только для степеней с одинаковыми основаниями");
            return new RealPower(x.Base, x.Exponent - y.Exponent);
        }
    }
}