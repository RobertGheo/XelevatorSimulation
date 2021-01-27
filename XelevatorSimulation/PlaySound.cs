using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
//
// @Robert Bradu
//
namespace XelevatorSimulation
{   
    //
    // This class creates new instance of object that take the Elevator sound
    // and can be called in the project to be played.
    //
    public class PlaySound
    {
        public static SoundPlayer playDoorClosing = new SoundPlayer("ElevatorDoorClosing.wav");
        public static SoundPlayer playDoorOpenFirst = new SoundPlayer("ElevatorDoorsOpenFirstFloor.wav");
        public static SoundPlayer playDoorOpenGround = new SoundPlayer("ElevatorDoorsOpenGroundFloor.wav");
        public static SoundPlayer playGoUp = new SoundPlayer("ElevatorGoingUp.wav");
        public static SoundPlayer playGoDown = new SoundPlayer("ElevatorGoingDown.wav");       
        public static SoundPlayer playAlarm = new SoundPlayer("ElevatorAlarmButton.wav");
        public static SoundPlayer playTeam = new SoundPlayer("ElevatorTeamAlerted.wav");
        public static SoundPlayer playOnline = new SoundPlayer("ElevatorOnline.wav");

    }
    
}
