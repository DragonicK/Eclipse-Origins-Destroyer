using System;
using System.Text;

namespace EngineDestroyer.Network.Packets {
    public class CpBroadcastMessage : ClientPacket {
        public CpBroadcastMessage(string message, bool overflow = false) {
            msg.Write((int)ClientHeader.CBroadcastMsg);

            if (overflow) {
                var buffer = BitConverter.GetBytes(int.MaxValue);
                var values = Encoding.ASCII.GetBytes(message);

                // Escreve o tamanho do texto.
                msg.Write(buffer);
                // Escreve os caracteres.
                msg.Write(values);
            }
            else {
                msg.Write(message);   
            }
        }
    }
}