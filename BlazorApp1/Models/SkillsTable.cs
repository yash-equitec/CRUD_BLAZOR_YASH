﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorApp1.Models;

public partial class SkillsTable
{
    public int Skills { get; set; }

    public string SkillsName { get; set; }

    public virtual ICollection<StudentTable> Students { get; set; } = new List<StudentTable>();
}