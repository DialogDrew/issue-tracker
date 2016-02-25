﻿using System.Collections.Generic;

namespace Case.IssueTracker.Data
{
    public class Project
    {
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public List<Issuetype> issuetypes { get; set; }
        public string formattedname
        {
            get
            {
                return "[" + key + "] " + name;
            }

        }
    }
}
