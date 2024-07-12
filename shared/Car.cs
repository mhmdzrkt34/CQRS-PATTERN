using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared
{
    public class Car
    {


        public string id {  get; set; }

        public string name { get; set; }

        public DateTime time {  get; set; }


        public Car()
        {


            id = Guid.NewGuid().ToString();
            time = DateTime.UtcNow;



        }
    }
}
