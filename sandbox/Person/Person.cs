using System;

class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private double _weight;

    public Person(string fName, string lName, int age, double weight)
    {
        _firstName = fName;
        _lastName = lName;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInfo()
    {
        return $"{_firstName} {_lastName} is {_age} years old and weights {_weight} pounds.";
    }
}