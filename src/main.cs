using System;

var resume = true;
while (resume) {
    Console.Write("$ ");

    var command = Console.ReadLine();
    if (command == "exit") {
        resume = false;
        break;
    }
    Console.WriteLine(command + ": command not found");
}
