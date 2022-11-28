using System;

namespace Intersect.Server.Web.RestApi.Payloads
{

    public struct ItemInfo
    {

        public Guid ItemId { get; set; }

        public long Quantity { get; set; }

        public bool BankOverflow { get; set; }

    }

}
