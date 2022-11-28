namespace Intersect.Network.Packets.Client
{

    public class WithdrawItemPacket : SlotQuantityPacket
    {

        public WithdrawItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
