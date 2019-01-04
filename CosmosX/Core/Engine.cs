using CosmosX.Core.Contracts;
using CosmosX.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CosmosX.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private ICommandParser commandParser;
        private bool isRunning;

        public Engine(IReader reader, IWriter writer, ICommandParser commandParser)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandParser = commandParser;
            this.isRunning = true;
        }

        public void Run()
        {
            while (isRunning)
            {
                try
                {
                    List<string> args = this.reader.ReadLine().Split().ToList();

                    string result = commandParser.Parse(args);


                    this.writer.WriteLine(result);

                    if (args[0] == "Exit")
                    {
                        isRunning = false;
                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}