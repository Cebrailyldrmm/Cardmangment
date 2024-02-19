using System.ComponentModel.DataAnnotations;

namespace Cardmangment.Models
{
    public class Customermodel
    {
        
        public int id { get; set; }

        public string firtsname { get; set; }=string.Empty;
        
        public string surname { get; set; } = string.Empty;

        public int TC { get; set; }


    }
}
