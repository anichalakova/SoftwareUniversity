import java.util.Scanner;

public class LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] text = input.split(" ");
		int counter = 1;
		int counterTemporary = 1;
		int position = 0;
		
		for (int i = 1; i < text.length; i++) {
			if (text[i].equals(text[i - 1])) {
				counterTemporary++;
			}
			else {
				counterTemporary = 1;
			}
			if (counterTemporary > counter) {
				counter = counterTemporary;
				position = i;
			}
		}
		
		 for (int i = 0; i < counter; i++) {
			System.out.print(text[position] + " ");
		}
	}

}
