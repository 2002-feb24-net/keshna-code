using System;

namespace PersonList
{
    class Person
    {
        [Required(ErrorMessage = "Name is required")]
   string name { get; set; }
                
        int num;
    }
}