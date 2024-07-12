namespace IoTCommunicator.Data.DataContext.Entities
{
    public class AiData
    {
        public int AiIndex { get; set; }
        public int AiMode { get; set; }
        public int AiValueRaw { get; set; }
        public double AiValueScaled { get; set; }
        public int AiValueRawMin { get; set; }
        public int AiValueRawMax { get; set; }
        public double AiValueScaledMin { get; set; }
        public double AiValueScaledMax { get; set; }
        public int AiResetMinValue { get; set; }
        public int AiResetMaxValue { get; set; }
        public int AiStatus { get; set; }
        public int AiBurnoutValue { get; set; }
    }
}
