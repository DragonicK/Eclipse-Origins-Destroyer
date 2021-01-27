namespace EngineDestroyer.Network.Packets {
    public class CpCustom : ClientPacket {
        public void Write(int value) {
            msg.Write(value);
        }
        public void Write(byte[] buffer) {
            msg.Write(buffer);
        }
    }
}