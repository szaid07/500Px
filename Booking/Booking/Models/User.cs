using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public object firstname { get; set; }
        public object lastname { get; set; }
        public int sex { get; set; }
        public object city { get; set; }
        public object state { get; set; }
        public object country { get; set; }
        public DateTime registration_date { get; set; }
        public object about { get; set; }
        public int usertype { get; set; }
        public string domain { get; set; }
        public bool fotomoto_on { get; set; }
        public string locale { get; set; }
        public bool show_nude { get; set; }
        public int allow_sale_requests { get; set; }
        public string fullname { get; set; }
        public string userpic_url { get; set; }
        public string userpic_https_url { get; set; }
        public object cover_url { get; set; }
        public int upgrade_status { get; set; }
        public bool store_on { get; set; }
        public int photos_count { get; set; }
        public int galleries_count { get; set; }
        public int affection { get; set; }
        public int in_favorites_count { get; set; }
        public int friends_count { get; set; }
        public int followers_count { get; set; }
        public object analytics_code { get; set; }
        public bool invite_pending { get; set; }
        public bool invite_accepted { get; set; }
        public bool can_post_links { get; set; }
       
        

    }
}
