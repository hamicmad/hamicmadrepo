using System;
using System.Collections.Generic;


namespace ContactSystem
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NumberPhone { get; set; }


        public override string ToString()
        {
            return $"Имя: {Name} Номер телефона: {NumberPhone}";
        }

    }
}
