import java.util.ArrayList;
import java.util.Scanner;


public class CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String firstInput = in.nextLine();
		firstInput = firstInput.replaceAll(" ", "");
		String secondInput = in.nextLine();
		secondInput = secondInput.replaceAll(" ", "");
		
		ArrayList<Character> firstChars = new ArrayList<> ();
		ArrayList<Character> secondChars = new ArrayList<> ();
		
		for (char c : firstInput.toCharArray()) {
			firstChars.add(c);
		}
		
		for (char c : secondInput.toCharArray()) {
			secondChars.add(c);
		}
		
		for (int i = 0; i < firstChars.size(); i++) {
			System.out.print(firstChars.get(i) + " ");
			if (secondChars.contains(firstChars.get(i))) {
				secondChars.remove(firstChars.get(i));
			}
		}
		for (int i = 0; i < secondChars.size(); i++) {
			System.out.print(secondChars.get(i) + " ");
		}
	}

}
