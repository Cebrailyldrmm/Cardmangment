using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cardmangment.EFCore
{
    [Table("card")]
    public class Card
    {
        [Key, Required]
        public int id { get; set; }

        public int customerid { get; set; }

        public Customer customer { get; set; } 

        public string name { get; set; } = string.Empty;

        public string surname { get; set; } = string.Empty;

        public string bankname { get; set; } = string.Empty;// QNB, ZİRAAT,İŞ,HALK,GARANTİ OR VS...

        public string cardname { get; set; } = string.Empty;//card name bank card or credit card

        public string cardtype { get; set; } = string.Empty;// master ,visa or troy

        public int cardnumber { get; set; } // card number 5168 1111 2244 3355 8855

        public int cardday { get; set; } // card day 07 , 08 ,10

        public int cardyear { get; set; } // 28 ,29 ,27 

        public int CVC { get; set; } // 353 624 156 
    }
}
