using System;
using System.IO;

namespace EngineDestroyer.Network {
    public class ByteBuffer {
        protected MemoryStream buffer;

        protected const int ByteLength = 1;
        protected const int Int16Length = 2;
        protected const int Int32Length = 4;
        protected const int Int64Length = 8;

        public ByteBuffer() {
            buffer = new MemoryStream();
        }

        public ByteBuffer(int capacity) {
            buffer = new MemoryStream(capacity);
        }

        public ByteBuffer(byte[] array) {
            buffer = new MemoryStream(array);
        }

        public byte[] ToArray() {
            return buffer.ToArray();
        }

        public int Length() {
            return (int)buffer.Length;
        }

        public void Flush() {
            buffer.Flush();
            buffer.SetLength(0);
            buffer.Position = 0;
        }

        public void Write(byte[] values) {
            buffer.Write(values, 0, values.Length);
        }

        public void Write(bool value) {
            Write(Convert.ToByte(value));
        }

        public void Write(byte value) {
            buffer.Write(new byte[ByteLength] { value }, 0, ByteLength);
        }

        public void Write(short value) {
            buffer.Write(BitConverter.GetBytes(value), 0, Int16Length);
        }

        public void Write(int value) {
            buffer.Write(BitConverter.GetBytes(value), 0, Int32Length);
        }

        public void Write(long value) {
            buffer.Write(BitConverter.GetBytes(value), 0, Int64Length);
        }

        public void Write(string value) {
            var values = new byte[value.Length];

            for (var i = 0; i < value.Length; i++) {
                values[i] = (byte)value[i];
            }

            Write(value.Length);
            Write(values);
        }
    }
}