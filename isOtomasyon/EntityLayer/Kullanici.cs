using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Kullanici
    {

        public int Id { get; set; }


        public int MeslekId { get; set; }

        public int DepartmanId { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }

        public string Sifre { get; set; }
        public Meslek meslek { get; set; }
        public Departman Departman { get; set; }

   
    }
}
