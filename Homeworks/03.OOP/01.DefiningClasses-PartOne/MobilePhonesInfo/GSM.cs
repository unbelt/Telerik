/* 1. Define a class that holds information about a mobile phone device:
      model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk)
      and display characteristics (size and number of colors). Define 3 separate classes
      (class GSM holding instances of the classes Battery and Display). */

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

public class GSM
{
    // Field
    public Battery batteryType = new Battery(BatteryType.LiIon, null, null);
    public Display displayType = new Display(null, null);

    private readonly float pricePerMinute = 0.37f;

    private string phoneModel;
    private string phoneManufacturer;
    private double? phonePrice;
    private string phoneOwner;

    // 9. Add a property CallHistory in the GSM class to hold a list of the performed calls.
    private List<Call> callHistory = new List<Call>(); // Try to use the system class List<Call>.

    // 6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S. 
    static private GSM iPhone = new GSM("IPhone", "Apple", 650, "Gosho");

    public static GSM IPhone
    {
        get { return iPhone; }
    }

    /* 2. Define several constructors for the defined classes that take different sets of arguments 
          (the full information for the class or part of it). Assume that model and manufacturer are mandatory
          (the others are optional). All unknown data fill with null. */
    public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
    {
        this.phoneModel = model;
        this.phoneManufacturer = manufacturer;
        this.phonePrice = price;
        this.phoneOwner = owner;
        this.batteryType = battery;
        this.batteryType = battery;
    }
    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null, null, null)
    {
    }
    public GSM(string model, string manufacturer, double? price)
        : this(model, manufacturer, price, null, null, null)
    {
    }
    public GSM(string model, string manufacturer, double? price, string owner)
        : this(model, manufacturer, price, owner, null, null)
    {
    }

    /* 5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
          Ensure all fields hold correct data at any given time. */
    public string Model
    {
        get { return this.phoneModel; }
        set
        {
            // Simple validation
            if (value.Length > 25)
            {
                throw new ArgumentException("The phone model can't be longer than 25 characters!");
            }

            if (value.Length <= 1)
            {
                throw new ArgumentException("The phone model must be more than 1 characters!");
            }

            this.phoneModel = value;
        }
    }

    public string Manufacturer
    {
        get { return this.phoneManufacturer; }
        set
        {
            // More complex validation
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The manufacturer cannot be empty!");
            }

            if (value.Length < 2)
            {
                throw new ArgumentException("The manufacturer cannot be less than 2 characters!");
            }

            if (value.Length > 25)
            {
                throw new ArgumentException("The manufacturer must be shorter!");
            }

            this.phoneManufacturer = value;
        }
    }

    public double? Price
    {
        get { return this.phonePrice; }
        set
        {
            // Regex validation
            if (Regex.IsMatch(value.ToString(), @"^\d{0,8}(\.\d{1,2})?$"))
            {
                throw new ArgumentException("The price is not in a valid format!");
            }

            if (value <= 0)
            {
                throw new ArgumentException("There ain't no such thing as a free lunch!");
            }

            this.phonePrice = value;
        }
    }

    public string Owner
    {
        get { return this.phoneOwner; }
        set
        {
            // Regex validation
            if (!Regex.IsMatch(value, "w{2-25}"))
            {
                throw new ArgumentException("The owner name must be between 2 and 25 characters and contain only letters!");
            }

            this.phoneOwner = value;
        }
    }

    // 10. Add methods in the GSM class for adding and deleting calls from the calls history.
    public void AddCall(DateTime time, int number, int duration)
    {
        Call call = new Call(time, number, duration);
        callHistory.Add(call);
    }

    public void DeleteCall(int callToRemove)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == callToRemove)
            {
                callHistory.RemoveAt(i);
            }
        }
    }

    // 10.1 Add a method to clear the call history.
    public void ClearHistory()
    {
        callHistory.Clear();
    }

    /* 11. Add a method that calculates the total price of the calls in the call history.
           Assume the price per minute is fixed and is provided as a parameter. */
    public float CallPrice(float callPrice)
    {
        int minCount = 0;
        int totalCallDuration = 0;

        for (int i = 0; i < callHistory.Count; i++)
        {
            totalCallDuration += callHistory[i].Duration;
        }

        while (totalCallDuration > 0)
        {
            totalCallDuration -= 60;
            minCount++;
        }

        callPrice = minCount * pricePerMinute;

        return callPrice;
    }

    public void PrintHistory()
    {
        StringBuilder history = new StringBuilder();

        foreach (var call in callHistory)
        {
            history.AppendFormat("Date: {0}, Number: {1}, Duration: {2}\r\n", call.CallDate, call.PhoneNumber, call.Duration);
        }

        Console.WriteLine(history);
    }

    // 4. Add a method in the GSM class for displaying all information about it. Try to override ToString().
    public override string ToString()
    {
        return string.Format("Model: {0} \r\nManufacturer {1} \r\nPrice: {2:C2} \r\nOwner: {3}",
                              this.phoneModel, this.phoneManufacturer, this.phonePrice.ToString() ?? "[unknown]", this.phoneOwner ?? "[unknown]");
    }
}