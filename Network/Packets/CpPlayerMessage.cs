using System;
using System.Text;

namespace EngineDestroyer.Network.Packets {
    public class CpPlayerMessage : ClientPacket {
        public CpPlayerMessage(string message, string target, bool overflow =false) {
            msg.Write((int)ClientHeader.CPlayerMsg);
            msg.Write(target);

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