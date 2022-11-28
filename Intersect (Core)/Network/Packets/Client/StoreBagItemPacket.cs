namespace Intersect.Network.Packets.Client
{

    public class StoreBagItemPacket : SlotQuantityPacket
    {

        public StoreBagItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
