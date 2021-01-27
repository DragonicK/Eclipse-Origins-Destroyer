namespace EngineDestroyer.Network.Packets {
    public class CpChangeBankSlotOverflow : ClientPacket {
        public CpChangeBankSlotOverflow() {
            msg.Write((int)ClientHeader.CChangeBankSlots);
            msg.Write(int.MaxValue);
            msg.Write(int.MaxValue);
        }
    }
}