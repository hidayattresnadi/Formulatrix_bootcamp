// Interface itu bearti apabila class lain ingin inherit dari class ini, berarti harus memnuhi contract yang ada di interface tersebut
// Interface hanya bisa public dan berisi method dan property penulisannya seperti di bawah, jadi diawali I baru nama class yang diinginkan
public interface IPrinter {
	void Print();
	void Scan();
	void Fax();
}
public interface IWireless {
	void Connect();
	void Disconnect();
}
public interface IBluetooth {
	void BTConnect();
	void BTDisconnect();
}

// interface dapat diterapkan lebih dari satu pada setiap class baru
// seperti di bawah ini, class IPrinterEpson wajib memenuhi contract dari IPrinter,Iwireless,dan IBluetooth
// penulisan IprinterEpson tidak perlu memakai public class bla bla, cukup public interface saja, apa bila yaa misal g ada tambahan apa2 lagi 
// dari si class IPrinterEpsonnya
public interface IPrinterEpson : IPrinter, IWireless, IBluetooth;

// begitu juga apabila ada class baru dan dia inherit dari class IPrinterEpson, berarti si anak juga wajib memakai contract yang sama dengan parentnya
public class PrinterEpson60Juta :IPrinterEpson {
public void Print() {
		Console.WriteLine("PrinterEpson Print");
	}
	public void Scan() {
		Console.WriteLine("PrinterEpson Scan");
	}
	public void Fax() {
		Console.WriteLine("PrinterEpson Fax");
	}
	public void Connect() {
		Console.WriteLine("PrinterEpson Connect");
	}
	public void Disconnect() {
		Console.WriteLine("PrinterEpson Disconnect");
	}
	public void BTConnect() {
		Console.WriteLine("PrinterEpson BTConnect");
	}
	public void BTDisconnect() {
		Console.WriteLine("PrinterEpson BTDisconnect");
	}
}
public class PrinterEpson : IPrinterEpson {
	public void Print() {
		Console.WriteLine("PrinterEpson Print");
	}
	public void Scan() {
		Console.WriteLine("PrinterEpson Scan");
	}
	public void Fax() {
		Console.WriteLine("PrinterEpson Fax");
	}
	public void Connect() {
		Console.WriteLine("PrinterEpson Connect");
	}
	public void Disconnect() {
		Console.WriteLine("PrinterEpson Disconnect");
	}
	public void BTConnect() {
		Console.WriteLine("PrinterEpson BTConnect");
	}
	public void BTDisconnect() {
		Console.WriteLine("PrinterEpson BTDisconnect");
	}
}

class Speaker : IBluetooth {
	public void BTConnect() {}
	public void BTDisconnect() {}
}
class EpsonWarehouse {
	private IPrinterEpson[] printer;
	public void AddPrinter(IPrinterEpson epson) {
		
	}	
}

class BluetoothDeviceWarehouse {
	private IBluetooth[] bluetooths;
	public void AddDevice(IBluetooth bluetooth) {
	
	}
}

class WirelessDeviceWarehouse {
	private IWireless[] wireless;
	public void AddDevice(IWireless wireless) {
	
	}
}



