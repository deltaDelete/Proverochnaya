using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proverochnaya;
public class Iphone : Mobile
{
    public string CPU { get; private set; }

    public bool Refabrished { get; private set; }
    public int BatteryCharge { get; private set; }

    public Iphone(string model, string cpu, int ram, int storage, int cameraMp, uint battery, bool isRefab = false) : base("Apple", $"iPhone {model}", ram, storage, cameraMp)
    {
        CPU = cpu;
        Refabrished = isRefab;
        BatteryCharge = (int)battery;
    }

    public void DischargeBattery()
    {
        BatteryCharge--;
    }

    public void ChargeBattery()
    {
        BatteryCharge++;
    }

    public string GetBatteryPercents() => $"{BatteryCharge}%";
}
