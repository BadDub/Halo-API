using System;
using HaloEzAPI.Abstraction.Enum;

namespace HaloEzAPI.Model.Response.MetaData
{
    public class FlexibleStat
    {
        public string Name { get; set; }
        public FlexibleStatType Type { get; set; }
        public Guid Id { get; set; }
        public Guid ContentId { get; set; }
    }
}