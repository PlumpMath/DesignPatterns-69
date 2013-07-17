using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);

            var garageDoor = new GarageDoor();
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            var stereo = new Stereo();
            var stereoOnWithCD = new StereoOnWithCdCommand(stereo);
            var stereoOn = new StereoOnCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);


            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();

            Console.WriteLine("\n-----Newer Universal Remote-----\n");

            var universalRemote = new RemoteControl();

            universalRemote.AddCommand("Light", lightOn, lightOff);
            universalRemote.AddCommand("GarageDoor", garageDoorOpen, garageDoorClose);
            universalRemote.AddCommand("Stereo", stereoOn, stereoOff);
            universalRemote.AddCommand("StereoWithCD", stereoOnWithCD, stereoOff);

            Console.WriteLine(universalRemote.ToString());

            Input(universalRemote);
        }
        
        static void Input(RemoteControl universalRemote)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Type the button name and [on|off] (ex. GarageDoor on)");
            var input = Console.ReadLine(); // Get string from user
            if (input != null)
            {
                var inputs = input.Split(' ');
                if (inputs[1] == "on")
                {
                    universalRemote.TurnOn(inputs[0]);
                }
                else
                {
                    universalRemote.TurnOff(inputs[0]);
                }
            }
            Input(universalRemote);
        }
    }
}
