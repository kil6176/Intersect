namespace Intersect.Network.Packets.Client
{

    public class DropItemPacket : SlotQuantityPacket
    {

        public DropItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
