﻿using GenericApi.Core.BaseModel;
using GenericApi.Core.Enums;

namespace GenericApi.Model.Entities
{
    public class WorkShopMember : BaseEntity
    {
        public WorkShopMemberRole Role { get; set; }
        public int WorkShopId { get; set; }
        public virtual WorkShop WorkShop { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }

}
