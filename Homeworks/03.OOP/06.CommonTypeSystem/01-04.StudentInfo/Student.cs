using System;
using System.ComponentModel;
using System.Linq;
using System.Text;

public enum Universities
{
    [Description("Software University, Sofia")]
    SoftwareUniversity,
    [Description("TechnicalUniversity of Denmark")]
    TechnicalUniversity,
    [Description("Scientology University, UK")]
    ScientologyUniversity,
}
public enum Faculties
{
    Agriculture,
    Arts,
    Business,
    Engineering,
    Medicine,
    Pharmacy,
    Science,
}
public enum Specialties
{
    [Description("Computer Science")]
    ComputerScience,
    Nanotechnology,
    [Description("Software Engineering")]
    SoftwareEngineering,
}

class Student : Person, IComparable<Student>, ICloneable
{
    public string SSN { get; private set; }
    public string Address { get; private set; }
    public ulong PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public string Course { get; private set; }
    public Universities Universities { get; set; }
    public Faculties Faculties { get; set; }
    public Specialties Specialties { get; set; }

    public Student(string firstName, string middleName, string lastName,
        string ssn, string address, ulong phone, string email, string course, Universities uni, Faculties fac, Specialties spec) :
        base(firstName, middleName, lastName, age: null)
    {
        this.SSN = ssn;
        this.Address = address;
        this.PhoneNumber = phone;
        this.Email = email;
        this.Course = course;
        this.Universities = uni;
        this.Faculties = fac;
        this.Specialties = spec;
    }

    public object Clone()
    {
        return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
            this.PhoneNumber, this.Email, this.Course, this.Universities, this.Faculties, this.Specialties);
    }

    public int CompareTo(Student other)
    {
        var compare = new Student[] { this, other }
            .OrderBy(student => student.FirstName)
            .ThenBy(student => student.MiddleName)
            .ThenBy(student => student.LastName)
            .ThenBy(studnet => studnet.SSN)
            .First().Equals(this);

        return compare ? -1 : 1;
    }

    public override bool Equals(object other)
    {
        return this.SSN == (other as Student).SSN;
    }

    public override int GetHashCode()
    {
        return this.SSN.GetHashCode();
    }

    public override string ToString()
    {
        var print = new StringBuilder();

        print.AppendFormat(@"{0} {1} {2}
            SSN: {3}
            Address: {4}
            Phone Number: {5}
            Email: {6}
            Course: {7}
            Universities: {8}
            Faculties: {9}
            Specialties: {10}",
            this.FirstName, this.MiddleName, this.LastName, this.SSN,
            this.Address, this.PhoneNumber, this.Email, this.PhoneNumber,
            this.Universities, this.Faculties, this.Specialties);

        return print.ToString();
    }
}