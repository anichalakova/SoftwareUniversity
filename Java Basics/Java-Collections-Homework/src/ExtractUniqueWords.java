import java.util.Arrays;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;


public class ExtractUniqueWords {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String input = in.nextLine();
		String[] text = input.toLowerCase().split("\\W+");
		Arrays.sort(text);
		Set<String> newSet = new TreeSet<>();
		
		for (String string : text) {
			newSet.add(string);
		}
		
		for (String string : newSet) {
			System.out.println(string);
		}
	}

}
