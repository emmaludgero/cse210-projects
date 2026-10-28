using System;

class Doctor : Person
{
    private string _tools;
    public Doctor(string fName, string lName, int age, double weight, string tools)
    : base(fName, lName, age, weight)
    {
        _tools = tools;
    }

    public string GetDoctorInfo()
    {
        return $"Doctor: {GetPersonInfo()} Tools: {_tools}";
    }
}