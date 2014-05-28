import java.util.Scanner;


public class SequencesOfEqualString {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] words = input.split(" ");
		
		for (int i = 0; i < words.length; i++) {
			if (i == 0) {
				System.out.print(words[i] + " ");
			}
			else if (words[i].equals(words[i - 1])) {
				System.out.print(words[i] + " ");
			}
			else {
				System.out.println();
				System.out.print(words[i] + " ");
			}
		}
	}

}
