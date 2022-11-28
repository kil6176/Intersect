namespace Intersect.Network.Packets.Client
{

    public class RetrieveBagItemPacket : SlotQuantityPacket
    {

        public RetrieveBagItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
