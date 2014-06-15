import java.util.Scanner;


public class SymetricNumbersInRange {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int start = input.nextInt();
		int end = input.nextInt();
		
		for (int i = start; i <= end; i++) {
			if (isSimetric(i) == true) {
				System.out.println(i + " ");
			}
		}
		
	}
	public static boolean isSimetric(int number) {
		boolean answer = true;
		
		if (number == 0) {
			answer = true;
			return answer;
		}
		else {
			if (Integer.toString(number).equals(new StringBuilder(Integer.toString(number)).reverse().toString())) {
				answer = true;
				return answer;
			}
			else {
				answer = false;
				return answer;
			}
		}
	}

}
