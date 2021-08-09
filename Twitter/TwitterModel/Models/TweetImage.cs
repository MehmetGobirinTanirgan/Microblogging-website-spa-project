﻿using System;
using TwitterCore.Entities.CoreEntities;

namespace TwitterModel.Models
{
    public class TweetImage : SimpleEntity
    {
        public string ImagePath { get; set; }

        public Guid TweetID { get; set; }
        public virtual Tweet Tweet { get; set; }
    }
}
