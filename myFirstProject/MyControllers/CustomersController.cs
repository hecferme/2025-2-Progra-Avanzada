using Microsoft.AspNetCore.Mvc;
using myFirstProject.Models;
using myFirstProject.Repository;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _repository;
    private const int MaxRecords = 5; // default max

    public CustomersController(ICustomerRepository repository)
    {
        _repository = repository;
    }

    // GET /Customers
    [HttpGet]
    public IEnumerable<Customer> Get([FromQuery] string name = null, [FromQuery] int? customerId = null, [FromQuery] int maxNumberOfRecords = MaxRecords)
    {
        maxNumberOfRecords = Math.Min(maxNumberOfRecords, MaxRecords); // enforce max

        if (customerId.HasValue)
        {
            var customer = _repository.GetById(customerId.Value);
            if (customer != null) return new[] { customer };
            return Enumerable.Empty<Customer>();
        }
        else if (!string.IsNullOrEmpty(name))
        {
            return _repository.QueryByName(name, maxNumberOfRecords);
        }
        else
        {
            return _repository.GetCustomers(maxNumberOfRecords);
        }
    }
}

