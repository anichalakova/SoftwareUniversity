import java.util.Scanner;

public class CrossingSequence{

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int firstNum = input.nextInt();
		int secondNum = input.nextInt();
		int thirdNum = input.nextInt();
		int total = 0;
		int[] trib = new int[1000000];
		
		int firstNumber = input.nextInt();
		int step = input.nextInt();
		int stepNumber = 0;
		int[] spiral = new int[1000000];
		
		trib[0] = firstNum;
		trib[1] = secondNum;
		trib[2] = thirdNum;
		
		for (int j = 3; j < 100000; j++) {
			total = firstNum + secondNum + thirdNum;
			firstNum = secondNum;
			secondNum = thirdNum;
			thirdNum = total;
			trib[j] = total;
		}
		
		spiral[0] = firstNumber;
		
		for (int i = 1; i < 100000; i++) {
			stepNumber = firstNumber + step;
			firstNumber = stepNumber;
			spiral[i] = stepNumber;
		}
		
		for (int i : trib) {
			for (int j : spiral) {
				if (i == j) {
					System.out.println(i);
					return;
				}
				else {
					continue;
				}
			}
		}
		System.out.println("No");
	}

}