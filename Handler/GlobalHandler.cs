namespace EngineDestroyer.Handler {
    public static class GlobalHandler {
        public static ConnectionHandler ConnectionHandler { get; set; }

        public static void Initialize() {
            ConnectionHandler = new ConnectionHandler();
        }
        
        public static void Close() {
            ConnectionHandler.Stop();
            ConnectionHandler.Clear();
        }
    }
}