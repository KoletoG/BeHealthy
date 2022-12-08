namespace BeHealthy.Static_methods
{
    public static class Calculators
    {
        public static decimal BodyFatCalculator(decimal weight, decimal wrist, decimal waist, decimal hip, decimal forearm)
        {
            decimal lean = weight * 0.732m + 8.987m + wrist / 3.140m - waist * 0.157m - hip * 0.249m + forearm * 0.434m;
            decimal bfw = weight - lean;
            return bfw / weight;
        }
        public static decimal BodyFatCalculator(decimal weight, decimal waist)
        {
            decimal lean = weight * 1.082m + 94.42m - waist * 4.15m;
            decimal bfw = weight - lean;
            return bfw / weight;
        }
        public static double BMICalculator(double height, double weight)
        {
            return (weight / (height * height));
        }
        public static double CalorieCalculator(int age, bool male, double height, double weight, double activity)
        {
            if (male == true)
            {
                return (66 + (6.3 * weight) + (12.9 * height) - (6.8 * age)) * activity;
            }
            else
            {
                return (655 + (4.3 * weight) + (4.7 * height) - (4.7 * age)) * activity;
            }
        }
        public static decimal LBMCalculator(decimal weight, decimal wrist, decimal waist, decimal hip, decimal forearm)
        {
            return weight * 0.732m + 8.987m + wrist / 3.140m - waist * 0.157m - hip * 0.249m + forearm * 0.434m;

        }
        public static decimal LBMCalculator(decimal weight, decimal waist)
        {
            return weight * 1.082m + 94.42m - waist * 4.15m;
        }
    }
}
