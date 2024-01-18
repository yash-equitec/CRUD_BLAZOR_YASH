using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public partial class GetSkillsResult
    {
        public int Skills { get; set; }
        public string SkillsName { get; set; }
    }
}
