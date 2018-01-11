namespace EngineDestroyer {
    public enum ClientPacket {
        CNewAccount = 0x1,
        CLogin = 0x3,
        CAddChar = 0x4,
        CUseChar = 0x5,
        CSayMsg = 0x6,
        CEmoteMsg = 0x7,
        CBroadcastMsg = 0x8,
        CPlayerMsg = 0x9,
        CPlayerInfoRequest = 0xF,
        CNeedMap = 0x16,
        CSwapInvSlots = 0x30,
        CChangeBankSlots = 0x44,
        CWithdrawItem  = 0x46,
        CHotbarChange = 0x4E,
        CHotbarUse = 0x4F
    }
}