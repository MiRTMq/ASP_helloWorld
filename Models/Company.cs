class Company {
  public  string Name { get; set; }
  public  int StaffNumber { get; set; }
  public  string Occupation { get; set; }

  public Company(string name, int stuffNumber, string occupation) {
    Name = name;
    StaffNumber = stuffNumber;
    Occupation = occupation;
  }

    public override string ToString()
      {
          return $"Name: {Name}, \n Staff hired: {StaffNumber},\n Occupation: {Occupation}";
      }
}
