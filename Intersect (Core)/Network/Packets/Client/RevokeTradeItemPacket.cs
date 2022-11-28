namespace Intersect.Network.Packets.Client
{

    public class RevokeTradeItemPacket : SlotQuantityPacket
    {

        public RevokeTradeItemPacket(int slot, long quantity) : base(slot, quantity)
        {
        }

    }

}
