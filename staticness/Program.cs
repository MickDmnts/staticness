using System;

public class Program {
    public static void Main(string[] _args) {
        new Program().Demo();
    }

    public void Demo() {
        Car myCar = new Car();
        int wheels = 6;
        new Program().SetWheelsExternal(wheels);
        Console.WriteLine(wheels);
    }

    public void SetWheelsExternal(int _wheels) {
        _wheels = 16;
    }
}
