using EpaycoSdk.Models;
using Microsoft.AspNetCore.Mvc;


namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : HomeController
    {
        [HttpGet]
        public CustomerListModel Get()
        {
            CustomerListModel customer = epayco.CustomerGetList();
            return customer;

        }

        [HttpGet("{customer_id}")]
        public CustomerFindModel Get(string customer_id)
        {
            CustomerFindModel customer = epayco.FindCustomer(customer_id);
            return customer;

        }

        [HttpPost]
        public CustomerCreateModel Post([FromBody] Models.Customer customerData)
        {
            CustomerCreateModel customer = epayco.CustomerCreate(
                customerData.token_card,
                customerData.name,
                customerData.last_name, 
                customerData.email,       
                customerData.is_default,
                customerData.city,
                customerData.address,
                customerData.phone,
                customerData.cell_phone
            );

            return customer;
        }

        [Route("delete-token")]
        [HttpPost]
        public CustomerTokenDeleteModel Post([FromBody] Models.CustomerDeleteToken data)
        {
            CustomerTokenDeleteModel customer = epayco.CustomerDeleteToken(
                data.franchise,
                data.mask,
                data.customer_id
            );
            return customer;
        }

        [HttpPut("{customer_id}")]
        public CustomerEditModel Put(string customer_id, [FromBody] string name)
        {
            CustomerEditModel customer = epayco.CustomerUpdate(customer_id, name);
            return customer;

        }

        [Route("add-default-card")]
        [HttpPost]
        public SetDefaultToken Post([FromBody] Models.defaultToken data)
        {
            SetDefaultToken customer = epayco.addDefaultCard(
                data.token,
                data.customer_id,
                data.franchise,
                data.mask);

            return customer;
        }

        [Route("add-new-card")]
        [HttpPost]
        public TokenMessage Post([FromBody] Models.newTokenCard data)
        {
            TokenMessage customer = epayco.addNewToken(
                data.token_card,
                data.customer_id);

            return customer;
        }
    }
}
