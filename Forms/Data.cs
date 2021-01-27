using System;
using System.Text;

namespace EngineDestroyer {
    public struct Data {
        public DataType Type { get; set; }

        public byte[] Array;

        public void Write(byte value) {
            Array = new byte[1];
            Array[0] = value;
            Type = DataType.Byte;
        }

        public void Write(short value) {
            Array = BitConverter.GetBytes(value);
            Type = DataType.Short;
        }

        public void Write(int value) {
            Array = BitConverter.GetBytes(value);
            Type = DataType.Integer;
        }

        public void Write(string value) {
            Array = Encoding.ASCII.GetBytes(value);
            Type = DataType.String;
        }

        public byte GetByte() {
            if (Array != null) {
                return Array[0];
            }

            return 0;
        }

        public short GetInt16() {
            if (Array != null) {
                return BitConverter.ToInt16(Array, 0);
            }
            
            return 0;
        }

        public int GetInt32() {
            if (Array != null) {
                return BitConverter.ToInt32(Array, 0);
            }

            return 0;
        }

        public string GetString() {
            if (Array != null) {
                return Encoding.ASCII.GetString(Array);
            }

            return string.Empty;
        }

        public object GetData() {
            switch (Type) {
                case DataType.Byte: return GetByte();
                case DataType.Short: return GetInt16();
                case DataType.Integer: return GetInt32();
                case DataType.String: return GetString();
            }

            return 0;
        }

        public string GetArrayString() {
            var sb = new StringBuilder();

            if (Array != null) {
                for (var i = 0; i < Array.Length; ++i) {
                    sb.Append(Array[i] + " ");
                }
            }

            return sb.ToString();          
        }
    }
}