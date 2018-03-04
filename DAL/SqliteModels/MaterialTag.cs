﻿using System;

namespace DAL.SqliteModels
{
    public class MaterialTag
    {
        public Guid MaterialId { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
        public Material Material { get; set; }
    }
}