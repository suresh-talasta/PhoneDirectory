using PhoneDirectory.Context;
using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhoneDirectory.Controllers
{
    public class PhoneController : ApiController
    {
        //Creating Instance of DatabaseContext class  
        private DatabaseContext db = new DatabaseContext();

        //Creating a method to return Json data   
        [HttpGet]
        [ActionName("All")]
        public IHttpActionResult Get()
        {
            try
            {
                var allPhoneNumbers = db.phoneNumbers.ToList();

                return Ok(allPhoneNumbers);
            }
            catch (Exception)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return InternalServerError();
            }
        }

        [HttpGet]
        [ActionName("GetByCustomerId")]
        public IHttpActionResult GetByCustomerId(string customerID)
        {
            try
            {
                var allPhoneNumbers = db.phoneNumbers.Where(c => c.customerId == customerID).ToList();

                return Ok(allPhoneNumbers);
            }
            catch (Exception)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return InternalServerError();
            }
        }

        [HttpPost]
        [ActionName("AddPhoneNumber")]
        public string AddPhoneNumber(PhoneNumberRequest request)
        {
            try
            {
                //map
                var dbPhone = new PhoneNumber();
                if(request != null)
                {
                    dbPhone.customerId = request.customerId;
                    dbPhone.customerName = request.customerName;
                    dbPhone.customerPhoneNumber = request.customerPhoneNumber;
                    dbPhone.active = request.active;
                }

                var phoneid = db.phoneNumbers.Max(d => d.ID);
                dbPhone.ID = phoneid +1 ;
                var allPhoneNumbers = db.phoneNumbers.Add(dbPhone);
                db.SaveChanges();

                return "success";
            }
            catch (Exception)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return "failed";
            }
        }

        [HttpPost]
        [ActionName("ActivatePhNo")]
        public string ActivatePhNo(ActivatePhoneNo request)
        {
            try
            {
               var phoneNo = (
                                 from p in db.phoneNumbers where p.ID == request.phoneId select p
                               ).FirstOrDefault();
                if(phoneNo != null)
                {
                    phoneNo.active = request.active;
                }
                db.Entry(phoneNo).State = EntityState.Modified;
                db.SaveChanges();

                return "success";
            }
            catch (Exception)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return "failed";
            }
        }
        
    }
}
