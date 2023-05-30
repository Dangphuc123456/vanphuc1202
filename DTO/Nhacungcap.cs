using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhacungcap
    {
        public string NhaCCID { get; set; }
        public string TenNCC { get; set; }
        public string DiachiNCC { get; set; }
        public string SdtNCC { get; set; }
        public Nhacungcap() { }
        public Nhacungcap(string nhaCCID, string tenNCC, string diachiNCC, string sdtNCC)
        {
            this.NhaCCID = nhaCCID;
            this.TenNCC = tenNCC;
            this.DiachiNCC = diachiNCC;
            this.SdtNCC = sdtNCC;
        }
    }
}
