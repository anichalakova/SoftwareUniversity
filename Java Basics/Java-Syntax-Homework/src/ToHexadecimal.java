import java.util.Scanner;


public class ToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		String hexNum = Integer.toHexString(num);
		
		System.out.println(hexNum);

	}

}
