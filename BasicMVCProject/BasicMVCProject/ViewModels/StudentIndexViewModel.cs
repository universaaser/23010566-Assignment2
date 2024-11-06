using BasicMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVCProject.ViewModels
{
    public class StudentIndexViewModel
    {
        public IQueryable<Student> Students { get; set; }
        public string Search { get; set; }
        public IEnumerable<CampusWithCount> CampusesWithCount { get; set; }
        public string Campus { get; set; }
        public IEnumerable<SelectListItem> CampusFilterItems
        {
            get
            {
                var allCampuses = CampusesWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CampusName,
                    Text = cc.CampusNameWithCount
                });
                return allCampuses;
            }
        }
    }
    public class CampusWithCount
    {
        public int StudentCount { get; set; }
        public string CampusName { get; set; }
        public string CampusNameWithCount
        {
            get
            {
                return CampusName + " (" + StudentCount.ToString() + ")";
            }
        }
    }
}