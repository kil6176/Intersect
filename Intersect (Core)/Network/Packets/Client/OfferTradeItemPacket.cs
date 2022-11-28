namespace Intersect.Network.Packets.Client
{

    public class OfferTradeItemPacket : SlotQuantityPacket
    {

        public OfferTradeItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
