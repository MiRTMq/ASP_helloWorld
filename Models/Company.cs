class Company {
  public  string Name { get; set; }
  public  int StuffNumber { get; set; }
  public  string Occupation { get; set; }

  public Company(string name, int stuffNumber, string occupation) {
    Name = name;
    StuffNumber = stuffNumber;
    Occupation = occupation;
  }

    public override string ToString()
      {
          return $"{Name}, {StuffNumber}, {Occupation}";
      }
}
