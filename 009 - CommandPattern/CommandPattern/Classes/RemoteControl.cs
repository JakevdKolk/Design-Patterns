using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        Command[] onCommands = new Command[7];
        Command[] offCommands = new Command[7];
        Command undoCommand;
        List<Command> commandList = new List<Command>();
        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
            undoCommand = noCommand;
        }

        // This method must set the On and Off command to the slot provided
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        // This method must call the OnCommand.Execute() method of the slot provided
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
            commandList.Add(undoCommand);
        }
        

        // This method must call the OffCommand.Execute() method of the slot provided
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
            commandList.Add(undoCommand);

        }

        public void UndoButtonWasPushed(int slot)
        {

            if(commandList.Count == 0)
            {
                undoCommand.Undo();
                return;
            }
            int lastIndex = commandList.Count - 1;
            Command last = commandList[lastIndex];
            last.Undo();
            commandList.RemoveAt(lastIndex);

            undoCommand = commandList.Count > 0 ? commandList[commandList.Count - 1] : new NoCommand();

        }

        public void UndoAllCommands()
        {

            Console.WriteLine("Undoing all commands...");
            for (int i = commandList.Count - 1; i >= 0; i--)
            {
                
                commandList[i].Undo();
            }
            commandList.Clear();
            undoCommand = new NoCommand();
        }
        // Overwritten ToString() to print out each slot and its corresponding command.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for(int i = 0;i < onCommands.Length;i++)
            {
                sb.Append("[slot " + i + "] "+ onCommands[i] + " \t\t  " + offCommands[i] + "\n");
            }
            return sb.ToString();
        }
    }
}
