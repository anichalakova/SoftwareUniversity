import java.util.Scanner;

public class LargestThree {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] numbers = input.split("\\D+");
		int[] nums = new int[numbers.length];
		int tempSum = 0;
		int sum = 0;
		
		for (int i = 1; i < numbers.length; i++) {
			nums[i - 1] = Integer.parseInt(numbers[i]);
		}
		
		for (int i = 0; i < nums.length - 6; i++) {
			tempSum = (nums[i] * nums[i + 1]) + (nums[i + 2] * nums[i + 3]) + (nums[i + 4] * nums[i + 5]);
			if (tempSum > sum) {
				sum = tempSum;
			}
		}
		
		System.out.println(sum);
	}
}
