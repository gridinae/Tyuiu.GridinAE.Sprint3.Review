namespace Tyuiu.GridinAE.Sprint3.TaskReview.V10.Lib;

public class DataService
{
    public double[] GetValues(int lowerBound, int upperBound, int step)
    {
        static double Evaluate(int x) => (5 * x + 2.5) / (Math.Sin(x) + 3) + 2 * x + Math.Cos(x);

        uint arraySize = 0;
        for (int i = lowerBound; i <= upperBound; i += step)
            arraySize++;

        double[] values = new double[arraySize];
        for (int i = lowerBound; i <= upperBound; i += step)
        {
            values[i - lowerBound] = (Math.Round(Evaluate(i), 2));
        }
        return values;
    }
}
