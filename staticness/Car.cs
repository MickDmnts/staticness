using System;

public class Car {
    int _MaxPassengers = 4;
    public int _Wheels = 4;
    string _Manufacturer = "Audi";

    public Car() {
        Car.KOK = "Geia sou";
    }

    public static string KOK = "ANABW ALARM KAI PAW OPOY GOYSTARW";

    public static void PrintKOK() {
        Console.WriteLine(Car.KOK);
    }
}

public class Maths {
    public int Sum(int lhs, int rhs) {
        return lhs + rhs;
    }
}
