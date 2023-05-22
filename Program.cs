using System;

class Car
{
    private string brand;
    private string model;
    private int year;

    public Car(string brand, string model,int year){
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    public void Start(){
        Console.WriteLine("The {0} {1} is started.",brand,model);
    }

    public void Stop(){
        Console.WriteLine("The {0} {1} is stopped",brand,model);
    }

    public void DisplayInfo(){
        Console.WriteLine("Brand: {0}",brand);
        Console.WriteLine("Model: {0}",model);
        Console.WriteLine("Year: {0}",year);
    }


}

class Program{
    static void Main(){
        Car myCar = new Car("Toyota","Corolla",2020);

        myCar.Start();
        myCar.DisplayInfo();
        myCar.Stop();
    }
}