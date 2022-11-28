namespace Intersect.Network.Packets.Client
{

    public class DepositItemPacket : SlotQuantityPacket
    {

        public DepositItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
