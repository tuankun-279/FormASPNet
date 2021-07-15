using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormASPNet.Models
{
    public class SinhVien
    {
        public int SinhVienId { get; set; }
        public string StudentName { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public byte[] Image { get; set; }
        public string UrlImage { get; set; }
    }
}