using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ePortal.Models
{
    public class ProjectEnquiry
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string ContactNumber { get; set; }
        public HouseType HouseType { get; set; }
        public int CarpetArea { get; set; }
        public List<RoomType> Rooms { get; set; }
        public PropertyType PropertyType { get; set; }
        public ProjectStartDuration ProjectStartTimeline { get; set; }
        public BudegetRange Budget { get; set; }
        public string ProjectComments { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectLocation { get; set; }
    }

    public enum HouseType
    {
        Apartment,
        Bunglow
    }

    public enum RoomType
    {
        DrawingRoom,
        Kitchen,
        Bedroom,
        Bathroom
    }

    public enum PropertyType
    {
        Existing,
        NewPropertyInPossession,
        NewPropertyWithPossessionInaMonth,
        NewPropertyWithPossessioInMoreThanaMonth
    }
    public enum ProjectStartDuration
    {
        Immediately,
        In15Days,
        InMonth,
        MoreThanAMonth
    }

    public enum BudegetRange
    {
        Upto2Lakhs,
        In2To5Lakhs,
        In5to10Lakhs,
        MoreThan10Lakhs
    }
}