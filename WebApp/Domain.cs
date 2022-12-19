using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Adress Adress { get; set; }
        public Company Company { get; set; }




    }
    public class Adress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Suite { get; set; }
        public string ZipCode { get; set; }
        public Geo Geo { get; set; }

    }
    public class Geo
    {
        public float Lat { get; set; }
        public float Lng { get; set; }

    }
    public class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }

    }
}
