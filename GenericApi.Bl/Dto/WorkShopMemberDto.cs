using GenericApi.Core.Enums;
using GenericApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Bl.Dto
{
    public class WorkShopMemberDto
    {
        public WorkShopMemberRole Role { get; set; }
        public int WorkShopId { get; set; }
        public int MemberId { get; set; }
        public virtual WorkShop WorkShop { get; set; }
        public virtual Member Member { get; set; }
    }
}
