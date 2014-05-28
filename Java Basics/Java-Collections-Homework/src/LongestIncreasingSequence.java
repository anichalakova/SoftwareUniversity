import java.util.Scanner;


public class LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] arr = input.split(" ");
		int[] nums = new int[arr.length];
		
		for (int i = 0; i < arr.length; i++) {
			nums[i] = Integer.parseInt(arr[i]);
		}
		
		int counter = 1;
		int counterTemp = 1;
		int position = 0;
		
		System.out.print(nums[0] + " ");
		for (int i = 1; i < nums.length; i++) {
			if (nums[i] > nums[i - 1]) {
				counterTemp++;
				System.out.print(nums[i] + " ");
			}
			else {
				counterTemp = 1;
				System.out.println();
				System.out.print(nums[i] + " ");
			}
			if (counterTemp > counter) {
				counter = counterTemp;
				position = i;
			}
		}
		
		System.out.println();
		
		System.out.print("Longest: ");
		 for (int i = 0; i < counter; i++) {
			System.out.print(nums[position] - counter + 1 + i + " ");
		}
	}

}
