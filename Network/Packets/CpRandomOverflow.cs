using System;

namespace EngineDestroyer.Network.Packets {
    public class CpRandomOverflow : ClientPacket {
        private readonly Random r = new Random();

        public CpRandomOverflow(int header, int length) {
            msg.Write(header);

            for (var i = 0; i < length; i++) {
                msg.Write(r.Next(0, int.MaxValue));
            }
        }
    }
}