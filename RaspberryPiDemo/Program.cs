using System.Device.Gpio;

Console.WriteLine("Blinking LED. Press Ctrl+C to end.");
var pin = 18;

using var controller = new GpioController();
var openedPin = controller.OpenPin(pin, PinMode.Output);
var ledOn = true;
while (true)
{
    openedPin.Write(((ledOn) ? PinValue.High : PinValue.Low));
    // controller.Write(pin, ((ledOn) ? PinValue.High : PinValue.Low));
    await Task.Delay(1000);
    ledOn = !ledOn;
}