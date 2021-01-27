namespace EngineDestroyer.Network.Packets {
    public class CpSwapInventoryOverflow : ClientPacket {
        public CpSwapInventoryOverflow() {
            msg.Write((int)ClientHeader.CSwapInvSlots);
            msg.Write(int.MaxValue);
            msg.Write(int.MaxValue);
        }
    }
}