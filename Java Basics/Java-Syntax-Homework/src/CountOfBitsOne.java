import java.util.Scanner;


public class CountOfBitsOne {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		System.out.println(Integer.bitCount(num));
	}

}
