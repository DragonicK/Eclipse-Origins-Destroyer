using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EngineDestroyer {
    public partial class FrmCustom : Form {
        private enum DataType {
            Byte, 
            Short,
            Int,
            String
        };

        /// <summary>
        /// Representação dos dados dentro do pacote.
        /// </summary>
        private struct Data {
            /// <summary>
            /// Indíce no buffer.
            /// </summary>
            public int Index;

            /// <summary>
            /// Valor do objeto.
            /// </summary>
            public object Value;

            /// <summary>
            /// Quantidade de bytes no buffer.
            /// </summary>
            public int Lenght;

            /// <summary>
            /// Tipo de dado que é representado.
            /// </summary>
            public DataType Type;
        }

        /// <summary>
        /// Pacote de dados.
        /// </summary>
        private byte[] packet = new byte[4]; //inicia com 4, os 4 primeiros bytes representa o tamanho do pacote

        /// <summary>
        /// Lista com o tipo de dados que foi incluido no pacote.
        /// </summary>
        private List<Data> packetData;

        /// <summary>
        /// Tipo de dado escolhido no combobox.
        /// </summary>
        private DataType type = 0;
        
        /// <summary>
        /// Indice do array (pacote).
        /// </summary>
        private int head = 4;

        /// <summary>
        /// Seleciona o tipo de lista para os dados serem exibidos.
        /// 0 = byte array, 1 = 4 bytes items
        /// </summary>
        private byte selectedList = 0;

        private int sendCount = 0;
        private bool loop = false;

        public FrmCustom() {
            InitializeComponent();

        }

        /// <summary>
        /// Define os dados na inicialização.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCustom_Load(object sender, EventArgs e) {
            cmb_datatype.SelectedIndex = 0;
            packetData = new List<Data>();

            //adiciona o tamanho do pacote
            var pData = new Data();
            pData.Index = 0;
            pData.Lenght = sizeof(int);
            pData.Value = packet.Length - 4;
            pData.Type = DataType.Int;
            packetData.Add(pData);

            ListRawData();
            ListDataType();

            lbl_size.Text = "Packet Size: " + packet.Length + " bytes";
        }
        
        /// <summary>
        /// Altera o tipo de dado que será adicionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_datatype_SelectedIndexChanged(object sender, EventArgs e) {
            var index = cmb_datatype.SelectedIndex;

            if (index == -1) { return; }

            type = (DataType)index;
        }

        /// <summary>
        /// Adiciona um valor no pacote.
        /// </summary>
        /// <param name="value"></param>
        private void AddValue(object value) {
            byte[] buffer = null;

            //byte
            if (type == DataType.Byte) {
                long _value = Convert.ToInt64(value);
                if (_value >= byte.MinValue && _value <= byte.MaxValue) {
                    buffer = Write((byte)value);
                }
            }

            //short
            if (type == DataType.Short) {
                long _value = Convert.ToInt64(value);
                if (_value >= short.MinValue && _value <= short.MaxValue) {
                    buffer = Write((short)value);
                }
            }
            
            //int
            if (type == DataType.Int) {
                long _value = Convert.ToInt64(value);
                if (_value >= int.MinValue && _value <= int.MaxValue) {
                    buffer = Write((int)value);
                }
            }

            //string 
            if (type == DataType.String) {
                string _value = Convert.ToString(value);
                if (_value == string.Empty) {
                    return;
                }

                buffer = Write(_value);
            }

            //altera o tamanho do pacote, para a condição atual
            Array.Resize(ref packet, packet.Length + buffer.Length);

            //adiciona os dados
            Array.Copy(buffer, 0, packet, head, buffer.Length);
       
            //e altera o indica para nova posição
            head += buffer.Length;

            //adiciona o dado para representação visual
            var pData = new Data();
            pData.Index = head - buffer.Length;
            pData.Value = value;
            pData.Type = type;
            pData.Lenght = buffer.Length;
            packetData.Add(pData);
        }

        /// <summary>
        /// Exibe os dados de cada posição na lista.
        /// </summary>
        /// <param name="array">Existe os dados como array</param>
        private void ListRawData() {
            string result = string.Empty;
            list_rawdata.Items.Clear();
            list_rawdata.BeginUpdate();

            //exibe na lista um array de bytes
            if (selectedList == 0) {
                for (var n = 0; n < packet.Length; n++) {
                    list_rawdata.Items.Add($"{n}: {packet[n]}");
                }
            }
            //exibe na lista um item com 4 bytes
            else { 
                
                var step = 0;

                for (var n = 0; n < packet.Length; n++) {
                    result += packet[n] + " ";
                    step++;

                    //se já obteve 4 numeros, adiciona na lista e continua no próximo
                    if (step >= 4) {
                        list_rawdata.Items.Add(result);

                        step = 0;
                        result = string.Empty;
                    }

                    //se chegou no final e sobrou alguns números, adiciona o último item
                    if (n == packet.Length - 1) {
                        //se houver algum numero restante
                        if (step < 4) {
                            //adiciona
                            list_rawdata.Items.Add(result);
                        }
                    }
                }
            }

            list_rawdata.EndUpdate();
        }

        /// <summary>
        /// Exibe cada tipo de dado adicionado na lista.
        /// </summary>
        private void ListDataType() {
            var result = string.Empty;

            list_datatype.Items.Clear();
            list_datatype.BeginUpdate();

            for (var n = 0; n < packetData.Count; n++) {

                switch (packetData[n].Type) {
                    case DataType.Byte:
                        result = "1 Byte";
                        break;
                    case DataType.Short:
                        result = "2 Bytes";
                        break;
                    case DataType.Int:
                        result = "4 Bytes";
                        break;
                    case DataType.String:
                        result = "String";
                        break;
                }

                list_datatype.Items.Add($"Position: {packetData[n].Index}   Type: {result}   Data: {packetData[n].Value}");
            }

            list_datatype.EndUpdate();
        }

        /// <summary>
        /// Envia os dados usando todas as conexões.
        /// </summary>
        private void SendData() {
            if (Program.Connections == null) {
                MessageBox.Show("Connect to server before send some packet.", "Message");
                return;
            }

            for (var n = 0; n < Program.Connections.MaxConnection; n++) {
                if (Program.Connections[n].Connected) {
                    Program.Connections[n].Send(packet);
                    sendCount++;
                }
            }

            lbl_send.Text = "Send Count: " + sendCount;
        }

        #region Write Data
        private byte[] Write(string text) {
            var buffer = new byte[text.Length + 4];

            //adiciona o tamanho do texto
            var tBuffer = BitConverter.GetBytes(text.Length);
            Array.Copy(tBuffer, 0, buffer, 0, tBuffer.Length);

            //adiciona o texto
            tBuffer = Encoding.ASCII.GetBytes(text);
            Array.Copy(tBuffer, 0, buffer, 4, tBuffer.Length);

            return buffer;
        }

        private byte[] Write(byte value) {
            var buffer = new byte[sizeof(byte)];
            buffer[0] = value;

            return buffer;
        }

        private byte[] Write(short value) {
            var buffer = new byte[sizeof(short)];
            buffer = BitConverter.GetBytes(value);

            return buffer;
        }

        private byte[] Write(int value) {
            var buffer = new byte[sizeof(int)];
            buffer = BitConverter.GetBytes(value);

            return buffer;
        }
        #endregion

        #region Add, Remove, Clear, Send
        /// <summary>
        /// Obtem e verifica o valor do textbox e adiciona no pacote.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e) {
            //variavel para conversão do valor obtido no textbox
            object value = 0;

            //dados do textbox
            string data = txt_data.Text.Trim();

            if (string.IsNullOrWhiteSpace(data)) {
                return;
            }

            #region Select Data Type
            switch (type) {
                case DataType.Byte:
                    if (!IsNumber(data)) {
                        return;
                    }

                    byte _byte = 0;
                    if (!byte.TryParse(data, out _byte)) {
                        MessageBox.Show($"Incorret value. Use {byte.MinValue} ~ {byte.MaxValue} values.", "Message");
                        return;
                    }

                    value = Convert.ToByte(data);
                    break;
                case DataType.Short:
                    if (!IsNumber(data)) {
                        return;
                    }

                    short _short = 0;
                    if (!short.TryParse(data, out _short)) {
                        MessageBox.Show($"Incorret value. Use {short.MinValue} ~ {short.MaxValue} values.", "Message");
                        return;
                    }

                    value = Convert.ToInt16(data);
                    break;
                case DataType.Int:
                    if (!IsNumber(data)) {
                        return;
                    }

                    int _int = 0;
                    if (!int.TryParse(data, out _int)) {
                        MessageBox.Show($"Incorret value. Use {int.MinValue} ~ {int.MaxValue} values.", "Message");
                        return;
                    }

                    value = Convert.ToInt32(data);
                    break;
                case DataType.String:
                    value = data;
                    break;
            }
            #endregion

            AddValue(value);

            byte[] buffer;

            //exibe o cabeçalho
            if (packet.Length >= 8) {
                buffer = new byte[4];
                Array.Copy(packet, 4, buffer, 0, buffer.Length);
                lbl_header.Text = "Header: " + BitConverter.ToInt32(buffer, 0);
            }

            lbl_size.Text = "Packet Size: " + packet.Length + " bytes";

            //adiciona o tamanho do pacote nos primeiros 4 bytes
            buffer = BitConverter.GetBytes(packet.Length - 4);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            //altera o tamanho do pacote na lista
            var pData = packetData[0];
            pData.Value = packet.Length - 4;
            packetData[0] = pData;

            ListRawData();
            ListDataType();
        }

        /// <summary>
        /// Verifica se há apenas números no texto e exibe a mensagem de erro.
        /// </summary>
        /// <param name="data"></param>
        private bool IsNumber(string data) {
            foreach (var c in data) {
                if (!char.IsNumber(c)) {
                    MessageBox.Show("Please use only numbers when you're not using string", "Message");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Remove um item selecionado da lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_remove_Click(object sender, EventArgs e) {
            var index = list_datatype.SelectedIndex;
            if (index == -1) { return; }

            if (index == 0) {
                MessageBox.Show("You cannot remove packet size.", "Message");
                return;
            }

            //cria um novo buffer
            var pData = packetData[index];
            var buffer = new byte[packet.Length - pData.Lenght];
            var _head = 0;

            //copia todos os elementos menos o selecionado
            for(var n = 0; n< packetData.Count; n++) { 
                if (index == n) {
                    continue;
                }

                Array.Copy(packet, packetData[n].Index, buffer, _head, packetData[n].Lenght);

                //altera o novo indice na lista
                pData = packetData[n];
                pData.Index = _head;
                packetData[n] = pData;

                _head += packetData[n].Lenght;
            }

            packetData.RemoveAt(index);

            Array.Clear(packet, 0, packet.Length);
            Array.Resize(ref packet, buffer.Length);
            Array.Copy(buffer, 0, packet, 0, buffer.Length);

            head = _head;

            //refaz a lista
            ListRawData();
            ListDataType();
        }

        /// <summary>
        /// Limpa todos os dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e) {
            Array.Clear(packet, 0, packet.Length);
            //limpa a lista mas preserva os 4 bytes iniciais
            Array.Resize(ref packet, 4);

            txt_data.Text = string.Empty;

            //limpa o tamanho do pacote na lista
            var pData = packetData[0];
            pData.Value = 0;
            packetData[0] = pData;

            //volta o indice para 4 (inicio do buffer)
            head = 4;

            //limpa a lista e preserva o primeiro elemento
            for(var n = 0; n < packetData.Count; n++) {
                if (n == 0) {
                     continue;
                }

                packetData.RemoveAt(n);
            }

            ListRawData();
            ListDataType();
        }

        /// <summary>
        /// Envia os dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e) {
            var time = Convert.ToInt32(txt_sendtime.Text.Trim());
            timer1.Interval = time;

            if (!loop) {                
                SendData();
            } else {
                if (btn_send.Text == "Start") {
                    StartSend();
                }else {
                    StopSend();
                }
            }
        }

        /// <summary>
        /// Ativa o timer.
        /// </summary>
        private void StartSend() {
            txt_data.Enabled = false;
            btn_add.Enabled = false;
            chk_loop.Enabled = false;
            btn_remove.Enabled = false;
            btn_clear.Enabled = false;
            txt_sendtime.Enabled = false;
            btn_open.Enabled = false;
            btn_save.Enabled = false;

            btn_send.Text = "Stop";
            timer1.Start();
        }

        /// <summary>
        /// Desativa o time.
        /// </summary>
        private void StopSend() {
            txt_data.Enabled = true;
            btn_add.Enabled = true;
            chk_loop.Enabled = true;
            btn_remove.Enabled = true;
            btn_clear.Enabled = true;
            txt_sendtime.Enabled = true;
            btn_open.Enabled = true;
            btn_save.Enabled = true;

            btn_send.Text = "Start";
            timer1.Stop();
        }

        #endregion

        private void btn_bytearray_Click(object sender, EventArgs e) {
            selectedList = 0;
            ListRawData();
        }

        private void list_4bytes_Click(object sender, EventArgs e) {
            selectedList = 1;
            ListRawData();
        }

        #region Save & Open
        /// <summary>
        /// Salva os dados de um pacote.
        /// </summary>
        /// <param name="path"></param>
        private void SavePacket(string path) {
            using (var stream = new FileStream(path, FileMode.Create,  FileAccess.Write)) {
                using (var writer = new BinaryWriter(stream)) {
                    writer.Write(txt_name.Text.Trim());
                    writer.Write(txt_desc.Text.Trim());

                    //escreve a quantidade de dados
                    writer.Write(packet.Length);

                    //escreve os bytes
                    for (var n = 0; n < packet.Length; n++) {
                        writer.Write(packet[n]);
                    }

                    //salva os dados
                    writer.Write(packetData.Count);

                    for (var n = 0; n < packetData.Count; n++) {
                        writer.Write(packetData[n].Index);
                        writer.Write(packetData[n].Lenght);
                        writer.Write((int)packetData[n].Type);
                        writer.Write(packetData[n].Value.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Carrega os dados de um pacote.
        /// </summary>
        /// <param name="path"></param>
        private void OpenPacket(string path) {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read)) {
                using (var reader = new BinaryReader(stream)) {

                    txt_name.Text = reader.ReadString();
                    txt_desc.Text = reader.ReadString();

                    //escreve a quantidade de dados
                    var length = reader.ReadInt32();

                    Array.Clear(packet, 0, packet.Length);
                    Array.Resize(ref packet, length);

                    //escreve os bytes
                    for (var n = 0; n < length; n++) {
                        packet[n] = reader.ReadByte();
                    }

                    packetData.Clear();
                    //salva os dados
                    length = reader.ReadInt32();

                    for (var n = 0; n < length; n++) {
                        var pData = new Data();
                        pData.Index = reader.ReadInt32();
                        pData.Lenght = reader.ReadInt32();
                        pData.Type = (DataType)reader.ReadInt32();
                        pData.Value = reader.ReadString();

                        packetData.Add(pData);
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Abre um arquivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.Filter = "Binary Files | *.bin";
            fileDialog.FilterIndex = 0;

            var result = fileDialog.ShowDialog();

            if (result == DialogResult.Cancel) {
                return;
            }

            OpenPacket(fileDialog.FileName);

            //exibe o cabeçalho
            if (packet.Length >= 8) {
                var buffer = new byte[4];
                Array.Copy(packet, 4, buffer, 0, buffer.Length);
                lbl_header.Text = "Header: " + BitConverter.ToInt32(buffer, 0);
            }

            ListRawData();
            ListDataType();
        }

        /// <summary>
        /// Salva um arquivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e) {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.Filter = "Binary Files | *.bin";
            fileDialog.FilterIndex = 0;

            var result = fileDialog.ShowDialog();

            if (result == DialogResult.Cancel) {
                return;
            }

            SavePacket(fileDialog.FileName);

            MessageBox.Show("Success.", "Message");
        }

        /// <summary>
        /// Envia os dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            SendData();
        }

        /// <summary>
        /// Ativa o loop de mensagens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_loop_CheckedChanged(object sender, EventArgs e) {
            loop = chk_loop.Checked;

            if (loop) {
                btn_send.Text = "Start";
            }
            else {
                btn_send.Text = "Stop";
            }
        }

        private void txt_sendtime_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                e.Handled = false;
                return;
            }

            if (!char.IsNumber(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}