namespace Intersect.Network.Packets.Client
{

    public class BuyItemPacket : SlotQuantityPacket
    {

        public BuyItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
