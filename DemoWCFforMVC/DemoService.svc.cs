using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using DemoWCFforMVC.Models;

namespace DemoWCFforMVC
{
   [ServiceBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
    public class DemoService : IDemoService
    {

        public string GetData(string id)
        {
            var result = id.ToUpper();
            result = "You entered this: " + result;
            return result;
        }

        public List<Person> GetDtls()
        {
            List<Person> people = new List<Person>();
            Person p1 = new Person();
            p1.firstName = "ajay";
            p1.lastName = "kumar";
            p1.address = "Jharkhand";
            people.Add(p1);
            Person p2 = new Person();
            p2.firstName = "Manoj";
            p2.lastName = "Yadav";
            p2.address = "Bihar";
            people.Add(p2);
            return people;
        }
    }
}
