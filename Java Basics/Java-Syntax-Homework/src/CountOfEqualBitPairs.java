import java.util.Scanner;


public class CountOfEqualBitPairs {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		char[] numBinary = String.format("%10s", Integer.toBinaryString(num)).toCharArray();
		
		int count = 0;
		int length = numBinary.length;
		
		for (int i = 0; i < numBinary.length; i++) {
			if (numBinary[i] == 1) {
				length = i;
				break;
			}
		}
		
		for (int i = length; i < numBinary.length; i++) {
			if (numBinary[i] == numBinary[i + 1]) {
				count++;
			}
		}
		
		System.out.println(count);
	}

}
