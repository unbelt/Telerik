/* 8. Create a class Call to hold a call performed through a GSM.
      It should contain date, time, dialed phone number and duration (in seconds). */

using System;
using System.Collections.Generic;

class Call
{
    // Field
    private DateTime time;
    private int phoneNumber;
    private int duration;

    // Constructor
    public Call(DateTime date, int number, int duration)
    {
        this.time = date;
        this.phoneNumber = number;
        this.duration = duration;
    }

    // Properties
    public DateTime CallDate
    {
        get { return this.time; }
        set { this.time = value; }
    }

    public int PhoneNumber
    {
        get { return this.phoneNumber; }
        set { this.phoneNumber = value; }
    }

    public int Duration
    {
        get { return this.duration; }
        set { this.duration = value; }
    }

    // Formatting
    public override string ToString()
    {
        return string.Format("Date: {0} \r\nPhone Number: {1} \r\nDuration: {2} sec.",
                              this.time, this.phoneNumber, this.duration);
    }
}