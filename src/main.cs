using System;

var running = true;
while (running) {
    Console.Write("$ ");

    var command = Console.ReadLine();
    switch (command) { 
        case string subCommand when subCommand.Contains("exit") && !subCommand.Contains("type"): 
            running = false; 
            break;
        case string subCommand when subCommand.Contains("echo") && !subCommand.Contains("type"):
            command = command.Remove(0, 5);
            Console.WriteLine($"{command}");
            break;
        case string subCommand when subCommand.Contains("type"):
            var typeCommand = command.Remove(0, 5);
            switch (typeCommand) {
                case "exit":
                case "type":
                case "echo":
                    Console.WriteLine("{0} is a shell builtin", typeCommand);
                    break;
                default:
                    Console.WriteLine("{0}: not found", typeCommand);
                    break;
            }
            break;
        default: 
            Console.WriteLine($"{command}: command not found"); 
            break;
    }
}
