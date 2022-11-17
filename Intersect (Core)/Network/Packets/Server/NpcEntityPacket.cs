namespace Intersect.Network.Packets.Server
{

    public class NpcEntityPacket : EntityPacket
    {

        public int Aggression { get; set; }
        public string Summoner { get; set; }

    }

}
