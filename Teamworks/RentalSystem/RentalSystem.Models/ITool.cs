namespace RentalSystem.Models
{
    using System;

    public interface ITool : IComparable<ITool>
    {
        string Name { get; set; }
    }
}