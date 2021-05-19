using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {
       public string _twitterAdress { get; set; }
      public string SchoolName { get; set; }
      public string SchoolAdress { get; set; }
      public string City{ get; set; }
      public  string Principal { get; set; }
      private  string PhoneNumber { get; set; }
      public string TwitterAdress
        {
            //make sure the twitter address starts with a @
            get { return _twitterAdress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    throw new Exception("twitter address formating should start with @");
                }
            }
        }
    }
}
