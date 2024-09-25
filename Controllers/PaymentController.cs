using LiveCoding.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiveCoding.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentController : ControllerBase
{
    [HttpPost]
    public async Task<string> InitiatePayment()
    {
        //when this route is called, initiate a payment using this documentation https://collection-docs.thunes.com/reference/create

        //for a faster integration, the DTOs are already provided in the project

        //if the request fails, return "failure"
        //on success, return the paymentUrl;

        // Your turn !
        var orderRequest = new PaymentOrderCreateRequest
        {
            //PaymentOrder = ...
        };

        return "failure";
    }
}