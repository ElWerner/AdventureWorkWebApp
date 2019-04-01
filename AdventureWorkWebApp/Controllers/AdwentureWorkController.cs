using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorkWebApp.Models;
using AdventureWorkWebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorkWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdwentureWorkController : Controller
    {
        private IDimAccountService _service;

        public AdwentureWorkController(IDimAccountService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DimAccount>> GetDimCustomerById(int id)
        {
            DimAccount customer = await _service.GetDimCustomerByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        /// <remarks>
        /// Sample request:
        ///
        ///     POST /DimAccount
        ///      {
        ///          "parentAccountKey": null,
        ///          "accountCodeAlternateKey": null,
        ///          "parentAccountCodeAlternateKey": null,
        ///          "accountDescription": "string",
        ///          "accountType": "string",
        ///          "operator": "string",
        ///          "customMembers": "string",
        ///          "valueType": "string",
        ///          "customMemberOptions": "string"
        ///      }
        ///
        /// </remarks>
        [HttpPost]
        [ProducesResponseType(typeof(DimAccount), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DimAccount>> AddDimCustomer(DimAccount customer)
        {
            await _service.AddDimCustomerAsync(customer);

            return CreatedAtAction(nameof(GetDimCustomerById), new { id = customer.AccountKey }, customer);
        }
    }
}