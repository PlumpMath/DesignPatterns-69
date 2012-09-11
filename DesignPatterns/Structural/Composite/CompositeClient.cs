using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DesignPatterns.Structural.Composite
{
    class CompositeClient: BaseClient, IClient
    {
        public override void Init()
        {
            IComponent<string> album = new Component<string>("Album");
            IComponent<string> point = album;
            string[] s;
            string command, parameter;
            //create and manipulate a structure
            StreamReader instream = new StreamReader(@"Structural\Composite\Composite.dat");
            do
            {
                string t = instream.ReadLine();
                Console.WriteLine("\t\t\t\t" + t);
                s = t.Split();
                command = s[0];
                parameter = s.Length > 1 ? s[1] : null;
                switch (command)
                {
                    case "AddSet":
                        IComponent<string> c = new Composite<string>(parameter);
                        point.Add(c);
                        point = c;
                        break;
                    case "AddPhoto":
                        point.Add(new Component<string>(parameter));
                        break;
                    case "Remove":
                        point = point.Remove(parameter);
                        break;
                    case "Find":
                        point = album.Find(parameter);
                        break;
                    case "Display":
                        Console.WriteLine(album.Display(0));
                        break;
                    case "Quit":
                        break;
                }
            } while (!command.Equals("Quit"));
        }
    }
}
