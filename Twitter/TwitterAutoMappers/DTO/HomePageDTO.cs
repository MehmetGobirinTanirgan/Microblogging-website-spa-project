﻿using System;

namespace TwitterAutoMappers.DTO
{
    public class HomePageDTO
    {
        public Guid ID { get; set; }
        public string ProfilePicPath { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
    }
}