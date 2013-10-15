using System;
/* 8. Read in MSDN about the keyword event in C# and how to publish events.
      Re-implement the above using .NET events and following the best practices. */

public class Events : EventArgs
{
    private string message;

    public string Message
    {
        get { return message; }
        set { message = value; }
    }

    public Events(string s)
    {
        message = s;
    }

    class Publisher
    {
        public void ExecuteEvent()
        {
            Raise(new Events("Event test!"));
        }

        protected virtual void Raise(Events e)
        {
            Console.WriteLine(e.message);
            e.message += String.Format(" at {0}", DateTime.Now.ToString());
        }
    }

    static void Main()
    {
        Publisher pub = new Publisher();
        pub.ExecuteEvent();
    }
}