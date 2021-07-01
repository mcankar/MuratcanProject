using ProjectCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel.Entities
{
    public class Post : CoreEntity
    {
        public string Title { get; set; }
        public string PostDetail { get; set; }
        public string Tags { get; set; }
        public string ImagePath { get; set; }
        public int ViewCount { get; set; }

        public Guid CategoryID { get; set; } // ForeignKey
        public virtual Category Category { get; set; }  // ID  --> CategoryID

        public Guid UserID { get; set; } // ForeignKey
        public virtual User User { get; set; }

    }
}
