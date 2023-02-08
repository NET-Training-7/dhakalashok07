using System;
class Methods_Asssignments
{
    public double CalculateProductOfSquare(double first, double second)
    {
        double productSum=(first*first)*(second*second);
        return productSum;
    }

    public double CalculateCubeRoot(double number)
    {
        double cubeValue = Math.Cbrt(number);
        return cubeValue;
    }
    public float CalculateBMI(float weight, float height)
    {
    float heightInm=height*0.3048f;
    float bmi = (weight / ( heightInm*heightInm));
    return bmi;
    }
}