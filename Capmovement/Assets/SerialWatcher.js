import System.IO.Ports;

function Start () {
	var sp;
	sp = new SerialPort();
	sp.BaudRate = 9600;
	sp.PortName ="/dev/tty.wchusbserial1420";
	sp.Parity = Parity.None;
	sp.DataBits = 8;
	sp.StopBits = StopBits.One;
}

function Update () {
	Debug.log(sp.ReadLine());
}