import java.util.Scanner;


public class CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] words = input.split("\\W+");
		String word = in.next();
		int count = 0;
		
		for (String string : words) {
			string = string.toLowerCase();
			if (string.equals(word)) {
				count++;
			}
		}
		System.out.println(count);
	}

}
