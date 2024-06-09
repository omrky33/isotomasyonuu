using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Departman
    {
        [Key]
        public int Id { get; set; }
        public string DepartmanAdi { get; set; }

        public ICollection<Yonetici> Yoneticiler { get; set; }
        public ICollection<Kullanici> Kullanicilar { get; set; }
    }
}
