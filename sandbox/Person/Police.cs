using System;

class Police : Person
{
    private string _weapons;
    public Police(string fName, string lName, int age, double weight, string weapons)
    : base(fName, lName, age, weight)
    {
        _weapons = weapons;
    }

    public string GetPoliceInfo()
    {
        return $"Police: {GetPersonInfo()} Weapons: {_weapons}";
    }
}