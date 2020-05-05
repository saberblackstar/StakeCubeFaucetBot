namespace RealStakeCubeFaucetBot
{
    class Faucet
    {
        public long ID { get; set; }
        public string TICKER { get; set; }
        public string NAME { get; set; }
        public string WEBSITE { get; set; }
        public string ADDRESS { get; set; }
        public string AMOUNT_PER_CLAIM { get; set; }
        public string BALANCE { get; set; }
        public long? PREMIUM { get; set; }
        public long? DIFF_IN_SEC { get; set; }
    }
}
