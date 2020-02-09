﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CRL.DataModel.Entities;
using CRL.DataService.Interfaces;
using CRL.DataService.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRL.WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Route")]
    public class RouteController : Controller
    {

        private readonly IRouteService routeService;
        private readonly IMapper mapper;

        public RouteController(IRouteService routeService, IMapper mapper)
        {
            this.routeService = routeService;
            this.mapper = mapper;
        }

        // GET: api/Route
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Route/5
        [HttpGet("{id}", Name = "GetRoute")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        [Route("all")]
        public OkObjectResult GetAll()
        {
            var result = mapper.Map<List<RouteEntity>, List<RouteViewModel>>(this.routeService.GetAll());
            return Ok(result);
        }

        // POST: api/Route
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Route/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
