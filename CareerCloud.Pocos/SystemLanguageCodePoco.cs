﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("System_Language_Codes")]
    public class SystemLanguageCodePoco
    {
        [Key]
        public String LanguageID { get; set; }
        public String Name { get; set; }
        [Column("Native_Name")]
        public String NativeName { get; set; }
    }
}
