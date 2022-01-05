using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class FormatingService
    {
        public string AsReadableDate(DateTime date)
        {
            return date.ToString("d");
        }
    }
}
