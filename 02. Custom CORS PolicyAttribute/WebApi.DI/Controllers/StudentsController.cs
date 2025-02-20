﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.DI.CustomPolicies;
using WebApi.DI.Data;

namespace WebApi.DI.Controllers
{
    //[EnableCors(origins: "http://test.com,http://localhost:58969", headers:"*",methods:"get",exposedHeaders:"*")]
    [CustomCorsPolicy]
    public class StudentsController : ApiController
    {
        //private StudentRepository _repository = new StudentRepository();

        private IStudentRepository _repository;

        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IHttpActionResult Get()
        {
            return Ok(_repository.GetAll());
        }
    }
}
