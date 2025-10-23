using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            Light garageLight = new Light("Garage");
            GarageDoor garageDoor = new GarageDoor(garageLight);

            Stereo stereo = new Stereo();

            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(livingRoomCeilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(livingRoomCeilingFan);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

           LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
           LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDownCommand = new GarageDoorDownCommand(garageDoor);


            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);
            StereoOnWithRadioCommand stereoOnWithRadioCommand = new StereoOnWithRadioCommand(stereo);   
            // Define and instantiate an Off and On command for each Vendor class

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3,ceilingFanHigh , ceilingFanOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDownCommand);
            remoteControl.SetCommand(5, stereoOnWithRadioCommand, stereoOffCommand);

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);


            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);



            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);


            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);


            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);

            remoteControl.UndoAllCommands();


            Console.WriteLine(remoteControl);




            // Test the pressing of Buttons here. Don't forget to test the Undo button


        }
    }
}