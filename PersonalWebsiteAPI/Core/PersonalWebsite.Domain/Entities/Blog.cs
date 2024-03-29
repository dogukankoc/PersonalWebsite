﻿using PersonalWebsiteAPI.Domain.Entities.Common;

namespace PersonalWebsiteAPI.Domain.Entities
{
    public class Blog : BaseEntity
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImagePath { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
