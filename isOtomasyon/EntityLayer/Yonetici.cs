using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class Yonetici
    {
   
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Yetki { get; set; }
        public string Sifre { get; set; }
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }
       
    }
}
