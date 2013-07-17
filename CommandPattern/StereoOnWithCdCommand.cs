namespace CommandPattern
{
    public class StereoOnWithCdCommand : ICommand
    {
        private Stereo _stereo;
        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }
    }
}