using System;
using System.Collections.Generic;

namespace SchoolProject.Models;

public partial class Course
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? Credits { get; set; }

    public int? DepartmentId { get; set; }

    public int? TeacherId { get; set; }
}
