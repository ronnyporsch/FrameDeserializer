namespace ConsoleApp2;

public class FrameV2
{
    public String nameOfTask { get; set; }
    public String userName { get; set; }
    public double timeStamp { get; set; }
    public int frameNumber { get; set; }
    public int recordingNumber { get; set; }
    public int typeOfRecording { get; set; }
    public Sensor[] sensors { get; set; }

    public class EulerAngles
    {
        public double rotX { get; set; }
        public double rotY { get; set; }
        public double rotZ { get; set; }
    }
    
    public class Quaternion
    {
        public double q0 { get; set; }
        public double q1 { get; set; }
        public double q2 { get; set; }
        public double q3 { get; set; }
    }
    
    public class Sensor
    {
        public int id { get; set; }
        public Quaternion quaternion { get; set; }
        public EulerAngles angles { get; set; }
        public Quaternion relativeQuaternion { get; set; }
        public EulerAngles relativeAngles { get; set; }
    }
}