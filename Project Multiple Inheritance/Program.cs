// di sini jadi semisal ada interface animal dan jump
public interface IAnimal {
	void Walk();
	void Breath();
	void Sound();
}
public interface IJump {
	void Jump();
}

// di sini dibuat abstract class baru dimana nantinya methodnya bisa dioverride oleh child
// naah di sini class LandAnimal harus memenuhi contract Ianimal
public abstract class LandAnimal : IAnimal {
	public void Walk() {
		//...
	}
	public void Breath() {
		//...
	}
	public abstract void Sound();
}

// disini, cat inherit dari LandAnimal, dan Ijump, tetapi di cat tidak perlu ditulis lagi void walk dan breath
// karena sudah ditulis sebelumnya oleh parentnya yatu LandAnimal. Namun kan voidnya abstract nih, sehingga
// cat perlu melakukan override dan harus dimasukkan ke dalam kelas cat, begitu juga IJump, karena IJump bukan
// inherit dari irang tuanya, sehingga method jump perlu dipenuhi oleh class cat
public class Cat : LandAnimal, IJump {
	public override void Sound() {
		//...
	}
	public void Jump() {
		//...
	}
}
