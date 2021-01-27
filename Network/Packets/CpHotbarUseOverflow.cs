namespace EngineDestroyer.Network.Packets {
    public class CpHotbarUseOverflow : ClientPacket{
        public CpHotbarUseOverflow() {
            msg.Write((int)ClientHeader.CHotbarUse);
            msg.Write(int.MaxValue);
        }
    }
}