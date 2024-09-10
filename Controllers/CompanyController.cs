using Microsoft.AspNetCore.Mvc;
public class CompanyController : Controller
{
    public String Show()
    {

        Company company = new Company("Bread Company", 1984, "Bakes bread");

        return company.Name;
    }
}
