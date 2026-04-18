
using System;


class clsUtill
{
    public static double GetRandomTemperature(double min, double max)
    {
        Random random = new Random();
        return random.NextDouble() * (max - min) + min;
    }
}

class TemperatureChangeEventArgs : EventArgs
{
    public double OldTemperature { get;}
    public double NewTemperature { get; }
    public double Difference { get {return Math.Abs(OldTemperature - NewTemperature); } }

    public TemperatureChangeEventArgs(double oldTemperature, double newTemperature)
    {
        OldTemperature = oldTemperature;
        NewTemperature = newTemperature;
    }


}
class clsTemperatureSensor
{
    private double _OldTemperature;
    private double _CurrentTemperature;


    public event EventHandler<TemperatureChangeEventArgs> TemperatureChanged;

    public void SetTemperature(double newTemperature)
    {
        if (_CurrentTemperature != newTemperature)
        {
            _OldTemperature = _CurrentTemperature;
            _CurrentTemperature = newTemperature;
            OnTemperatureChanged(_OldTemperature, _CurrentTemperature);
        }
    }

    private void OnTemperatureChanged(double oldTemperature, double newTemperature)
    {
        OnTemperatureChanged(new TemperatureChangeEventArgs(oldTemperature, newTemperature));
    }

    protected virtual void OnTemperatureChanged(TemperatureChangeEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }

}
class clsScreen
{
    public void RegisterTemperaturesensor(clsTemperatureSensor sensor)
    {
        sensor.TemperatureChanged += Sensor_TemperatureChanged;
    }

    private void Sensor_TemperatureChanged(object sender, TemperatureChangeEventArgs e)
    {
        Console.WriteLine($"\n\t\t\t\t\t\tTemperature Information");
        Console.WriteLine($"Old Temprature: {e.OldTemperature}");
        Console.WriteLine($"New Temprature: {e.NewTemperature}");
        Console.WriteLine($"Temperature Difference: {e.Difference}");
    }

}

class program
{
    static void Main()
    {
        clsTemperatureSensor sensor = new clsTemperatureSensor();
        clsScreen screen = new clsScreen();
        screen.RegisterTemperaturesensor(sensor);


        while (true)
        {
            System.Threading.Thread.Sleep(5000);
            double newTemperature = clsUtill.GetRandomTemperature(-15, 35);
            sensor.SetTemperature(newTemperature);
        }

    }
}
