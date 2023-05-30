using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Monan
    {
        public string Mamonan { get; set; }
        public string Tenmonan { get; set; }
        public string Loaimonan { get; set; }
        public Monan() { }
        public Monan(string mamonan, string tenmonan, string loaimonan)
        {
            this.Mamonan = mamonan;
            this.Tenmonan = tenmonan;
            this.Loaimonan = loaimonan;
        }
    }
}
