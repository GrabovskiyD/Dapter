﻿using Dapter.Shared.Entities.Utils;

namespace Dapter.Shared.Entities.Models
{
    public class Song : ItemBaseModel
    {
        public string? Singer { get; set; }
        public string? Style { get; set; }
        public string? ReleaseYear { get; set; }
        public string? Album { get; set; }
        public override Category Category { get; set; } = Category.Song;
    }
}
