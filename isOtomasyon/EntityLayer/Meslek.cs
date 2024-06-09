using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Meslek
    {

        public int Id { get; set; }
        public string MeslekAdi { get; set; }
        public ICollection<Kullanici> kullanicilar { get; set; }    
    }
}
