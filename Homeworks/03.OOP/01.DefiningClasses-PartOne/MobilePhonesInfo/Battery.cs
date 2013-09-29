using System;
using System.Text.RegularExpressions;

// 3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
public enum BatteryType
{
    LiIon,
    NiMH,
    NiCd,
}

public class Battery
{
    // Field
    private BatteryType batteryType;
    private string batteryModel;
    private double? batteryIdle;
    private double? batteryTalk;

    // Constructor
    public Battery(BatteryType type, string model, double? idle, double? talk)
    {
        this.batteryType = type;
        this.batteryModel = model;
        this.batteryIdle = idle;
        this.batteryTalk = talk;
    }

    public Battery(BatteryType batteryType, string model)
        : this(batteryType, model, null, null)
    {
    }

    public Battery(BatteryType type, string model, double? batteryIdle)
        : this(type, model, batteryIdle, null)
    {
    }

    // Properties
    public BatteryType Type
    {
        get { return batteryType; }
    }

    public string BatteryModel
    {
        get { return this.batteryModel; }
        set
        {
            if (value.Length > 35)
            {
                throw new ArgumentException("The battery model name is too long!");
            }
            if (value.Length < 1)
            {
                throw new ArgumentException("The battery model is too short!");
            }

            this.batteryModel = value;
        }
    }

    public double? HoursIdle
    {
        get { return this.batteryIdle; }
        set
        {
            if (!Regex.IsMatch(value.ToString(), "^[0-9]{1,450}$"))
            {
                throw new ArgumentException("Idle hours of the battery must be a positive number!");
            }

            this.batteryIdle = value;
        }
    }

    public double? HoursTalk
    {
        get { return this.batteryTalk; }
        set
        {
            if (!Regex.IsMatch(value.ToString(), "^[0-9]{1,450}$"))
            {
                throw new ArgumentException("Talk hours of the battery must be a positive number!");
            }

            this.batteryTalk = value;
        }
    }

    // Formatting
    public override string ToString()
    {
        return string.Format("Type: {0} \r\nModel: {1} \r\nIdle hours: {2,0:00}h \r\nTalk hours: {3,0:00}h",
                              this.batteryType, this.batteryModel, this.batteryIdle, this.batteryTalk);
    }
}