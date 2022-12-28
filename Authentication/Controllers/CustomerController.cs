using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class CustomerController
    {
        //private readonly ICustomerService _service;

        //public CustomerController()
        //{
        //    _service = new CustomerService();
        //}


        //public void GetCustomerCountByFiltered()
        //{
        //    Console.WriteLine(_service.GetCustomerCountByFiltered());
        //}

        //public void GetCustomerAverageByAges()
        //{
        //    Console.WriteLine(_service.GetCustomerAverageByAges());
        //}

        //public void GetCustomerByFiltered()
        //{
        //    int startAge = 20;
        //    int endAge = 30;

        //    var result = (_service.GetCustomersByFiltered(startAge, endAge));

        private readonly ICustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }


        public void GetCustomerCountByFiltered() => Console.WriteLine(_service.GetCustomerCountByFiltered());
        
        public void GetCustomerAverageByAges() => Console.WriteLine(_service.GetCustomerAverageByAges());
        
        public void GetCustomerByFiltered()
        {
            int startAge = 20;
            int endAge = 30;

            var result = (_service.GetCustomersByFiltered(startAge, endAge));


            //int shaiqAge = 0;

            //int pervinAge = 0;

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Position}");


                    //if (item.Name == "Shaiq")
                    //{
                    //    shaiqAge = item.Age;
                    //}
                    //else if (item.Name == "Pervin")
                    //{
                    //    pervinAge = item.Age;
                    //}

                }
               
                //Console.WriteLine(item.GetType());
            }


            //Console.WriteLine(shaiqAge>=pervinAge);
        }
    }
}
