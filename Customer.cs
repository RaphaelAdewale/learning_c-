using System;

public struct Customer
{
    // Private fields
    private int _id;
    private string _Name;

    // Public Properties
    public int Id
    {
        set
        {
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
    public string Name
    {
        set
        {
            this._Name = value;
        }
        get
        {
            return this._Name;
        }
    }

    // Constructor
    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._Name = Name;
    }

    // Method to print id and name
    public void PrintDetails()
    {
        Console.WriteLine($"My name is {Name} and my identity number is {Id}");
    }

}