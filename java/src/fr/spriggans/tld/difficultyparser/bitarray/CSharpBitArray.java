package fr.spriggans.tld.difficultyparser.bitarray;

/**
 * TLD algorith uses a BitArray. This class is the C# interpretation of it. We
 * purposely ignore many error checks.
 */
public class CSharpBitArray {

	private static final int BITS_PER_INT_32 = 4;

	private static final int BITS_PER_BYTE = 8;

	private int[] array;

	private int length;

	public CSharpBitArray(int length) {
		this(length, false);
	}

	public CSharpBitArray(int length, boolean defaultValue) {
		this.array = new int[getArrayLength(length, BITS_PER_INT_32)];
		this.length = length;
		int fillValue = defaultValue ? (((int) 0xffffffff)) : 0;
		for (int i = 0; i < this.array.length; i++) {
			this.array[i] = fillValue;
		}
	}

	public CSharpBitArray(byte[] bytes) {
		this.array = new int[getArrayLength(bytes.length, BITS_PER_INT_32)];
		this.length = bytes.length * BITS_PER_BYTE;

		int i = 0;
		int j = 0;
		while (bytes.length - j >= 4) {
			array[i++] = (bytes[j] & 0xff) | //
					((bytes[j + 1] & 0xff) << 8) | //
					((bytes[j + 2] & 0xff) << 16) | //
					((bytes[j + 3] & 0xff) << 24);
			j += 4;
		}

		int jumpTo = bytes.length - j;

		do {
			switch (jumpTo) {
			case 3:
				this.array[i] = ((bytes[j + 2] & 0xff) << 16);
				jumpTo = 2; // goto case 2
				continue;
			case 2:
				this.array[i] |= ((bytes[j + 1] & 0xff) << 8);
				jumpTo = 1; // goto case 1
				continue;
			case 1:
				this.array[i] |= (bytes[j] & 0xff);
				break;
			}
			// When switch is over, exit do while
			break;
		} while (true);
	}

	private int getArrayLength(int n, int div) {
		return n > 0 ? (((n - 1) / div) + 1) : 0;
	}
	
	public void copyTo(int[] dest, int fromIndex) {
		System.arraycopy(this.array,  0, dest, fromIndex, (this.length + 31) / 32);
	}

	public boolean get(int index) {
		return (this.array[index / 32] & (1 << (index % 32))) != 0;
	}

	public void set(int index, boolean value) {
		if (value) {
			this.array[index / 32] |= (1 << (index % 32));
		} else {
			this.array[index / 32] &= ~(1 << (index % 32));
		}
	}

	public int length() {
		return this.length;
	}
}
