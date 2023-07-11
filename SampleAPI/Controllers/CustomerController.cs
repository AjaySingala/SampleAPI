﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Entities;
using SampleAPI.Repositories;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerRepository _repo;

        public CustomerController()
        {
            _repo = new CustomerRepository();
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _repo.Get();
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _repo.Get(id);
        }
    }
}
