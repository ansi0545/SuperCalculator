
using Assignment3;
namespace Assignment3.CalculatorClasses
{

    internal class BmiCalculator
    {
        private double weight;
        private double height;
        private string name;
        private Assignment3.UnitTypes unit;
        



        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }
        public double GetWeight()
        {
            return this.weight;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return this.height;
        }

        public void SetUnit(UnitTypes unit)
        {
            this.unit = unit;
        }
        public UnitTypes GetUnit()
        {
            return this.unit;
        }

        public double GetBmi()
        {
            return CalculateBmi();
        }

        private double CalculateBmi()
        {
            double factor = unit == UnitTypes.Metric ? 1 : 703;
            return weight / (height * height) * factor;
        }

        public string GetBmiCategory()
        {
            double bmi = CalculateBmi();
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 24.9) return "Normal weight";
            else if (bmi < 29.9) return "Overweight";
            else return "Obesity";
        }

        public string GetNormalWeightLimits()
        {
            double factor = unit == UnitTypes.Metric ? 1 : 703;
            double lowWeight = height * height / factor * 18.5;
            double highWeight = height * height / factor * 24.9;
            return $"Normal weight limits: {lowWeight:0.00} - {highWeight:0.00}";
        }
    }

}