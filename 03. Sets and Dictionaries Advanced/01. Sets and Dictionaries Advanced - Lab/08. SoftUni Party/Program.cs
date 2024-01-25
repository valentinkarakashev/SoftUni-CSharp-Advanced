namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> VIP = new HashSet<string>();

            HashSet<string> regular = new HashSet<string>();

            while (command != "END")
            {
                if (command == "PARTY")
                {
                    string action = Console.ReadLine();

                    while (action != "END")
                    {
                        if (VIP.Contains(action))
                        {
                            VIP.Remove(action);
                        }
                        else if (regular.Contains(action))
                        {
                            regular.Remove(action);
                        }

                        action = Console.ReadLine();
                    }

                    break;
                }

                if (command[0] == '0' || command[0] == '1' 
                    || command[0] == '2' || command[0] == '3' 
                    || command[0] == '4' || command[0] == '5' 
                    || command[0] == '6' || command[0] == '7' 
                    || command[0] == '8' || command[0] == '9')
                {
                    VIP.Add(command);
                }
                else
                {
                    regular.Add(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(VIP.Count + regular.Count);

            if (VIP.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, VIP));
            }
            if (regular.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, regular));
            }
        }
    }
}