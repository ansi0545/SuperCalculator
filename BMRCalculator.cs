namespace Assignment3.CalculatorClasses
{
    internal class BmrCalculator
    {
        private double weight;
        private double height;
        private int age;
        private bool isMale;
        private double activityLevel;

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetIsMale(bool isMale)
        {
            this.isMale = isMale;
        }

        public bool GetIsMale()
        {
            return isMale;
        }

        public void SetActivityLevel(double activityLevel)
        {
            this.activityLevel = activityLevel;
        }

        public double GetActivityLevel()
        {
            return activityLevel;
        }

        public double GetBmr()
        {
            return CalculateBmr();
        }

        private double CalculateBmr()
        {
            double bmr = 0;
            if (isMale)
            {
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else
            {
                bmr = 10 * weight + 6.25 * height - 5 * age - 161;
            }
            return bmr;
        }
       
        public double CalculateMaintainWeightBmr()
        {
            return CalculateBmr() * activityLevel;
        }

        public double CalculateWeightChangeBmr(double weightChange)
        {
            return CalculateMaintainWeightBmr() + (7700 * weightChange / 7);
        }
    }
}