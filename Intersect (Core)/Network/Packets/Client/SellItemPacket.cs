namespace Intersect.Network.Packets.Client
{

    public class SellItemPacket : SlotQuantityPacket
    {

        public SellItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
