using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String Name { get; set; }
        public String Password { get; set; }
        public String facultyNumber { get; set; }
        public int role { get; set; }
        public DateTime Created { get; set; }
        public DateTime activeUntill { get; set; }
    }
}