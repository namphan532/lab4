using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication1.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public List<Course> UpcomingCourses { get; internal set; }
    }
}