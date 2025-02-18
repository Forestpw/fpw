using System;

var running = true;
while (running) {
    Console.Write("$ ");

    var command = Console.ReadLine();
    switch (command) { 
        case string subCommand when subCommand.Contains("exit"): 
            running = false; 
            break;
        case string subCommand when subCommand.Contains("echo"):
            command = command.Remove(0, 5);
            Console.WriteLine($"{command}");
            break;
        default: 
            Console.WriteLine($"{command}: command not found"); 
            break;
    }
}
