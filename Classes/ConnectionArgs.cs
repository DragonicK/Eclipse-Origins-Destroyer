namespace EngineDestroyer {
    public struct ConnectionArgs {
        public int Index { get; set; }
        public bool Connected { get; set; }

        public ConnectionArgs(int index, bool connected) {
            Index = index;
            Connected = connected;
        }
    }
}