using System;
using System.Collections.Generic;

namespace MultiModelDemo.Models;

public partial class Fee
{
    public int RecNo { get; set; }

    public int? StuId { get; set; }

    public DateOnly? Fdate { get; set; }

    public int? Amount { get; set; }

    public virtual Student? Stu { get; set; }
}
