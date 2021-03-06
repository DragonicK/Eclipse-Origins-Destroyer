﻿using System;
using System.Text;

namespace EngineDestroyer.Network.Packets {
    public class CpLogin : ClientPacket {
        public CpLogin(string username, string password, bool overflow = false) {
            msg.Write((int)ClientHeader.CLogin);

            if (overflow) {
                var buffer = BitConverter.GetBytes(int.MaxValue);
                var user = Encoding.ASCII.GetBytes(username);

                // Escreve o tamanho do texto.
                msg.Write(buffer);
                // Escreve os caracteres.
                msg.Write(user);
            }
            else {
                msg.Write(username);
            }

            msg.Write(password);
        }
    }
}