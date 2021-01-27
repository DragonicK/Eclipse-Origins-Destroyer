namespace EngineDestroyer.Network.Packets {
    public class CpHotbarChangeOverflow : ClientPacket {
        public CpHotbarChangeOverflow() {
            msg.Write((int)ClientHeader.CHotbarChange);
            msg.Write(int.MaxValue);
            msg.Write(int.MaxValue);
            msg.Write(int.MaxValue);
            msg.Write(int.MaxValue);
        }
    }
}