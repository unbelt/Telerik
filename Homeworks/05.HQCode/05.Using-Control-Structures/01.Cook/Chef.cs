using System;

/* 1. Refactor the class using best practices for organizing straight-line code. */

public class Chef
{
    public void Cook()
    {
        Carrot carrot = this.GetCarrot();
        this.Peel(carrot);
        this.Cut(carrot);

        Potato potato = this.GetPotato();
        this.Peel(potato);
        this.Cut(potato);

        Bowl bowl = this.GetBowl();
        this.bowl.Add(carrot);
        this.bowl.Add(potato);
    }

    private Carrot GetCarrot()
    {
        throw new NotImplementedException();
    }

    private Potato GetPotato()
    {
        throw new NotImplementedException();
    }

    private void Cut(Product product)
    {
        throw new NotImplementedException();
    }

    private void Peel(Product product)
    {
        throw new NotImplementedException();
    }

    private Bowl GetBowl()
    {
        throw new NotImplementedException();
    }
}