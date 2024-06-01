using System.Threading;
using nanoFramework.Hardware.Esp32;
using System.Device.Gpio;

public class Program
{
    public static void Main()
    {
        int ledPin = 2; // Pin GPIO para el LED en una ESP32, puede variar según tu dispositivo
        GpioController gpio = new GpioController();
        gpio.OpenPin(ledPin, PinMode.Output);

        while(true)
        {
            gpio.Write(ledPin, PinValue.High);
            Thread.Sleep(500);
            gpio.Write(ledPin, PinValue.Low);
            Thread.Sleep(500);
        }
    }
}
